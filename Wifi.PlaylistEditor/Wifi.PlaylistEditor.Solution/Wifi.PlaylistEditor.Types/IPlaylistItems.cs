using System;
using System.IO;

namespace Wifi.PlaylistEditor.Types
{
    public interface IPlaylistItems
    {
        string Titel { get; }
        String Artist { get; }
        TimeSpan Duration { get; }
        String Path { get; }
        //Image Thumbnail { get; }
        Guid Item_Guid { get; }
        Guid PlayList_Guid { get; }
    }
}
