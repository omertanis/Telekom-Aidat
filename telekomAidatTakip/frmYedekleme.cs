using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace telekomAidatTakip
{
    public partial class frmYedekleme : MetroForm
    {
        public frmYedekleme()
        {
            InitializeComponent();
        }
        private void listele()
        {
            Database db = new Database();
            var data = db.DataOku("select * from msdb.dbo.backupmediafamily");

            //physical_device_name

            while (data.Read())
            {

                ListViewItem item = new ListViewItem();

                string veri = data["physical_device_name"].ToString();
                string[] split = veri.Split(new Char[] { '\\', '-', '.' });

                if (split.Length > 2)
                {
                    DateTime result = DateTime.ParseExact(split[2], "ddMMyyyy", System.Globalization.CultureInfo.InvariantCulture);


                    item.SubItems[0].Text = result.ToShortDateString();
                    item.SubItems.Add(split[1]);
                    item.Tag = data["physical_device_name"].ToString();


                    listYukle.Items.Add(item);
                }


            }
        }

    
        private void frmYedekleme_Load(object sender, EventArgs e)
        {
            try {

                this.MaximumSize = this.Size;
                this.MinimumSize = this.Size;
                listele();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.BeginInvoke(new MethodInvoker(Close));
            }
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            try { 
            if (listYukle.SelectedItems.Count > 0)
            {
                Database.Restore(listYukle.SelectedItems[0].Tag.ToString());
                MessageBox.Show("Geri Yükleme tamamlandı");
            }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        void Yedekle()
        {
            string ozelnot;


            if (txtYedek.Text == string.Empty)
            {
                ozelnot = "yok";
            }
            else
                ozelnot = txtYedek.Text;

            Database db = new Database();
            db.Sorgu("backup database telekomAidat to disk = @0", "telekomAidat-" + ozelnot + "-" + DateTime.Today.ToString("ddMMyyyy") +".bak");
            txtYedek.Text = String.Empty;
            MessageBox.Show("Yedekleme tamamlandı.");

            db.Kapat();
        }

        private void btnYedek_Click(object sender, EventArgs e)
        {
            try { 
            Yedekle();
            listele();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listYukle_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

    
    }
}
