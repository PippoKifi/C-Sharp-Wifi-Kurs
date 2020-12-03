using System;

namespace Wifi.PlaylistEditor.Types
{
    public class Playlist
    {
        private string _name;
        private string _autor;
        private IPlaylistItems _itemList;

        //################
        //### KONSTRUKTOR ###
        public Playlist()
        {
            
            _itemList = new IPlaylistItems();
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
        
        public IPlaylistItems ItemList
        {
            get { return _itemList; }
            set { _itemList = value; }
        }


        //################
        //### METHODEN ###
        public void Add()
        {

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
