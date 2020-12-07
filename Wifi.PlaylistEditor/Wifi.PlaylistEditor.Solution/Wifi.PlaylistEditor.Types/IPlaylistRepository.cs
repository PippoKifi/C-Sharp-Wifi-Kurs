using System;
using System.Collections.Generic;
using System.Text;

namespace Wifi.PlaylistEditor.Types
{
    public interface IPlaylistRepository
    {
        string Extension { get; } //ToDo
        string Description { get; } //ToDo

        void Load(PlayListArchiv playListArchiv_ToLoad); //ToDo
        void Save(PlayListArchiv playListArchiv_ToSave); //ToDo

    }
}
