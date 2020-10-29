using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing;


namespace Output
{
    class PrintingResults
    {

        RichTextBox rt;
        PrintDocument doc;
        PrintDialog pd;
        PrintPreviewDialog ppd;

        public PrintingResults(RichTextBox richTextBox)
        {
            //Add code to print the results
            rt = richTextBox;
            doc = new PrintDocument();
            pd = new PrintDialog();
            //ppd = new PrintPreviewDialog();

            //ppd.Document = doc;
            pd.Document = doc;

            doc.PrintPage += new PrintPageEventHandler(printPage);
            showDialog();
        }

        private void showDialog()
        {
            //if(ppd.ShowDialog() == DialogResult.OK)
            //{
                if(pd.ShowDialog() == DialogResult.OK)
                {
                try
                {
                    doc.Print();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                }
            //}
        }

        private void printPage(object sender, PrintPageEventArgs e)
        {
            int x = 80;
            int y = 50;
            int charpos = 0;

            while(charpos < rt.Text.Length)
            {
                if(rt.Text[charpos] == '\n')
                {
                    charpos++;
                    y += 20;
                    x = 80;
                }
                else if(rt.Text[charpos] == '\r')
                {
                    charpos++;
                }
                else
                {
                    rt.Select(charpos, 1);
                    e.Graphics.DrawString(rt.SelectedText, rt.SelectionFont, new SolidBrush(rt.SelectionColor), new Point(x, y));
                    x = x + 8;
                    charpos++;
                }
            }
        }

    }
}
