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
        private PlayList Playlist_IAmCurrentlyUsing;
        public String RememberAutor = "";

        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {


            lbl_playlistTitel.Text = "";
            toolStripLabel_PlaylistAutor.Text = "";
            toolStripLabel_Artist.Text = "...";
            toolStripLabel_Titel.Text = "...";
            toolStripLabel_Duration.Text = "00:00:00";

            // Enable drag and drop for this form
            // (this can also be applied to any controls)
            this.AllowDrop = true;

            // Add event handlers for the drag & drop functionality
            //this.DragEnter += new DragEventHandler(Form_Main_DragEnter);
            this.DragDrop += new DragEventHandler(Form_Main_DragOver);


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
            Playlist_IAmCurrentlyUsing = new PlayList(lbl_playlistTitel.Text, toolStripLabel_PlaylistAutor.Text); //Playlist Instanze erstellen
            MeinPlaylistArchiv.Add(Playlist_IAmCurrentlyUsing); //Playlist-Instanze dem Archiv hinzufügen
            AddPlaylist_ToOverwieListView(Playlist_IAmCurrentlyUsing); //Add Playlist to ListView

            //ListViewItem_PlaylistItem item = new ListViewItem_PlaylistItem();
            //item.Text = lbl_playlistTitel.Text;
            //item.SubItems.Add(toolStripLabel_PlaylistAutor.Text);
            //ListView_PlaylistOverwie.Items.Add(item);
        }

        private void AddPlaylist_ToOverwieListView(PlayList playlistItem)
        {
            ListViewItem_PlaylistItem ListView_Item = new ListViewItem_PlaylistItem();
            ListView_Item.Text = playlistItem.Name;
            ListView_Item.PlaylistGuid = playlistItem.PlayListGuid;
            ListView_PlaylistOverwie.Items.Add(ListView_Item);
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
            switch (type_OfNewElement)
            {
                case FileType.mp3:
                    Mp3Item myNewmp3Item = new Mp3Item(fullFile, Playlist_IAmCurrentlyUsing.PlayListGuid);
                    Playlist_IAmCurrentlyUsing.Add(myNewmp3Item); //Item der Playlist hinzufügen
                    AddItem_ToListView(myNewmp3Item); //Item in ListView erstellen
                    lbl_playlistSpielzeit.Text = Playlist_IAmCurrentlyUsing.PlayList_Duration.ToString();
                    break;

                case FileType.jpg:

                    break;

                case FileType.notPermitted:

                    break;

                default:
                    break;
            }
        }


        private void AddItem_ToListView(IPlaylistItem playlistItem)
        {
            ListViewItem_PlaylistItem ListView_Item = new ListViewItem_PlaylistItem();
            ListView_Item.Text = playlistItem.Title;
            ListView_Item.ToolTipText = playlistItem.Title + " | " + playlistItem.Path;
            ListView_Item.PlaylistGuid = playlistItem.PlayList_Guid;
            ListView_Item.PlaylistItemGuid = playlistItem.Item_Guid;
            //ListView_Item.SubItems.Add(playlistItem.Duration.ToString);

            ListView_PlayListElements.Items.Add(ListView_Item);
        }


        private void listView_PlayListElements_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedItem = ListView_PlaylistOverwie.SelectedItems;
            foreach (ListViewItem_PlaylistItem item in selectedItem)
            {
                //IPlaylistItems selectedPlaylistItem = PlaylistArchiv.GiveMe_AnItem(item.PlaylistItemGuid);




            }
        }


        private void ListView_PlaylistOverwie_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView_PlayListElements.Clear(); //Alle Elemente in ListView löschen
            ListView.SelectedListViewItemCollection selectedItem = ListView_PlaylistOverwie.SelectedItems;
            foreach (ListViewItem_PlaylistItem item in selectedItem)
            {
                PlayList selectedPlayList = MeinPlaylistArchiv.GiveMe_AnPlayList(item.PlaylistGuid);
                toolStripLabel_PlaylistAutor.Text = selectedPlayList.Autor;
                this.Text = selectedPlayList.Autor + "'s PlaylistEditor";
                lbl_playlistTitel.Text = selectedPlayList.Name;
                lbl_playlistSpielzeit.Text = selectedPlayList.PlayList_Duration.ToString();

                foreach (var IPlaylistItems in selectedPlayList.ItemList)
                {
                    AddItem_ToListView(IPlaylistItems);

                }
            }
        }


        private void Form_Main_DragDrop(object sender, DragEventArgs e)
        {

        }


        private void Form_Main_DragEnter(object sender, DragEventArgs e)
        {

        }


        private void delete_AllItemsInListView(ListView deleteAllItemsFromThisListView)
        {
            if (deleteAllItemsFromThisListView.SelectedItems != null)
            {
                {
                    for (int i = 0; i < deleteAllItemsFromThisListView.Items.Count; i++)
                    {
                        if (deleteAllItemsFromThisListView.Items[i].Selected)
                        {
                            deleteAllItemsFromThisListView.Items[i].Remove();
                            i--;
                        }
                    }
                }
            }

        }


        private void delete_SigleItemsInListView(ListView deleteSelectedItem_InThisListView)
        {
            if (deleteSelectedItem_InThisListView.SelectedItems != null)
            {
                {
                    for (int i = 0; i < deleteSelectedItem_InThisListView.Items.Count; i++)
                    {
                        if (deleteSelectedItem_InThisListView.Items[i].Selected)
                        {
                            deleteSelectedItem_InThisListView.Items[i].Remove();
                            i--;
                        }
                    }
                }
            }
        }


        private void toolStripButton_MailForm_TopMost_Click(object sender, EventArgs e)
        {
            if (this.TopMost == true)
            {
                this.TopMost = false;
                toolStripButton_MailForm_TopMost.BackColor = System.Drawing.Color.LightGray;
            }
            else
            {
                this.TopMost = true;
                toolStripButton_MailForm_TopMost.BackColor = System.Drawing.Color.Magenta;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }


        private void toolStripButton_FullDelete_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedItem = ListView_PlaylistOverwie.SelectedItems;
            foreach (ListViewItem_PlaylistItem item in selectedItem)
            {
                DialogResult dialogResult = MessageBox.Show("Möchtest du tatsächlich die PlayList löschen?", "Alles löschen", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MeinPlaylistArchiv.DeleteAllObjects();
                }
                else if (dialogResult == DialogResult.No)
                { //do something else }
                }
            }
        }


        private void toolStripButton_DeletePlaylist_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedItem_InListView = ListView_PlaylistOverwie.SelectedItems;
            foreach (ListViewItem_PlaylistItem item in selectedItem_InListView)
            {
                PlayList selectedPlayList = MeinPlaylistArchiv.GiveMe_AnPlayList(item.PlaylistGuid);
                DialogResult dialogResult = MessageBox.Show("Möchtest du tatsächlich der KOMPLETTE PlaylistEditor bereinigen?", "Playlist löschen", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MeinPlaylistArchiv.DeletePlaylist(selectedPlayList.PlayListGuid);
                    delete_SigleItemsInListView(ListView_PlaylistOverwie); //ListView Item löschen
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }


        private void toolStripButton_DeleteSelectedPlaylistItem_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedItem_InListView = ListView_PlayListElements.SelectedItems;
            foreach (ListViewItem_PlaylistItem item in selectedItem_InListView)
            {
                IPlaylistItem selectedPlayList_Item = MeinPlaylistArchiv.GiveMe_AnItem(item.PlaylistGuid);
                DialogResult dialogResult = MessageBox.Show("Möchtest sie tatsächlich dieses ITEAM löschen?", "Playlist-Element löschen", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MeinPlaylistArchiv.DeleteItem(selectedPlayList_Item.Item_Guid, item.PlaylistItemGuid);
                    delete_SigleItemsInListView(ListView_PlayListElements);
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }


    }
}
