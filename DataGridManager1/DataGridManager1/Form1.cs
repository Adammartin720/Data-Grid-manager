using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataGridManager
{
    public partial class Form1 : Form
    {
        string[] sCustID = new string[10];
        string[] sCustName = new string[10];
        string[] sCustMoble = new string[10];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sCustID[0] = "100"; sCustName[0] = "John Williams"; sCustMoble[0] = "01639 355434";
            sCustID[1] = "101"; sCustName[1] = "Bill Smith";    sCustMoble[1] = "01639 352925";
            sCustID[2] = "102"; sCustName[2] = "David Walliams"; sCustMoble[2] = "01639 678965";
            sCustID[3] = "103"; sCustName[3] = "Jason Jones";    sCustMoble[3] = "01639 554433";
            sCustID[4] = "104"; sCustName[4] = "Max Miller";     sCustMoble[4] = "01639 456343";
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
           DGCustomer.Rows.Clear();            
           for (int i = 0; i <= sCustID.Length-1; i++)
            {
                if (sCustID[i] == null) break; 
                DataGridViewRow row = (DataGridViewRow)DGCustomer.Rows[0].Clone();
                row.Cells[0].Value = sCustID[i];
                row.Cells[1].Value = sCustName[i];
                row.Cells[2].Value = sCustMoble[i];
                DGCustomer.Rows.Add(row);
            }
        }

        private void BtnCellValue_Click(object sender, EventArgs e)
        {
            int Row = DGCustomer.SelectedCells[0].RowIndex;
            int Collumn = DGCustomer.SelectedCells[0].ColumnIndex;
            string Data = DGCustomer.Rows[Row].Cells[Collumn].Value.ToString ();
            MessageBox.Show(Data);
        }

        private void BtnRow_Click(object sender, EventArgs e)
        {
            int Row = DGCustomer.SelectedCells[0].RowIndex;
            DGCustomer.Rows.RemoveAt(Row);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            Array.Clear(sCustID, 0, sCustID.Length);
            Array.Clear(sCustName, 0, sCustName.Length);
            Array.Clear(sCustMoble, 0, sCustMoble.Length);

            int Rcount = DGCustomer.Rows.Count;
            for (int Row = 0; Row < Rcount-1; Row++)
            {
                sCustID[Row] = DGCustomer.Rows[Row].Cells[0].Value.ToString();
                sCustName[Row] = DGCustomer.Rows[Row].Cells[1].Value.ToString();
                sCustMoble[Row] = DGCustomer.Rows[Row].Cells[2].Value.ToString();
            }
        }

        private void PDReport_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap image = new Bitmap("NPTC.png");                                
            e.Graphics.DrawImage(image, new Rectangle(0, 0, 200, 200));
            
            int Col = 50;  int Row = 250;
            Font MainHeading = new Font("courier New", 20, FontStyle.Bold);
            Brush Blue =  Brushes.Blue;
            e.Graphics.DrawString("Report", MainHeading, Blue, Col, Row);
            
            
            Col = 50; Row= Row+50;
            Font DataHeading = new Font("courier New", 12, FontStyle.Bold);
            Brush Red =   Brushes.Red ;
            e.Graphics.DrawString("Customer Id", DataHeading, Blue, Col, Row);
            e.Graphics.DrawString("Name", DataHeading, Blue, Col + 200, Row);
            e.Graphics.DrawString("Mobile", DataHeading, Blue, Col + 400, Row);
            e.Graphics.DrawString("_________________________________________________________", DataHeading, Red, Col, Row);
            
            



            Font TextData =    new Font("courier New", 12, FontStyle.Regular);  
            Brush Black = Brushes.Black;
            
            for (int i = 0; i <= sCustID.Length - 1; i++)
            {
                Row = Row + 25;
                if (sCustID[i] == null) break;
                e.Graphics.DrawString(sCustID[i], TextData, Black, Col, Row);
                e.Graphics.DrawString(sCustName[i], TextData, Black, Col + 200, Row);
                e.Graphics.DrawString(sCustMoble[i], TextData, Black, Col + 400, Row);     
            }

            e.Graphics.DrawString("_________________________________________________________", DataHeading, Red, Col, Row);
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

    }
}
