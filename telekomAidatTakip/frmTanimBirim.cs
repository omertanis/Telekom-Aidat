using MetroFramework;
using MetroFramework.Drawing;
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
    public partial class frmTanimBirim : MetroFramework.Forms.MetroForm
    {
        public frmTanimBirim()
        {
            InitializeComponent();
        }

        private void frmTanimBirim_Load(object sender, EventArgs e)
        {
            try
            {
                this.MinimumSize = this.Size;
                //listBirim.Font = new MetroFramework.Fonts.FontResolver;
                frmTanimBirim_Resize(this, null);
                listeDoldur();
                Dictionary<int, string> cboxSource = new Dictionary<int, string>();
                Database db = new Database();
                var data = db.DataOku("SELECT mudurlukNo,mudurlukAdi FROM mudurluk");

                while (data.Read())
                {
                    cboxSource.Add(Convert.ToInt32(data["mudurlukNo"]), data["mudurlukAdi"].ToString());
                }
                cBoxMudurluk.DataSource = new BindingSource(cboxSource, null);
                cBoxMudurluk.DisplayMember = "Value";
                cBoxMudurluk.ValueMember = "Key";
                db.Kapat();
                cBoxMudurluk.SelectedIndex = -1;
                txtBirimAdi.WaterMark = "Yeni kayıt açınız.";
                txtBirimKodu.WaterMark = "Yeni kayıt açınız.";
                cBoxMudurluk.PromptText = "-";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.BeginInvoke(new MethodInvoker(Close));
            }
        }

        bool yeniKayit = true;
        private void btnYeni_Click(object sender, EventArgs e)
        {
            try
            {
                if (yeniKayit)
                {
                    if (btnKaydet.Enabled) // yeni butonuna basıldığı sırada bir kayıt düzenleniyor ise bunu tespit edip, kayıt için soruyor
                    {
                        DialogResult dialogResult = MessageBox.Show("Değişiklikleri kaydetmek istiyor musunuz?", "", MessageBoxButtons.YesNoCancel);
                        if (dialogResult == DialogResult.Yes)
                            btnKaydet_Click(this, null);
                        else if (dialogResult == DialogResult.Cancel)
                            return;
                    }
                    yeniKayit = false;
                    //btnYeni.Image = telekomAidatTakip.Properties.Resources.if_check_101940;
                    txtBirimAdi.Enabled = true;
                    txtBirimKodu.Enabled = true;
                    cBoxMudurluk.Enabled = true;
                    txtBirimAdi.WaterMark = "Birim adı giriniz.";
                    txtBirimKodu.WaterMark = "Birim no giriniz.";
                    cBoxMudurluk.PromptText = "-";
                    txtBirimAdi.Clear();
                    txtBirimKodu.Clear();
                    cBoxMudurluk.SelectedIndex = -1;
                    toolTip1.SetToolTip(btnYeni, "Ekle");
                }

                else
                    if (txtBirimAdi.Text != string.Empty && txtBirimKodu.Text != string.Empty)
                {
                    int mudurlukNo = ((KeyValuePair<int, string>)cBoxMudurluk.SelectedItem).Key;
                    Database db = new Database();
                    db.Sorgu("INSERT INTO Birim Values (@0,@1,@2)", txtBirimKodu.Text, txtBirimAdi.Text, mudurlukNo.ToString());
                    listBirim.Items.Clear();
                    listeDoldur();
                    db.Kapat();
                    //btnYeni.Image = telekomAidatTakip.Properties.Resources.if_save_101946;

                    txtBirimKodu.Enabled = false;
                    txtBirimAdi.Enabled = false;
                    cBoxMudurluk.Enabled = false;
                    txtBirimAdi.Clear();
                    txtBirimKodu.Clear();
                    cBoxMudurluk.SelectedIndex = -1;
                    txtBirimAdi.WaterMark = "Yeni kayıt açınız.";
                    txtBirimKodu.WaterMark = "Yeni kayıt açınız.";
                    cBoxMudurluk.PromptText = "-";
                    yeniKayit = true;
                    toolTip1.SetToolTip(btnYeni, "Yeni Kayıt");
                }
                else
                {
                    MessageBox.Show("Birim adı veya Birim Kodu eksik.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void listeDoldur()
        {
            listBirim.Items.Clear();
            Database db = new Database();
            var data = db.DataOku("SELECT b.birimAdi,b.birimNo,b.mudurlukNo,m.mudurlukAdi " +
                 "FROM Mudurluk m, Birim b WHERE m.mudurlukNo = b.mudurlukNo");
            listBirim.BeginUpdate();
            while (data.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = data["birimNo"].ToString();
                item.SubItems.Add(data["birimAdi"].ToString());
                item.SubItems.Add(data["mudurlukNo"].ToString());
                item.SubItems.Add(data["mudurlukAdi"].ToString());

                listBirim.Items.Add(item);
            }
            db.Kapat();
            listBirim.EndUpdate();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (birimNo != string.Empty)
                {
                    Database db2 = new Database();
                    string countKisi = "0";
                    var data2 = db2.DataOku("SELECT COUNT (sicilNo) 'count' FROM Uyeler WHERE birimNo = @0", birimNo);
                    if (data2.Read())
                    {
                        countKisi = data2["count"].ToString();
                    }
                    db2.Kapat();

                    Database db3 = new Database();
                    string countAidat = "0";
                    var data3 = db3.DataOku("SELECT COUNT (aidatLogNo) 'count' FROM Uyeler u JOIN AidatLog a on u.sicilNo=a.sicilNo WHERE u.birimNo = @0", birimNo);
                    if (data3.Read())
                    {
                        countAidat = data3["count"].ToString();
                    }
                    db3.Kapat();
                    // 0dan büyüklerse bu soruyu sormak lazım.
                    DialogResult dialogResult;
                    if (countAidat != "0" && countKisi != "0")
                        dialogResult = MessageBox.Show("Bu işlem ile sadece birimi değil, ona kayıtlı olan kişileri ve aidat kayıtlarınıda sileceksiniz. \nSilinecek kişi sayısı: " + countKisi + "\nSilinecek aidat kaydı: " + countAidat + " \nEmin misiniz?", "Birim Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    else
                        dialogResult = MessageBox.Show("Seçili birim silinecek. Emin misiniz?", "Birim Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        Database db = new Database();
                        db.Sorgu("DELETE FROM Birim Where birimNo = @0", birimNo);
                        listBirim.Items.Clear();
                        listeDoldur();
                        db.Kapat();
                        MessageBox.Show("Seçili birim silindi!", "Birim Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtBirimAdi.Text = string.Empty;
                        txtBirimKodu.Text = string.Empty;
                        cBoxMudurluk.SelectedIndex = -1;
                        birimNo = string.Empty;
                        txtBirimKodu.Enabled = false;
                        txtBirimAdi.Enabled = false;
                        cBoxMudurluk.Enabled = false;
                        txtBirimAdi.WaterMark = "Yeni kayıt açınız.";
                        txtBirimKodu.WaterMark = "Yeni kayıt açınız.";
                        cBoxMudurluk.PromptText = "-";

                    }
                }
                else
                    MessageBox.Show("Birim no kısmı boş");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        string birimNo;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBirimKodu.Text != string.Empty && txtBirimAdi.Text != string.Empty) // yine boş verilerle bir yeri update edemeyiz
                {
                    Database db = new Database();
                    int mudurlukNo = ((KeyValuePair<int, string>)cBoxMudurluk.SelectedItem).Key;
                    db.Sorgu("UPDATE Birim Set birimAdi = @0, mudurlukNo=@1,birimNo=@2 WHERE birimNo=@3", txtBirimAdi.Text, mudurlukNo.ToString(), txtBirimKodu.Text, birimNo);
                    listBirim.Items.Clear();
                    listeDoldur();
                    db.Kapat();

                    btnKaydet.Enabled = false;
                    //btnKaydet.UseCustomBackColor = true;
                    btnSil.Enabled = false;
                    //btnSil.UseCustomBackColor = true;
                    txtBirimAdi.Text = string.Empty;
                    txtBirimKodu.Text = string.Empty;
                    birimNo = string.Empty;

                    txtBirimKodu.Enabled = false;
                    txtBirimAdi.Enabled = false;
                    cBoxMudurluk.Enabled = false;
                    txtBirimAdi.WaterMark = "Yeni kayıt açınız.";
                    txtBirimKodu.WaterMark = "Yeni kayıt açınız.";
                    cBoxMudurluk.PromptText = "-";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmTanimBirim_Resize(object sender, EventArgs e)
        {
            try
            {
                 listBirim.Size = new Size(listBirim.Size.Width, this.Size.Height - 250);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void listvil_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (listBirim.SelectedItems.Count > 0)
                {

                    Database db = new Database();
                    string mudurlukAdi = listBirim.SelectedItems[0].SubItems[3].Text;
                    birimNo = listBirim.SelectedItems[0].SubItems[0].Text;
                    var data = db.DataOku("SELECT b.birimAdi,b.birimNo,m.mudurlukAdi " +
                          "FROM Mudurluk m, Birim b WHERE m.mudurlukNo = b.mudurlukNo AND m.mudurlukAdi = @0 AND b.birimNo =@1", mudurlukAdi, birimNo);

                    if (data.Read())
                    {

                        txtBirimAdi.Text = data["birimAdi"].ToString();
                        txtBirimKodu.Text = data["birimNo"].ToString();
                        cBoxMudurluk.Text = data["mudurlukAdi"].ToString();
                    }
                    db.Kapat();

                    btnKaydet.Enabled = true;
                    btnSil.Enabled = true;
                    //btnKaydet.UseCustomBackColor = false;
                    //btnSil.UseCustomBackColor = false;
                    txtBirimAdi.Enabled = true;
                    cBoxMudurluk.Enabled = true;
                    txtBirimKodu.Enabled = true;
                    txtBirimAdi.WaterMark = "Birim adı giriniz.";
                    txtBirimKodu.WaterMark = "Birim kodu giriniz.";
                    cBoxMudurluk.PromptText = "-";
                    yeniKayit = true;
                    toolTip1.SetToolTip(btnYeni, "Yeni Kayıt");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBirimKodu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }
    }


}