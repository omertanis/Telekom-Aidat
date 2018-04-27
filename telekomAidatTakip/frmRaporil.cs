using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telekomAidatTakip
{
    public partial class frmRaporIl : MetroFramework.Forms.MetroForm
    {
        public frmRaporIl()
        {
            InitializeComponent();
        }

        private void btnEkranaListele_Click(object sender, EventArgs e)
        {
            try
            {



                Database db = new Database();
                string query = "SELECT distinct i.ilAdi, i.ilNo, coalesce((Select Count(*) from Uyeler u2 where aktif = 'true' AND u.ilNo = u2.ilNo group by ilno),0) 'aktif', coalesce((Select Count(*) from Uyeler u2 where aktif = 'false' AND u.ilNo = u2.ilNo group by ilno) ,0) 'pasif', coalesce((Select Count(*) from Uyeler u2 where u.ilNo = u2.ilNo group by ilno),0) 'toplam' FROM Uyeler u , il i where u.ilno = i.ilno";
                var data = db.DataOku(query);
                listIl.Items.Clear();
                if (data.HasRows)
                {
                    yazdir.list = listIl;
                    yazdir.baslik = "İl Listesi";
                    btnYazdir.Enabled = true;
                }
                while (data.Read())
                {

                    ListViewItem item = new ListViewItem();
                    item.Text = data["ilno"].ToString();
                    item.SubItems.Add(data["ilAdi"].ToString());
                    item.SubItems.Add(data["aktif"].ToString());
                    item.SubItems.Add(data["pasif"].ToString());
                    item.SubItems.Add(data["toplam"].ToString());
                    listIl.Items.Add(item);
                }
                db.Kapat();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        Yazdir yazdir;

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            try
            {
                yazdir.printPre.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmRaporIl_Load(object sender, EventArgs e)
        {
            try
            {
                this.MinimumSize = this.Size;
                yazdir = new Yazdir(1);
                btnYazdir.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.BeginInvoke(new MethodInvoker(Close));
            }
        }

        private void listIl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listIl_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (listIl.SelectedItems.Count > 0)
                {
                    frmRaporUye frm = new frmRaporUye(listIl.SelectedItems[0].Text);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmRaporIl_Resize(object sender, EventArgs e)
        {
            listIl.Size = new Size(listIl.Size.Width, this.Size.Height - 137);
        }
    }
}
