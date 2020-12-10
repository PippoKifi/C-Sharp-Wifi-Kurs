using System;
using System.Collections.Generic;
using System.Text;


namespace Wifi.PlaylistEditor.Types
{
    public interface IPlaylistRepository
    {
        //FileType Extension { get; } //ToDo
        string Description { get; } //ToDo

        void Load(PlaylistArchiv playListArchiv_ToLoad); //ToDo
        void Save(PlaylistArchiv playListArchiv_ToSave); //ToDo

    }
}
