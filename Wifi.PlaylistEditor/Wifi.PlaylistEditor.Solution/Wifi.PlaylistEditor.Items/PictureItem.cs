using System;
using System.Drawing;
using System.IO;
using Wifi.PlaylistEditor.Types;

namespace Wifi.PlaylistEditor.Items
{
    public class PictureItem : IPlaylistItem
    {
        public string Titel => throw new NotImplementedException();

        public string Artist => throw new NotImplementedException();

        public TimeSpan Duration => throw new NotImplementedException();

        public string Path => throw new NotImplementedException();

        public Guid PlayList_Guid => throw new NotImplementedException();

        public Guid Item_Guid => throw new NotImplementedException();

        public Image Thumbnail { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //public MediaTypeNames.Image Thumbnail => throw new NotImplementedException();
    }
}
