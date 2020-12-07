using System;
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
        public PlayList Load(Guid loadThisPlaylist)
        {
            PlayList playList_ToLoad = new PlayList("Dummy", "Dummy");
            foreach (var playLists in _playlistArchiv)
            {
                if(loadThisPlaylist == playLists.PlayListGuid)
                {
                    return playList_ToLoad = playLists;
                }
            }
            return playList_ToLoad;
        }
        
        public void Add(PlayList newPlayList)
        {
            _playlistArchiv.Add(newPlayList); //PlayListe dem Archiv hinzufügen
            CountPlaylists(); //Item-Counter refresh
            CalcTotPlayListDuration(newPlayList.PlayListGuid);
        }

        private int CountPlaylists()
        {
            foreach (var playLists in _playlistArchiv)
            {
                _countPlayLists += 1;
            }
            return _countPlayLists;
        }

        public TimeSpan CalcTotPlayListDuration(Guid PlaylistGuid)
        {
            TimeSpan totPlaylistDuration = TimeSpan.Zero;
            foreach (var playlistArchiv in _playlistArchiv)
                  {
                foreach (var playlistItem in playlistArchiv.ItemList)
                {
                    if (playlistItem.Item_Guid == PlaylistGuid)
                    {
                        totPlaylistDuration =+ playlistItem.Duration;
                    }
                }
            }
            return totPlaylistDuration;

        }


    }
}
