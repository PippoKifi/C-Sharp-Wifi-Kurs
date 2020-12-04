using iTextSharp.text;
using Microsoft.WindowsAPICodePack.Shell;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wifi.PlaylistEditor.Types;

namespace Wifi.PlaylistEditor
{
    public partial class Form_Main : Form
    {

       public PlaylistArchiv MeinPlaylistArchiv = new PlaylistArchiv(); //Instanz der Klasse PlaylistArchiv anlagen (Eine braucht es immer!)
        public AskTheEndUserSomething myQuestionForEndUser;

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


        private void toolStripButton_NeuePlalistAnlegen_Click_1(object sender, EventArgs e)
        {
            //PlayList-NAME erfragen
            myQuestionForEndUser = new AskTheEndUserSomething("Wie soll deine neuen PlayList benannt werden?", true);
            lbl_playlistTitel.Text = myQuestionForEndUser.ReplayFromEndUser;

            //PlayList-AUTOR erfragen
            myQuestionForEndUser = new AskTheEndUserSomething("Wie ist dein Name?", true);
            toolStripLabel_PlaylistAutor.Text = myQuestionForEndUser.ReplayFromEndUser;
            this.Text = toolStripLabel_PlaylistAutor.Text + "'s PlaylistEditor";

            //Neue PlayList erstellen
            var myNewPlaylist = new PlayList(lbl_playlistTitel.Text, toolStripLabel_PlaylistAutor.Text); //Playlist Instanze erstellen
            MeinPlaylistArchiv.Add(myNewPlaylist); //Playlist-Instanze dem Archiv hinzufügen
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
           

            //get the file names
            string[] songs = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            foreach (var song in songs)
                //make sure the file exists
                if (File.Exists(song))
                {
                    //if it's an mp3 file then call AddFileToListview
                    if (string.Compare(Path.GetExtension(song), ".mp3", true) == 0)
                    {
                        //AddFileToListview(song); //TODO
                    }
                }
                //A HA! It's a directory not a single file
                else if (Directory.Exists(song))
                {
                    //get the directory information
                    DirectoryInfo di = new DirectoryInfo(song);

                    //get all the mp3 files (will add WMA in the future)
                    FileInfo[] files = di.GetFiles("*.mp3");

                    //here we use a parallel loop to loop through every mp3 in the
                    //directory provided
                    foreach (var file in files)
                    {
                        //AddFileToListview(file.FullName); //TODO

                    }

                }
            

            //we're using a Parallel.ForEach loop because if a directory is selected it can contain n number of items, this is to help prevent a bottleneck.
            //Parallel.ForEach(songs, song =>
            //{
            //    //make sure the file exists
            //    if (File.Exists(song))
            //    {
            //        //if it's an mp3 file then call AddFileToListview
            //        if (string.Compare(Path.GetExtension(song), ".mp3", true) == 0)
            //        {
            //            AddFileToListview(song);
            //        }
            //    }
            //    //A HA! It's a directory not a single file
            //    else if (Directory.Exists(song))
            //    {
            //        //get the directory information
            //        DirectoryInfo di = new DirectoryInfo(song);

            //        //get all the mp3 files (will add WMA in the future)
            //        FileInfo[] files = di.GetFiles("*.mp3");

            //        //here we use a parallel loop to loop through every mp3 in the
            //        //directory provided
            //        Parallel.ForEach(files, file =>
            //        {
            //            AddFileToListview(file.FullName);
            //        });
            //    }
            //});
        }
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
    }
}
