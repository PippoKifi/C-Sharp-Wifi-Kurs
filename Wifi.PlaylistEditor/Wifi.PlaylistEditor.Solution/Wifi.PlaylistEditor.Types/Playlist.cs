using System;
using System.Collections.Generic;

namespace Wifi.PlaylistEditor.Types
{
    public class PlayList
    {
        private string _name;
        private string _autor;
        private Guid _playlistGuid;
        private List<IPlaylistItems> _itemList; //Playlist "HAT EIN" IPlaylistItems


        //################
        //### KONSTRUKTOR ###
        public PlayList(string name, string autor)
        {
            _name = name;
            _autor = autor;
            _itemList = new List<IPlaylistItems>();
            _playlistGuid = Guid.NewGuid();
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
        
        public List<IPlaylistItems> ItemList
        {
            get { return _itemList; }
            set { _itemList = value; }
        }

        public Guid PlayListGuid
        {
            get { return _playlistGuid; }
            set { _playlistGuid = value; }
        }

        //################
        //### METHODEN ###
        public void Add(IPlaylistItems ItemToAdd)
        {
            _itemList.Add(ItemToAdd);
        }

        public void Remove()
        {

        }

        public void Clear()
        {

        }

        public void Load()
        {

        }

        public void Save()
        {

        }

    }
}
