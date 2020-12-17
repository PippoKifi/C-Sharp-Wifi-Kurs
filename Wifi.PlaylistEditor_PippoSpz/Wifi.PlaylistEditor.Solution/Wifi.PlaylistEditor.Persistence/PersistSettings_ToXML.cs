using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wifi.PlaylistEditor.Types;

namespace Wifi.PlaylistEditor.PersistSettings
{
    public class PersistSettings_ToXML : IPlaylistRepository
    {
        private string _description;
        //private FileType _extension;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        //public FileType Extension
        //{
        //    get { return _extension; }
        //    set { _extension = value; }
        //}


        //public PersistSettings_ToXML(PlaylistArchiv playListArchiv_ToLoad)
        //{
        //    //Nicht benötigt -> Standard Konstruktor verwenden
        //}


        public void Load(PlaylistArchiv playListArchiv_ToLoad)
        {
            throw new NotImplementedException();
        }

        public void Save(PlaylistArchiv playListArchiv_ToSave)
        {
            throw new NotImplementedException();
        }





    }
}
