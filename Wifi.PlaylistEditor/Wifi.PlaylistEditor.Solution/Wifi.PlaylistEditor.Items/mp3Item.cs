using Microsoft.WindowsAPICodePack.Shell;
using System;
using System.IO;
using Wifi.PlaylistEditor.Types;

namespace Wifi.PlaylistEditor.Items
{
    public class mp3Item : IPlaylistItems
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

        public mp3Item(FileInfo path, Guid playlist_Guid)
        {
            _path = path.FullName;
            _playlist_Guid = playlist_Guid;
            _item_Guid = Guid.NewGuid();
            ExtractMetadateInfosfromFile(path);
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

        private void ExtractMetadateInfosfromFile(FileInfo mp3File)
        {
            TagLib.File file = TagLib.File.Create(mp3File.FullName);
            _titel = file.Tag.Title;
            _artist = file.Tag.FirstPerformer;
            _duration = file.Properties.Duration;

            //String album = file.Tag.Album;
        }


        }



    }
