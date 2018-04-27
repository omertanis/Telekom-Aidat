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
    public partial class frmAidatToplu : MetroFramework.Forms.MetroForm
    {
        public frmAidatToplu()
        {

            InitializeComponent();
        }

        private void frmAidatToplu_Load(object sender, EventArgs e)
        {
            try
            {
                this.MaximumSize = this.Size;
                this.MinimumSize = this.Size;
                PRG.DoldurIl(ref cboxil);
                cboxMudurluk.SelectedIndex = -1;
                cboxBirim.SelectedIndex = -1;
                cboxMudurluk.Enabled = false;
                cboxBirim.Enabled = false;
                cboxBirim.PromptText = " ";
                cboxMudurluk.PromptText = " ";
                btnKaydet.Enabled = false;



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
                if (cboxil.SelectedIndex != -1 && cboxBirim.SelectedIndex != -1 && cboxMudurluk.SelectedIndex != -1 && txtAidatMiktari.Text != string.Empty)
                {
                    int ilNo = ((KeyValuePair<int, string>)cboxil.SelectedItem).Key;
                    int mudurlukNo = ((KeyValuePair<int, string>)cboxMudurluk.SelectedItem).Key;
                    int birimNo = ((KeyValuePair<int, string>)cboxBirim.SelectedItem).Key;
                    Database db = new Database();
                    Database db2 = new Database();

                    var kisiler = db.DataOku("SELECT sicilNo FROM uyeler WHERE birimNo =@0", birimNo.ToString());
                    if (!kisiler.HasRows)
                    {
                        MessageBox.Show("Birimde kişi yok!");
                    }
                    else
                    {
                        while (kisiler.Read())
                        {
                            String sicilNo = kisiler["sicilNo"].ToString();
                            if (!string.IsNullOrEmpty(sicilNo))
                            {
                                db2.Sorgu("INSERT INTO AidatLog (sicilNo,miktar,tarih) Values (@0, @1,@2)", sicilNo, txtAidatMiktari.Text, this.dateTarih.Value.Date);
                                txtAidatMiktari.Text = string.Empty;
                                cboxil.SelectedIndex = -1;
                                cboxMudurluk.DataSource = null;
                                cboxBirim.DataSource = null;
                                dateTarih.Value = DateTime.Today;
                                lblKisiSayisi.Text = "Kişi Sayısı: ";
                                btnKaydet.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show("Birimde birisinin sicilnosuna ulaşılamadı.");
                            }
                        }
                        MessageBox.Show("Aidat Ödemesi yapıldı.");
                    }
                    db.Kapat();
                    db2.Kapat();
                }
                else
                    MessageBox.Show("Lütfen boş alanları doldururuz!");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cboxil_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cboxil.SelectedIndex != -1)
                {

                    int ilNo = ((KeyValuePair<int, string>)cboxil.SelectedItem).Key;
                    PRG.DoldurMudurluk(ref cboxMudurluk, ilNo.ToString());


                    cboxBirim.Enabled = false;
                    cboxBirim.PromptText = " ";
                    cboxBirim.SelectedIndex = -1;
                }
                else
                {
                    cboxMudurluk.Enabled = false;
                    cboxBirim.Enabled = false;
                    cboxBirim.PromptText = " ";
                    cboxMudurluk.PromptText = " ";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboxMudurluk_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                lblKisiSayisi.Text = "Kişi Sayısı: ";
                if (cboxMudurluk.SelectedIndex != -1)
                {
                    int mudurlukNo = ((KeyValuePair<int, string>)cboxMudurluk.SelectedItem).Key;
                    PRG.DoldurBirim(ref cboxBirim, mudurlukNo.ToString());

                    cboxBirim.Enabled = true;
                    cboxBirim.PromptText = "Birim seçiniz.";
                    cboxBirim.SelectedIndex = -1;

                }
                else
                {
                    cboxBirim.Enabled = false;
                    cboxBirim.PromptText = " ";

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboxil_SelectedIndexChanged(object sender, EventArgs e)
        {

            lblKisiSayisi.Text = "Kişi Sayısı: ";
            cboxMudurluk.PromptText = "Müdürlük seçiniz.";
        }

        private void cboxBirim_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                lblKisiSayisi.Text = "Kişi Sayısı: ";
                Database db = new Database();
                string countkisi = "0";
                if (cboxBirim.SelectedIndex != -1 && cboxBirim.Text != "Veri Yok")
                {
                    btnKaydet.Enabled = true;
                    lblKisiSayisi.Text = "";


                    int birimNo = PRG.cboxKeyGetir(ref cboxBirim);
                    var data = db.DataOku("select count (sicilNo) 'count' from Uyeler u join Birim b on u.birimNo=b.birimNo where b.birimNo=@0", birimNo);
                    if (data.Read())
                    {
                        countkisi = data["count"].ToString();
                    }
                    db.Kapat();
                    lblKisiSayisi.Text = "Kişi Sayısı: " + countkisi;
                    
                    Database db2 = new Database();
                    txtAidatMiktari.Text = db2.DataOkuTek("SELECT * FROM aidatmiktar WHERE birimno =@0 ", "aidat", birimNo);
                    db2.Kapat();
                }
                db.Kapat();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtAidatMiktari_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAidatMiktari_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }
    }
}
