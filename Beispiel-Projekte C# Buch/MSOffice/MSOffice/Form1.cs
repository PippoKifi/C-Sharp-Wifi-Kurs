using System;
using System.Drawing;
using System.Windows.Forms;

using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;

namespace MSOffice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdWord_Click(object sender, EventArgs e)
        {
            Word.Application objWord = new Word.Application();
            objWord.Visible = true;
            objWord.WindowState =
                Word.WdWindowState.wdWindowStateNormal;

            Word.Document objDoc = objWord.Documents.Add();

            Word.Paragraph objPara;
            for (int i = 1; i <= 5; i++)
            {
                objPara = objDoc.Paragraphs.Add();
                objPara.Range.Text = "Zeile " + i;
                objPara.Range.InsertParagraphAfter();
            }

            Word.Table objTable;
            objTable = objDoc.Tables.Add(
                objDoc.Bookmarks["\\endofdoc"].Range, 3, 5);
            objTable.Borders.InsideLineStyle =
                Word.WdLineStyle.wdLineStyleSingle;
            objTable.Borders.OutsideLineStyle =
                Word.WdLineStyle.wdLineStyleDouble;
            for (int i = 1; i <= 3; i++)
                for (int k = 1; k <= 5; k++)
                    objTable.Cell(i, k).Range.Text = i + " / " + k;

            objDoc.SaveAs("C:\\Temp\\WordMitVCSharp.docx");
            objDoc.Close();
            objWord.Quit();
        }

        private void cmdExcel_Click(object sender, EventArgs e)
        {
            Excel.Application objExcel = new Excel.Application();
            objExcel.Visible = true;
            objExcel.WindowState = Excel.XlWindowState.xlNormal;

            Excel.Workbook objWorkbook = objExcel.Workbooks.Add();

            Excel.Worksheet objWorksheet = objWorkbook.Worksheets["Tabelle1"];
            for (int i = 1; i <= 5; i++)
                objWorksheet.Cells[i, 1] = i;

            objWorkbook.SaveAs("C:\\Temp\\ExcelMitVCSharp.xlsx");
            objWorkbook.Close();
            objExcel.Quit();
        }
    }
}
