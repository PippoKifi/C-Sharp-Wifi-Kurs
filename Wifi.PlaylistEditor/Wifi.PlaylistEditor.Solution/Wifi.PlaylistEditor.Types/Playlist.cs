using System;
using System.Collections.Generic;

namespace Wifi.PlaylistEditor.Types
{
    public class PlayList
    {
        private string _name;
        private string _autor;
        private Guid _playListGuid;
        private List<IPlaylistItems> _itemList; //Playlist "HAT EIN" IPlaylistItems


        //################
        //### KONSTRUKTOR ###
        public PlayList(string name, string autor)
        {
            _name = name;
            _autor = autor;
            _itemList = new List<IPlaylistItems>();
            _playListGuid = Guid.NewGuid();
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
            get { return _playListGuid; }
            set { _playListGuid = value; }
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

        public bool IsThereAlreadyAPlaylist()
        {
            //do
            //{
            //    return true;
            //} while (Objekt.Playlist);


            return false;
        }

    }
}
