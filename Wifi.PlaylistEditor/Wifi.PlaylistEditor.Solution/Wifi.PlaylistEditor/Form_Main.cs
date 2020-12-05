using System;
using System.IO;
using System.Windows.Forms;
using Wifi.PlaylistEditor.Items;
using Wifi.PlaylistEditor.Types;

namespace Wifi.PlaylistEditor
{
    public partial class Form_Main : Form
    {

        public PlaylistArchiv MeinPlaylistArchiv = new PlaylistArchiv(); //Instanz der Klasse PlaylistArchiv anlagen (Eine braucht es immer!)
        public AskTheEndUserSomething myQuestionForEndUser;
        private PlayList PlaylistIAmCurrentlyUsing;

        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            // Enable drag and drop for this form
            // (this can also be applied to any controls)
            this.AllowDrop = true;

            // Add event handlers for the drag & drop functionality
            //this.DragEnter += new DragEventHandler(Form_Main_DragEnter);
            this.DragDrop += new DragEventHandler(listView_PlayListElements_DragDrop);


            //TODO
            //Load All Playlists From Repository ### 
            //IPlaylistRepository myPlayList = IPlaylistRepository;
            //myPlayList.Load();



        }


        private void toolStripButton_NeuePlaylistAnlegen_Click_1(object sender, EventArgs e)
        {
            //PlayList-NAME erfragen
            myQuestionForEndUser = new AskTheEndUserSomething("Wie soll deine neuen PlayList benannt werden?", true);
            lbl_playlistTitel.Text = myQuestionForEndUser.ReplayFromEndUser;

            //PlayList-AUTOR erfragen
            myQuestionForEndUser = new AskTheEndUserSomething("Wie ist dein Name?", true);
            toolStripLabel_PlaylistAutor.Text = myQuestionForEndUser.ReplayFromEndUser;
            this.Text = toolStripLabel_PlaylistAutor.Text + "'s PlaylistEditor";

            //Neue PlayList erstellen
            PlaylistIAmCurrentlyUsing = new PlayList(lbl_playlistTitel.Text, toolStripLabel_PlaylistAutor.Text); //Playlist Instanze erstellen
            MeinPlaylistArchiv.Add(PlaylistIAmCurrentlyUsing); //Playlist-Instanze dem Archiv hinzufügen
            AddPlaylist_ToOverwieListView(ListView_PlaylistOverwie, PlaylistIAmCurrentlyUsing); //Add Playlist to ListView

            ListViewItem_PlaylistItem item = new ListViewItem_PlaylistItem();
            item.Text = lbl_playlistTitel.Text;
            item.SubItems.Add(toolStripLabel_PlaylistAutor.Text);
            ListView_PlaylistOverwie.Items.Add(item);
        }


        //Drag MP3's to ListView in C#
        //https://stackoverflow.com/questions/31253883/drag-mp3s-to-listview-in-c-sharp
        private void Form_Main_DragOver(object sender, DragEventArgs e)
        {

            //Wurde schon eine Playlist angelegt?
            if (MeinPlaylistArchiv.CountPlayLists <= 0) //Playlist wurde noch nicht ausgewäht!
            {
                myQuestionForEndUser = new AskTheEndUserSomething("Es wurde noch keine Playlist angelegt! Bitte legen sie eine Playlist an", false);
            }

            else //Playlist wurde schon ausgewäht
            {


                string[] songs = (string[])e.Data.GetData(DataFormats.FileDrop, false);

                foreach (var song in songs)
                    //make sure the file exists
                    if (File.Exists(song))
                    {
                        FileInfo file = new FileInfo(song);
                        FileType aktFileFormat = CheckFilesForAllowedFormat(file);
                        if (FileType.notPermitted != aktFileFormat)
                        {
                            Add(aktFileFormat, file);
                        }
                        else
                        {
                            //File-Format ist nicht erlaubt -> File verwerfen
                        }
                    }
                    //A HA! It's a directory not a single file
                    else if (Directory.Exists(song))
                    {
                        //get the directory information
                        DirectoryInfo di = new DirectoryInfo(song);

                        //get all the mp3 files (will add WMA in the future)
                        FileInfo[] files = di.GetFiles("*.*", SearchOption.AllDirectories);

                        //here we use a parallel loop to loop through every mp3 in the
                        //directory provided
                        foreach (var file in files)
                        {
                            FileType aktFileFormat = CheckFilesForAllowedFormat(file);
                            if (FileType.notPermitted != aktFileFormat)
                            {
                                Add(aktFileFormat, file);
                            }
                            else
                            {
                                //File-Format ist nicht erlaubt -> File verwerfen
                            }
                        }
                    }
            }
        }

        /// <summary>
        /// Checks if the file has the allowed format
        /// </summary>
        /// <param name="fileToChek"></param>
        /// <returns></returns>
        private FileType CheckFilesForAllowedFormat(FileInfo fileToChek)
        {
            string fileExtension = fileToChek.Extension;
            foreach (FileType item in (FileType[])Enum.GetValues(typeof(FileType)))
            {
                if ("." + item == fileExtension)
                {
                    return item;
                }
            }

            return FileType.notPermitted;
        }

        /// <summary>
        /// Adds the new element to the Plalyste
        /// </summary>
        /// <param name="newItem"></param>
        private void Add(FileType type_OfNewElement, FileInfo fullFile)
        {
            IPlaylistItems fileItem;

            switch (type_OfNewElement)
            {
                case FileType.mp3:
                    mp3Item myNewmp3Item = new mp3Item(fullFile, PlaylistIAmCurrentlyUsing.PlayListGuid);
                    Add(myNewmp3Item);
                    break;

                case FileType.jpg:
                    
                    break;

                case FileType.notPermitted:
                    
                    break;

                default:
                    break;

            }
        }

        private void Add(IPlaylistItems playlistItem)
        {
            ListViewItem_PlaylistItem ListView_Item = new ListViewItem_PlaylistItem();
            ListView_Item.Text = playlistItem.Titel;
            ListView_Item.ToolTipText = playlistItem.Titel + " | " + playlistItem.Path;
            ListView_Item.PlaylistGuid = playlistItem.PlayList_Guid;
            ListView_Item.PlaylistItemGuid = playlistItem.Item_Guid;
            //ListView_Item.SubItems.Add(playlistItem.Duration.ToString);

            ListView_PlayListElements.Items.Add(ListView_Item);
        }

        private void AddPlaylist_ToOverwieListView(ListView listView_PlaylistOverwie, PlayList playlistItem)
        {
            ListViewItem_PlaylistItem ListView_Item = new ListViewItem_PlaylistItem();
            ListView_Item.Text = playlistItem.Name;
            ListView_Item.PlaylistGuid = playlistItem.PlayListGuid;
            ListView_PlaylistOverwie.Items.Add(ListView_Item);
        }


        private void Form_Main_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void listView_PlayListElements_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void listView_PlayListElements_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView_PlayListElements_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void ListView_PlaylistOverwie_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Inhalt lösch
            //ListView_PlayListElements.Clear(); //Inhalt von ListView löschen
            //MeinPlaylistArchiv.Load(MeinPlaylistArchiv);

        }

      
    }
}
