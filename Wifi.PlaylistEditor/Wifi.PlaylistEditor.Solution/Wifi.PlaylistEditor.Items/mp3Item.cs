using Microsoft.WindowsAPICodePack.Shell;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using Wifi.PlaylistEditor.Types;


namespace Wifi.PlaylistEditor.Items
{
    public class mp3Item : IPlaylistItem
    {
        /*Infos
        //https://github.com/mono/taglib-sharp
        //https://de.wikipedia.org/wiki/M3U

        /*Erweiterte M3U
        Im Unterschied zur einfachen M3U werden in der erweiterten M3U zusätzlich Metadaten und ein Kopfdatenbereich verwendet.
        Beispiel:
        #EXTM3U
        #EXTINF:221,Queen - Bohemian Rhapsody
        Titel 1.mp3
        #EXTINF:473,Dire Straits - Walk Of Life
        Pop\Meine Auswahl\Titel 2.ogg*/


        private string _titel;
        private string _artist;
        private TimeSpan _duration;
        private string _path;
        private Guid _playlist_Guid;
        private Guid _item_Guid;
        private Image _thumbnail;


        public mp3Item(FileInfo path, Guid playlist_Guid)
        {
            _path = path.FullName;
            _playlist_Guid = playlist_Guid;
            _item_Guid = Guid.NewGuid();
            ReadIdv3TagsFromFile(path);
        }


        public Guid PlayList_Guid
        {
            get { return _playlist_Guid; }
        }

        public Guid Item_Guid
        {
            get { return _item_Guid; }
        }

        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

        public TimeSpan Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }

        public string Artist
        {
            get { return _artist; }
            set { _artist = value; }
        }

        public string Titel
        {
            get { return _titel; }
            set { _titel = value; }
        }

        public Image Thumbnail
        {
            get { return _thumbnail; }
            set { _thumbnail = value; }
        }


        private void ReadIdv3TagsFromFile(FileInfo mp3File)
        {
            TagLib.File file = TagLib.File.Create(mp3File.FullName);
            _titel = file.Tag.Title;
            _artist = file.Tag.FirstPerformer;
            _duration = file.Properties.Duration;

            if (file.Tag.Pictures != null && file.Tag.Pictures.Length > 0)
            {
                //https://stackoverflow.com/questions/10247216/c-sharp-mp3-id-tags-with-taglib-album-art
                _thumbnail = Image.FromStream(new MemoryStream(file.Tag.Pictures[0].Data.Data));
            }
            else
            {
                _thumbnail = null;
                Debug.WriteLine($"{System.IO.Path.GetFileName(_path)}: No Image stream found.");
            }
        }
    }


}
