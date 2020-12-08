using System;
using System.Collections.Generic;

namespace Wifi.PlaylistEditor.Types
{
    public class PlaylistArchiv : IDisposable
    {
        private List<PlayList> _playlistArchiv;
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
        public PlayList GiveMe_AnPlayList(Guid loadThisPlaylist)
        {
            PlayList playList_ToLoad = new PlayList("Dummy", "Dummy");
            foreach (var playLists in _playlistArchiv)
            {
                if (loadThisPlaylist == playLists.PlayListGuid)
                {
                    return playList_ToLoad = playLists;
                }
            }
            return playList_ToLoad;
        }

        public IPlaylistItems GiveMe_AnItem(Guid loadThisIteam, FileType fileType)
        {
            IPlaylistItems playListIteam_ToLoad;
            //switch (fileType)
            //{
            //    case FileType.mp3:
            //        break;
            //    case FileType.jpg:
            //        break;
            //    case FileType.notPermitted:
            //        break;
            //    default:
            //        break;
            //}


            //IPlaylistItems playList_ToLoad;
            foreach (var playlistArchiv in _playlistArchiv)
            {
                foreach (var playlistItem in playlistArchiv.ItemList)
                {
                    if (playlistItem.Item_Guid == loadThisIteam)
                    {
                        playListIteam_ToLoad = playlistItem; 
                        return playListIteam_ToLoad;
                    }
                }
            }
            return playListIteam_ToLoad;
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
                        totPlaylistDuration = +playlistItem.Duration;
                    }
                }
            }
            return totPlaylistDuration;
        }


        public void Save(PlaylistArchiv saveThisData)
        {
            saveThisData.Save(saveThisData);
        }


        public void Load(PlaylistArchiv LoadThisData)
        {
            LoadThisData.Load(LoadThisData);
        }

        public void DeleteAllObjects()
        {
            foreach (var playlistArchiv in _playlistArchiv)
            {
                foreach (var playlistItem in playlistArchiv.ItemList)
                {
                    //playlistItem.Dispose();
                }
                //playlistArchiv.Delete();
            }
        }


        /// <summary>
        /// Delete a specific playlist
        /// </summary>
        /// <param name="Playlist_Guid"></param>
        public bool DeletePlaylist(Guid Playlist_Guid)
        {
            foreach (var playlistArchiv in _playlistArchiv)
            {
                if (playlistArchiv.PlayListGuid == Playlist_Guid)
                {
                    playlistArchiv.Dispose();
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Delete a specific playlist
        /// </summary>
        /// <param name="Playlist_Guid"></param>
        public bool DeleteItem(Guid playlist_Guid, Guid item_Guid)
        {
            foreach (var playList in _playlistArchiv) //Archiv durchlaufen
            {
                foreach (var playlistItem in playList.ItemList) //Playlists in Archiv durchlaufen
                {
                    if (playlistItem.Item_Guid == item_Guid)
                    {
                        //itemsInPlaylist.Dispose(); //TODO
                        return true;
                    }
                }
            }
            return false;
        }

        public void Dispose()
        {
            // close Handle;
            //this.Close();

            // make sure Finalizer will not be called...
            GC.SuppressFinalize(this);
        }
    }
}
