using System;
using System.Drawing;
using System.Windows.Forms;

namespace Listenansicht
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lView.View = View.Details;
            lView.FullRowSelect = true;

            ListViewItem eintrag1 = new ListViewItem("Berlin.txt", 0);
            eintrag1.SubItems.Add("120 KB");
            eintrag1.SubItems.Add("13.02.2014");
            lView.Items.Add(eintrag1);

            ListViewItem eintrag2 = new ListViewItem("Paris.txt", 1);
            eintrag2.SubItems.Add("130 KB");
            eintrag2.SubItems.Add("05.02.2014");
            lView.Items.Add(eintrag2);

            ListViewItem eintrag3 = new ListViewItem("Rom.txt", 2);
            eintrag3.SubItems.Add("100 KB");
            eintrag3.SubItems.Add("24.02.2014");
            lView.Items.Add(eintrag3);

            lView.Columns.Add("Name", 100);
            lView.Columns.Add("Größe", 100);
            lView.Columns.Add("Datum", 100);

            ImageList bildklein = new ImageList();
            bildklein.Images.Add(Bitmap.FromFile("bild0.bmp"));
            bildklein.Images.Add(Bitmap.FromFile("bild1.bmp"));
            bildklein.Images.Add(Bitmap.FromFile("bild2.bmp"));
            lView.SmallImageList = bildklein;
            lView.LargeImageList = bildklein;
        }

        private void optView_CheckedChanged(object sender, EventArgs e)
        {
            if (optDetails.Checked)
                lView.View = View.Details;
            else if (optLargeIcon.Checked)
                lView.View = View.LargeIcon;
            else if (optList.Checked)
                lView.View = View.List;
            else if (optSmallIcon.Checked)
                lView.View = View.SmallIcon;
            else if (optTile.Checked)
                lView.View = View.Tile;
        }
    }
}
