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
    public partial class frmTanimUnvan : MetroFramework.Forms.MetroForm
    {
        public frmTanimUnvan()
        {
            InitializeComponent();
        }
        string unvanKodu;
        private void frmTanimUnvan_Load(object sender, EventArgs e)
        {
            try
            {
                this.MinimumSize = this.Size;
                UnvanListesiniDoldur();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.BeginInvoke(new MethodInvoker(Close));
            }
        }
        private void UnvanListesiniDoldur()
        {
            Database db = new Database();

            var data = db.DataOku("select * from unvan");


            listUnvan.Items.Clear();

            while (data.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = data["unvanNo"].ToString();
                item.SubItems.Add(data["unvanAdi"].ToString());

                listUnvan.Items.Add(item);

            }
            db.Kapat();
            txtUnvanAdi.WaterMark = "Yeni kayıt açınız.";
            txtUnvanNo.WaterMark = "Yeni kayıt açınız.";
            txtUnvanAdi.Enabled = false;
            txtUnvanNo.Enabled = false;
            btnSil.Enabled = false;
            btnKaydet.Enabled = false;
            btnYeni.Enabled = true;

        }
        bool yeniKayit = true;
        private void btnYeni_Click(object sender, EventArgs e)
        {
            try
            {
                if (yeniKayit)
                {
                    if (btnKaydet.Enabled)
                    {
                        DialogResult dialogResult = MessageBox.Show("Değişiklikleri kaydetmek istiyor musunuz?", "", MessageBoxButtons.YesNoCancel);
                        if (dialogResult == DialogResult.Yes)
                            btnKaydet_Click(this, null);
                        else if (dialogResult == DialogResult.Cancel)
                            return;
                    }

                    txtUnvanAdi.Text = string.Empty;
                    txtUnvanNo.Text = string.Empty;
                    txtUnvanNo.Enabled = true;
                    txtUnvanAdi.Enabled = true;
                    txtUnvanAdi.WaterMark = "Ünvan adı giriniz.";
                    txtUnvanNo.WaterMark = "Ünvan no giriniz.";
                    //btnYeni.Text = "Ekle";
                    yeniKayit = false;
                    btnKaydet.Enabled = false;
                    btnSil.Enabled = false;
                    toolTip1.SetToolTip(btnYeni, "Ekle");
                }
                else
                {
                    if (txtUnvanNo.Text != string.Empty && txtUnvanAdi.Text != string.Empty)
                    {
                        Database db = new Database();
                        db.Sorgu("insert into unvan (unvanNo,unvanAdi) values (@0,@1)", txtUnvanNo.Text, txtUnvanAdi.Text);
                        db.Kapat();

                        txtUnvanNo.Enabled = false;
                        txtUnvanAdi.Enabled = false;
                        //btnYeni.Text = "Yeni";
                        yeniKayit = true;
                        UnvanListesiniDoldur();

                        txtUnvanAdi.Text = string.Empty;
                        txtUnvanNo.Text = string.Empty;
                        txtUnvanAdi.WaterMark = "Yeni kayıt açınız.";
                        txtUnvanNo.WaterMark = "Yeni kayıt açınız.";
                        btnYeni.Focus();
                        toolTip1.SetToolTip(btnYeni, "Yeni Kayıt");
                    }
                    else
                    {
                        MessageBox.Show("Ünvan kodu veya ünvan adı kısmı boş!");
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUnvanNo.Text != string.Empty && txtUnvanAdi.Text != string.Empty)
                {
                    Database db = new Database();
                    db.Sorgu("update unvan set unvanAdi=@0,unvanNo=@1 where unvanNo=@2", txtUnvanAdi.Text, txtUnvanNo.Text,unvanKodu);
                    db.Kapat();

                    txtUnvanAdi.Text = string.Empty;
                    txtUnvanNo.Text = string.Empty;
                    unvanKodu = string.Empty;
                    txtUnvanAdi.WaterMark = "Yeni kayıt açınız.";
                    txtUnvanNo.WaterMark = "Yeni kayıt açınız.";
                    txtUnvanAdi.Enabled = false;
                    txtUnvanNo.Enabled = false;
                    btnKaydet.Enabled = false;
                    btnSil.Enabled = false;
                    UnvanListesiniDoldur();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnSil.Enabled)
                {
                    Database db2 = new Database();
                    string countKisi = "0";
                    var data2 = db2.DataOku("SELECT COUNT (sicilNo) 'count' FROM Uyeler WHERE unvanno = @0", unvanKodu);
                    if (data2.Read())
                    {
                        countKisi = data2["count"].ToString();
                    }
                    db2.Kapat();

                    Database db3 = new Database();
                    string countAidat = "0";
                    var data3 = db3.DataOku("SELECT COUNT (aidatLogNo) 'count' FROM Uyeler u JOIN AidatLog a on u.sicilNo=a.sicilNo WHERE u.unvanno = @0", unvanKodu);
                    if (data3.Read())
                    {
                        countAidat = data3["count"].ToString();
                    }
                    db3.Kapat();
                    // 0dan büyüklerse bu soruyu sormak lazım.
                    DialogResult dialogResult;
                    if (countAidat != "0" && countKisi != "0")
                        dialogResult = MessageBox.Show("Bu işlem ile sadece seçtiğiniz ünvanı değil, ona kayıtlı olan kişileri ve aidat kayıtlarınıda sileceksiniz. \nSilinecek kişi sayısı: " + countKisi + "\nSilinecek aidat kaydı: " + countAidat + " \nEmin misiniz?", "Birim Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    else
                        dialogResult = MessageBox.Show("Seçili ünvan silinecek. Emin misiniz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        if (unvanKodu != string.Empty)
                        {
                            Database db = new Database();
                            db.Sorgu("delete from unvan where unvanNo=@0", unvanKodu);
                            db.Kapat();
                            txtUnvanAdi.Text = string.Empty;
                            txtUnvanNo.Text = string.Empty;
                            unvanKodu = string.Empty;
                            txtUnvanAdi.WaterMark = "Yeni kayıt açınız.";
                            txtUnvanNo.WaterMark = "Yeni kayıt açınız.";
                            txtUnvanAdi.Enabled = false;
                            txtUnvanNo.Enabled = false;
                            btnKaydet.Enabled = false;
                            btnSil.Enabled = false;
                            UnvanListesiniDoldur();
                        }


                    }

                    else if (dialogResult == DialogResult.No)
                        return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmTanimUnvan_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (btnYeni.Text == "Ekle" || btnKaydet.Enabled)
                {
                    DialogResult dialogResult = MessageBox.Show("Değişiklikleri kaydetmek istiyor musunuz?", "", MessageBoxButtons.YesNoCancel);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (yeniKayit)
                            btnYeni_Click(this, null);
                        else
                            btnKaydet_Click(this, null);
                    }
                    else if (dialogResult == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (listUnvan.SelectedItems.Count > 0)
                {
                    unvanKodu = listUnvan.SelectedItems[0].Text;

                    Database db = new Database();

                    txtUnvanAdi.Text = db.DataOkuTek("select unvanAdi from unvan where unvanNo=@0", "unvanAdi", unvanKodu);
                    db.Kapat();

                    txtUnvanNo.Text = unvanKodu;
                    btnKaydet.Enabled = true;
                    btnSil.Enabled = true;
                    txtUnvanAdi.Enabled = true;
                    txtUnvanNo.Enabled = true;
                    txtUnvanAdi.WaterMark = "Ünvan adı giriniz.";
                    txtUnvanNo.WaterMark = "Ünvan no giriniz.";
                    // btnYeni.Text = "Yeni";
                    yeniKayit = true;
                    toolTip1.SetToolTip(btnYeni, "Yeni Kayıt");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmTanimUnvan_Resize(object sender, EventArgs e)
        {
            listUnvan.Size = new Size(listUnvan.Size.Width, this.Size.Height - 213);
        }

        private void txtUnvanNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }





        /*private void frmTanimUnvan_Resize(object sender, EventArgs e)
        {
            groupBox2.Width = this.Width - 59;
            groupBox2.Height = this.Height - 256;
        }*/

    }
}
    