using System.Collections.Generic;

namespace Wifi.PlaylistEditor.Types
{
    public class PlaylistArchiv
    {
        private List<PlayList> _playlistArchiv ;
        private int _countPlayLists;
        
        //################
        //### KONSTRUKTOR ### 
        public PlaylistArchiv()
        {
            _playlistArchiv = new List<PlayList>();
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
            //TODO: Alle Playlist zur verfügung stellen - NOTWENDIG?
        }
        
        public void Add(PlayList newPlayList)
        {
            _playlistArchiv.Add(newPlayList); //PlayListe dem Archiv hinzufügen
            CountPlaylists(); //Item-Counter refresh
        }

        private int CountPlaylists()
        {
            foreach (var playLists in _playlistArchiv)
            {
                _countPlayLists += 1;
            }

            return _countPlayLists;
        }


    }
}
