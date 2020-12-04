using System;
using System.Collections.Generic;

namespace Wifi.PlaylistEditor.Types
{
    public class PlaylistArchiv
    {
        private List<PlayList> myPlaylistArchiv ;
        private int _countPlayLists;
        

        //################
        //### KONSTRUKTOR ### 
        public PlaylistArchiv()
        {
            myPlaylistArchiv = new List<PlayList>();
        }


        //#####################
        //### EIGENSCHAFTEN ###
            public int CountPlayLists
        {
            get { return _countPlayLists; }
        }




        //################
        //### METHODEN ###
        public void Load()
        {

        }
        
        public void Add(PlayList newPlayList)
        {
            myPlaylistArchiv.Add(newPlayList); //PlayListe dem Archiv hinzufügen
            CountPlaylists(); //Item-Counter refresh
        }

        private int CountPlaylists()
        {
            foreach (var playLists in myPlaylistArchiv)
            {
                _countPlayLists = +1;
            }

            return _countPlayLists;
        }


    }
}
