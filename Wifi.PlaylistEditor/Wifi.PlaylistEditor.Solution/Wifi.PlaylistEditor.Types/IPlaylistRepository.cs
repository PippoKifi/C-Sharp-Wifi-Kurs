using System;
using System.Collections.Generic;
using System.Text;

namespace Wifi.PlaylistEditor.Types
{
    public interface IPlaylistRepository
    {
        string Extension { get; } //ToDo
        string Description { get; } //ToDo

        void Load(int width); //ToDo
        void Save(int width); //ToDo

    }
}
