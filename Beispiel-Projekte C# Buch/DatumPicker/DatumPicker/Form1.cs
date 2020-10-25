using System;
using System.Drawing;
using System.Windows.Forms;

namespace DatumPicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            datPicker1.MinDate = new DateTime(2013, 12, 15);
            datPicker1.MaxDate = new DateTime(2014, 2, 15);
            datPicker1.Value = new DateTime(2014, 1, 15);

            datPicker2.CustomFormat = "dd.MM.yy";
            datPicker2.Format = DateTimePickerFormat.Custom;

            datPicker3.ShowUpDown = true;
            datPicker3.Format = DateTimePickerFormat.Short;

            datPicker4.ShowUpDown = true;
            datPicker4.Format = DateTimePickerFormat.Time;
        }

        private void datPicker_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker datPicker = sender as DateTimePicker;
            lblDatum.Text = datPicker.Value + "";

            DateTime plusTag;
            plusTag = datPicker.Value;
            plusTag = plusTag.AddDays(1);
            lblPlusTag.Text = plusTag + "";
        }
    }
}
