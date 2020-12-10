using System;
using System.Collections.Generic;

namespace Wifi.PlaylistEditor.Types
{
    public class PlayList : IDisposable
    {
        private string _name;
        private string _autor;
        private Guid _playlistGuid;
        private List<IPlaylistItem> _itemList; //Playlist "HAT EIN" IPlaylistItems
        private TimeSpan _playList_Duration;

        //################
        //### KONSTRUKTOR ###
        public PlayList(string name, string autor)
        {
            _name = name;
            _autor = autor;
            _itemList = new List<IPlaylistItem>();
            _playlistGuid = Guid.NewGuid();
            _playList_Duration = TimeSpan.Zero;
        }


        //#####################
        //### EIGENSCHAFTEN ###
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Autor
        {
            get { return _autor; }
            set { _autor = value; }
        }

        public List<IPlaylistItem> ItemList
        {
            get { return _itemList; }
            set { _itemList = value; }
        }

        public Guid PlayListGuid
        {
            get { return _playlistGuid; }
            set { _playlistGuid = value; }
        }

        public TimeSpan PlayList_Duration
        {
            get { return _playList_Duration; }
            set { _playList_Duration = value; }
        }


        //################
        //### METHODEN ###

        /// <summary>
        /// Fügt eine durch das Interface 'IPlaylistItems' typisierte-Instance der Playlist hinzu
        /// </summary>
        /// <param name="ItemToAdd"></param>
        public void Add(IPlaylistItem ItemToAdd)
        {
            _itemList.Add(ItemToAdd);
            PLayListDuration(ItemToAdd.PlayList_Guid);
        }

        public void Remove()
        {

        }

        public void Clear()
        {

        }

        public void Load(IPlaylistItem ItemToAdd)
        {
            
            

            
            PLayListDuration(ItemToAdd.PlayList_Guid);
        }

        public void Save()
        {

        }
        


        /// <summary>
        /// Berechnet die gesamte Spielzeit von der angegebenen Playlist
        /// </summary>
        /// <param name="Playlist_Guid"></param>
        /// <returns>Spielzeit in TimeSpan-Format</returns>
        public TimeSpan PLayListDuration(Guid Playlist_Guid)
        {
            foreach (var playlistItem in _itemList)
            {
                if (playlistItem.PlayList_Guid == Playlist_Guid)
                {
                    _playList_Duration += playlistItem.Duration;
                }
            }

            return _playList_Duration;
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
