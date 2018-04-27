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
    public partial class frmAidatMiktar : MetroFramework.Forms.MetroForm
    {




        public frmAidatMiktar()
        {
            InitializeComponent();
        }

        private void frmAidatMiktar_Load(object sender, EventArgs e)
        {
            try
            {
                this.MaximumSize = this.Size;
                this.MinimumSize = this.Size;
                cboxIl.SelectedIndex = -1;

                PRG.DoldurIl(ref cboxIl);

                cboxBirim.Enabled = false;
                cboxMudurluk.Enabled = false;
                btnGuncelle.Visible = false;
                btnKaydet.Visible = true;
                frmAidatMiktar_Resize(this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.BeginInvoke(new MethodInvoker(Close));
            }
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboxIl.SelectedIndex != -1 && cboxBirim.SelectedIndex != -1 && cboxMudurluk.SelectedIndex != -1 && txtAidatMiktari.Text != string.Empty)
                {

                    Database db = new Database();
                    int mdr = ((KeyValuePair<int, string>)cboxMudurluk.SelectedItem).Key;
                    int ilno = ((KeyValuePair<int, string>)cboxIl.SelectedItem).Key;
                    int birimno = ((KeyValuePair<int, string>)cboxBirim.SelectedItem).Key;
                    db.Sorgu("INSERT INTO AidatMiktar values (@0,@1)", birimno.ToString(), txtAidatMiktari.Text);
                    cboxIl.SelectedIndex = -1;
                    cboxMudurluk.SelectedIndex = -1;
                    cboxBirim.SelectedIndex = -1;
                    txtAidatMiktari.Text = string.Empty;
                    db.Kapat();
                }
                else
                    MessageBox.Show("Lütfen boş alanları doldururuz!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            cboxIl.SelectedIndex = -1;
            cboxMudurluk.SelectedIndex = -1;
            cboxBirim.SelectedIndex = -1;
            txtAidatMiktari.Text = string.Empty;
            btnKaydet.Visible = true;
            btnGuncelle.Visible = false;
            cboxBirim.DataSource = null;
            cboxMudurluk.DataSource = null;
        }

        private void frmAidatMiktar_Resize(object sender, EventArgs e)
        {
            //pictureBox1.Location = new Point(this.Width - 70, pictureBox1.Location.Y);
        }

        private void cboxMudurluk_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                int mdr = PRG.cboxKeyGetir(ref cboxMudurluk);
                if (mdr != -1)
                {

                    PRG.DoldurBirim(ref cboxBirim, mdr.ToString());
                    cboxBirim.Enabled = true;
                }
                else
                    cboxBirim.DataSource = null;
                cboxBirim.SelectedIndex = -1;
                txtAidatMiktari.Text = string.Empty;
                txtAidatMiktari.Enabled = false;
                btnKaydet.Enabled = false;
                btnGuncelle.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboxIl_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                int ilno = PRG.cboxKeyGetir(ref cboxIl);
                if (ilno != -1)
                {
                    PRG.DoldurMudurluk(ref cboxMudurluk, ilno.ToString());
                    cboxMudurluk.Enabled = true;

                }
                cboxBirim.Enabled = false;
                cboxMudurluk.SelectedIndex = -1;
                cboxBirim.SelectedIndex = -1;
                txtAidatMiktari.Text = string.Empty;
                txtAidatMiktari.Enabled = false;
                btnKaydet.Enabled = false;
                btnGuncelle.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboxBirim_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                int birimno = PRG.cboxKeyGetir(ref cboxBirim);
                if (birimno != -1 && cboxIl.SelectedIndex != -1 && cboxMudurluk.SelectedIndex != -1)
                {
                    txtAidatMiktari.Enabled = true;
                    Database db = new Database();

                    var data = db.DataOku("SELECT * FROM aidatmiktar WHERE birimno=@0 ", birimno);
                    while (data.Read())
                    {
                        txtAidatMiktari.Text = data["aidat"].ToString();
                    }

                    db.Kapat();
                    if (txtAidatMiktari.Text == string.Empty)
                    {
                        btnGuncelle.Visible = false;
                        btnKaydet.Enabled = true;
                        btnKaydet.Visible = true;
                    }
                    else
                    {
                        btnKaydet.Visible = false;
                        btnGuncelle.Visible = true;
                        btnGuncelle.Enabled = true;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (cboxIl.SelectedIndex != -1 && cboxBirim.SelectedIndex != -1 && cboxMudurluk.SelectedIndex != -1 && txtAidatMiktari.Text != string.Empty)
            {
                Database db = new Database();
                int mdr = ((KeyValuePair<int, string>)cboxMudurluk.SelectedItem).Key;
                int ilno = ((KeyValuePair<int, string>)cboxIl.SelectedItem).Key;
                int birimno = ((KeyValuePair<int, string>)cboxBirim.SelectedItem).Key;
                db.Sorgu("update AidatMiktar set aidat=@0 where  birimNo=@1", txtAidatMiktari.Text, birimno.ToString());
                MessageBox.Show("Aidat bilgisi güncellendi!");
                cboxIl.SelectedIndex = -1;
                cboxMudurluk.SelectedIndex = -1;
                cboxBirim.SelectedIndex = -1;
                txtAidatMiktari.Text = string.Empty;
                txtAidatMiktari.Enabled = false;
                btnKaydet.Enabled = false;
                btnGuncelle.Enabled = false;
                db.Kapat();
            }
            else
                MessageBox.Show("Lütfen boş alanları doldururuz!");
        }

        private void txtAidatMiktari_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }
    }
}

    

