using System;
using System.Drawing;
using System.Windows.Forms;

using System.Windows.Forms.DataVisualization.Charting;

namespace DiagrammChart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dChart.Series.Clear();

            dChart.Series.Add(new Series("Umsatz Berlin"));
            dChart.Series[0].Points.AddXY(2009, 10);
            dChart.Series[0].Points.AddXY(2011, 30);
            dChart.Series[0].Points.AddXY(2013, 70);
            dChart.Series[0].Color = Color.Black;
            dChart.Series[0].BorderWidth = 3;
            dChart.Series[0].ChartType = SeriesChartType.Line;

            dChart.Series.Add(new Series("Umsatz Hamburg"));
            dChart.Series[1].Points.AddXY(2009, 25);
            dChart.Series[1].Points.AddXY(2011, 20);
            dChart.Series[1].Points.AddXY(2013, 100);
            dChart.Series[1].Color = Color.Gray;
            dChart.Series[1].BorderWidth = 3;
            dChart.Series[1].ChartType = SeriesChartType.Line;

            dChart.Legends[0].Position =
                new ElementPosition(25, 10, 40, 20);
            dChart.Legends[0].BackColor = Color.LightGray;
            dChart.Legends[0].BorderWidth = 1;
            dChart.Legends[0].BorderColor = Color.Black;

            dChart.ChartAreas[0].AxisX.Minimum = 2009;
            dChart.ChartAreas[0].AxisX.Maximum = 2013;
            dChart.ChartAreas[0].AxisX.Title = "Jahr";
            dChart.ChartAreas[0].AxisX.TitleAlignment =
                StringAlignment.Near;
            dChart.ChartAreas[0].AxisX.LabelStyle.Font =
                new Font("Arial", 8);

            dChart.ChartAreas[0].AxisY.Maximum = 120;
            dChart.ChartAreas[0].AxisY.Title = "1.000 Euro";
            dChart.ChartAreas[0].AxisY.TitleAlignment =
                StringAlignment.Far;
            dChart.ChartAreas[0].AxisY.LabelStyle.Font =
                new Font("Arial", 8);

            dChart.BackColor = Color.LightGray;
            dChart.ChartAreas[0].BackColor = Color.LightBlue;
        }

        private void cmdDrucken_Click(object sender, EventArgs e)
        {
            dChart.Printing.PrintPreview();
        }

        private void cmdSpeichern_Click(object sender, EventArgs e)
        {
            String VollerName = "C:\\Temp\\DiagrammChart.png";
            dChart.SaveImage(VollerName, ChartImageFormat.Png);
            MessageBox.Show("Es wurde die Bilddatei " +
                VollerName + " erzeugt");
        }
    }
}
