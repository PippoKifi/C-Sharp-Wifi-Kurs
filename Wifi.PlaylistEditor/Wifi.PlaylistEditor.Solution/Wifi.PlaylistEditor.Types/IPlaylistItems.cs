using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Wifi.PlaylistEditor.Types
{
    public interface IPlaylistItems
    {
        string Titel { get; }
        String Artist { get; }
        int Duration { get; }
        string Path { get; }
        Image Thumbnail { get; }
               

    }
}
