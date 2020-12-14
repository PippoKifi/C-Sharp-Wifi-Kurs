using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using Wifi.PlaylistEditor.Types;


namespace Wifi.PlaylistEditor.Items
{
    public class Mp3Item : IPlaylistItem
    {
        private string _title;
        private string _artist;
        private TimeSpan _duration;
        private string _path;
        private Guid _playlist_Guid;
        private Guid _item_Guid;
        private Image _thumbnail;

        public Mp3Item(FileInfo path, Guid playlist_Guid)
        {
            try //Frage -- Kann/Soll ein Try-Catch in einem Konstruktor verwendet werden?
            {
                _path = path.Name;
                if (File.Exists(_path))
                {
                    ReadIdv3TagsFromFile(path);
                }
                else
                {
                    _path = "--[Path not Exist!]--";
                    InitFiledsWithEmpty();
                }
            }
            catch (ArgumentException)
            {
                _path = "--[ArgumentException!]--";
                InitFiledsWithEmpty();
            }
            catch (System.NullReferenceException)
            {
                _path = "--[NullReferenceException!]--";
                InitFiledsWithEmpty();
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                _path = "--[DirectoryNotFoundException!]--";
                InitFiledsWithEmpty();
            }

            catch (System.IO.PathTooLongException)
            {
                _path = "--[PathTooLongException!]--";
                InitFiledsWithEmpty();
            }
            catch (NotSupportedException)
            {
                _path = "--[NotSupportedException!]--";
                InitFiledsWithEmpty();
            }

            _playlist_Guid = playlist_Guid;
            _item_Guid = Guid.NewGuid();
        }

        private void InitFiledsWithEmpty()
        {
            _artist = string.Empty;
            _duration = TimeSpan.Zero;
            _thumbnail = null;
            _title = "--[File not found]--";
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

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public Image Thumbnail
        {
            get { return _thumbnail; }
            set { _thumbnail = value; }
        }


        private void ReadIdv3TagsFromFile(FileInfo mp3File)
        {
            /*Infos
https://github.com/mono/taglib-sharp
https://de.wikipedia.org/wiki/M3U

Erweiterte M3U
Im Unterschied zur einfachen M3U werden in der erweiterten M3U zusätzlich Metadaten und ein Kopfdatenbereich verwendet.
Beispiel:
#EXTM3U
#EXTINF:221,Queen - Bohemian Rhapsody
Titel 1.mp3
#EXTINF:473,Dire Straits - Walk Of Life
Pop\Meine Auswahl\Titel 2.ogg*/

            TagLib.File file = TagLib.File.Create(mp3File.FullName);
            _title = file.Tag.Title;
            _artist = file.Tag.FirstPerformer;
            //_artist = file.Tag.Performers[0];
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
