using System;
using System.IO;
using System.Drawing;

namespace Wifi.PlaylistEditor.Types
{
    public interface IPlaylistItem
    {
        string Title { get; }
        String Artist { get; }
        TimeSpan Duration { get; }
        String Path { get; }
        Image Thumbnail { get; set;  }
        Guid Item_Guid { get; }
        Guid PlayList_Guid { get; }
    }
}
