using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telekomAidatTakip
{
    class Yazdir
    {
        public PrintDocument printDoc = new PrintDocument();
        public PageSetupDialog pageSet = new PageSetupDialog();
        public PrintPreviewDialog printPre = new PrintPreviewDialog();
        //public ListView.ListViewItemCollection items;
        //public Dictionary<string, int> basliklar;
        public ListView list;
        public string baslik;
        
        
        public Yazdir(int version)
        {
            pageSet.Document = printDoc;
            printPre.Document = printDoc;
            if (version == 1)
            {
                printDoc.PrintPage += new PrintPageEventHandler(OnPrintDocument_1);
            }
            else
                printDoc.PrintPage += new PrintPageEventHandler(OnPrintDocument_2);
        }
        public void OnPrintDocument_1(object sender, PrintPageEventArgs e)
        {

            //Yazı fontumu ve çizgi çizmek için fırçamı ve kalem nesnemi oluşturdum
            Font myFont = new Font("Calibri", 28);
            SolidBrush sbrush = new SolidBrush(Color.Black);
            Pen myPen = new Pen(Color.Black);

            //Bu kısımda başlık yazısını ve çizgileri yazdırıyorum
            e.Graphics.DrawLine(myPen, 120, 120, 750, 120);
            e.Graphics.DrawLine(myPen, 120, 180, 750, 180);
            e.Graphics.DrawString(baslik, myFont, sbrush, 200, 120);

            //e.Graphics.DrawLine(myPen, 120, 220, 750, 220);

            myFont = new Font("Calibri", 12, FontStyle.Bold);
            int x = 120;
            foreach (ColumnHeader item in list.Columns)
            {
                Rectangle rect2 = new Rectangle(x, 228, item.Width, 20);
                e.Graphics.DrawString(item.Text, myFont, sbrush, rect2);
                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rect2));
                //e.Graphics.DrawString(item.Text, myFont, sbrush, x, 228);
                x += item.Width;
            }
            //e.Graphics.DrawLine(myPen, 120, 248, 750, 248);

            int y = 248;

           
            foreach (ListViewItem lvi in list.Items)
            {
                int i = 0;
                x = 120;
                foreach (ColumnHeader item in list.Columns)
                {
                    Rectangle rect2 = new Rectangle(x, y, item.Width, 20);
                    e.Graphics.DrawString(lvi.SubItems[i].Text, myFont, sbrush, rect2);
                    e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rect2));
                    x += item.Width;
                    i++;
                }
                y += 20;

            }

            //e.Graphics.DrawLine(myPen, 120, y, 750, y);
        }
        public void OnPrintDocument_2(object sender, PrintPageEventArgs e)
        {
            //frmUye için yazdırma kısmı yapılacak burada. Daha hiç başlanmadı sadece başlık atıldı
            //Yazı fontumu ve çizgi çizmek için fırçamı ve kalem nesnemi oluşturdum
            Font myFont = new Font("Calibri", 28);
            SolidBrush sbrush = new SolidBrush(Color.Black);
            Pen myPen = new Pen(Color.Black);

            //Bu kısımda başlık yazısını ve çizgileri yazdırıyorum
            e.Graphics.DrawLine(myPen, 120, 120, 750, 120);
            e.Graphics.DrawLine(myPen, 120, 180, 750, 180);
            e.Graphics.DrawString(baslik, myFont, sbrush, 200, 120);

            e.Graphics.DrawLine(myPen, 120, 220, 750, 220);

            myFont = new Font("Calibri", 12, FontStyle.Bold);
            int x = 120;
            foreach (ColumnHeader item in list.Columns)
            {
                /*
                Rectangle rect2 = new Rectangle(x, 228, item.Width, 20);
                e.Graphics.DrawString(item.Text, myFont, sbrush, rect2);
                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rect2));
                //e.Graphics.DrawString(item.Text, myFont, sbrush, x, 228);
                x += item.Width;
                */
            }
            e.Graphics.DrawLine(myPen, 120, 248, 750, 248);

            int y = 260;
            

            foreach (ListViewItem lvi in list.Items)
            {
                int i = 0;
                x = 120;
                foreach (ColumnHeader item in list.Columns)
                {
                    Rectangle rect2 = new Rectangle(x, y, item.Width, 20);
                    e.Graphics.DrawString(lvi.SubItems[i].Text, myFont, sbrush, rect2);
                    e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rect2));
                    x += item.Width;
                    i++;
                }
                y += 20;

            }

            //e.Graphics.DrawLine(myPen, 120, y, 750, y);
        }
    }

}

