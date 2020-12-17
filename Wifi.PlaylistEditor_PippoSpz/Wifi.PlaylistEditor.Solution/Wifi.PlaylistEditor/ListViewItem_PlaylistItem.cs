using System;
using System.Windows.Forms;

namespace Wifi.PlaylistEditor
{
    /// <summary>
    /// ListViewItem_PlaylistItem : ListViewItem
    /// Spz: PlaylistItem + GuidPlaylistGuid
    /// </summary>
    public class ListViewItem_PlaylistItem : ListViewItem
    {
        private Guid _playlistItemGuid;
        private Guid _playlistGuid;

        public ListViewItem_PlaylistItem()
            : base()
        {
            //Es gibt nichts zu tun
        }


        public Guid PlaylistItemGuid
        {
            get { return _playlistItemGuid; }
            set { _playlistItemGuid = value; }
        }

        public Guid PlaylistGuid
        {
            get { return _playlistGuid; }
            set { _playlistGuid = value; }
        }

    }
}
