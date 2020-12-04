using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wifi.PlaylistEditor.Types;


namespace Wifi.PlaylistEditor.Items
{
    public class mp3Item : IPlaylistItems
    {

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
        public string Titel => throw new NotImplementedException();

        public string Artist => throw new NotImplementedException();

        public int Duration => throw new NotImplementedException();

        public string Path => throw new NotImplementedException();

        //public MediaTypeNames.Image Thumbnail => throw new NotImplementedException();


        //private void AddFileToListview(string fullFilePath)
        //{
        //    double nanoseconds;
        //    string totalTime = string.Empty;

        //    //First things first, does the file even exist, if not then exit
        //    if (!File.Exists(fullFilePath))
        //        return;

        //    //get the song name
        //    string song = Path.GetFileName(fullFilePath);

        //    //get the directory
        //    string directory = Path.GetDirectoryName(fullFilePath);

        //    //hack off the trailing \
        //    if (directory.EndsWith(Convert.ToString(Path.DirectorySeparatorChar)))
        //        directory = directory.Substring(0, directory.Length - 1);

        //    //now we use the WindowsAPICodePack.Shell to start calculating the songs time
        //    ShellFile shell = ShellFile.FromFilePath(fullFilePath);

        //    //get the length is nanoseconds
        //    double.TryParse(shell.Properties.System.Media.Duration.Value.ToString(), out nanoseconds);

        //    //first make sure we have a value greater than zero
        //    if (nanoseconds > 0)
        //    { //TODO
        //        double milliseconds = nanoseconds * 0.000001;
        //        //TimeSpan time = TimeSpan.FromSeconds(Utilities.ConvertToMilliseconds(nanoseconds) / 1000);
        //        //totalTime = time.ToString(@"m\:ss");
        //    }

        //    //build oour song data
        //    ListViewItem item = new ListViewItem();
        //    item.Text = song;
        //    item.SubItems.Add(totalTime);

        //    //now my first run at this gave me a cross-thread exception when trying to add multiple single mp3's
        //    //but I could add all the whole directories I wanted, o that is why we are now using BeginINvoke to access the ListView
        //    if (listView_PlayListElements.InvokeRequired)
        //        listView_PlayListElements.BeginInvoke(new MethodInvoker(() => listView_PlayListElements.Items.Add(item)));
        //    else
        //        listView_PlayListElements.Items.Add(item);
        //    //mp3Item
        }



    //}
}
