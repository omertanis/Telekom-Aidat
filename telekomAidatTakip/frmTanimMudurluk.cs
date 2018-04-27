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
    public partial class frmTanimMudurluk : MetroFramework.Forms.MetroForm
    {
        public frmTanimMudurluk()
        {
            InitializeComponent();
        }

        private void frmTanimMudurluk_Load(object sender, EventArgs e)
        {
            try
            {
                this.MinimumSize = this.Size;

                kayitliMdrDoldur();
                cBoxIlDoldur();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.BeginInvoke(new MethodInvoker(Close));
            }
        }

        private void kayitliMdrDoldur()
        {
            Database db = new Database();
            //data objesi sqlreadera dönüşüp veriyi alır. 
            //direk sqldatareaderda yazılabilir fakat bu sefer forum içerisinde using bilmemne yazmamız gerekir
            //var kelimesi ile tanımlanan değişkene ilk olarak ne eşitlersek o değişken tipinde olur
            var data = db.DataOku("SELECT i.ilAdi, i.ilNo, m.mudurlukNo, m.mudurlukAdi " +
                 "FROM Mudurluk m, il i WHERE i.ilNo = m.ilNo");

            //listview içeriğini boşaltmamız gerekiyor il önce
            listvMdr.Items.Clear();

            while (data.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = data["mudurlukNo"].ToString();
                item.SubItems.Add(data["mudurlukAdi"].ToString());
                item.SubItems.Add(data["ilNo"].ToString());
                item.SubItems.Add(data["ilAdi"].ToString());


                listvMdr.Items.Add(item);
                //oluşturulan item liste eklenir
            }
            db.Kapat();

            txtMdrKod.Enabled = false;
            txtMdrAd.Enabled = false;
            txtMdrAd.WaterMark = "Yeni kayıt açınız.";
            txtMdrKod.WaterMark = "Yeni kayıt açınız.";
            comboBox_il.PromptText = "-";
            comboBox_il.Enabled = false;
            btnSil.Enabled = false;
            btnKaydet.Enabled = false;
            btnYeni.Enabled = true;

        }
        private void cBoxIlDoldur()
        {
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            Database db2 = new Database();
            var data = db2.DataOku("SELECT ilNo,ilAdi FROM il");

            while (data.Read())
            {
                cboxSource.Add(Convert.ToInt32(data["ilNo"]), data["ilAdi"].ToString());
            }
            db2.Kapat();

            comboBox_il.DataSource = new BindingSource(cboxSource, null);
            comboBox_il.DisplayMember = "Value";
            comboBox_il.ValueMember = "Key";
            comboBox_il.SelectedIndex = -1;

        }
               
        bool yeniKayit = true;
        private void btnYeni_Click(object sender, EventArgs e)
        {
            try
            {
                // butonun ismine göre yeni kaydın veritabanına ekleneceğini mi yoksa ekleme sayfasına mı geçileceğini mi tespit ediyoruz

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
                    txtMdrKod.Text = string.Empty;
                    txtMdrAd.Text = string.Empty;
                    comboBox_il.SelectedIndex = -1;
                    txtMdrKod.Enabled = true;
                    txtMdrAd.Enabled = true;
                    txtMdrAd.WaterMark = "Müdürlük adı giriniz.";
                    txtMdrKod.WaterMark = "Müdürlük no giriniz.";
                    comboBox_il.PromptText = "İl seçiniz.";
                    comboBox_il.Enabled = true;
                    //btnYeni.Text =b "Ekle";
                    btnKaydet.Enabled = false;
                    btnSil.Enabled = false;
                    toolTip1.SetToolTip(btnYeni, "Ekle");
                }
                else //butonun ismi Yeni değilse demekki yeni kayıt sayfasındayız
                {

                    if (txtMdrKod.Text != string.Empty && txtMdrAd.Text != string.Empty) //yeni kayıt eklemek için bu iki verinin boş olmaması gerekiyor
                    {
                        Database db = new Database();
                        int ilNo = ((KeyValuePair<int, string>)comboBox_il.SelectedItem).Key;
                        db.Sorgu("insert into Mudurluk values (@0,@1,@2)", txtMdrKod.Text, txtMdrAd.Text, ilNo.ToString());
                        db.Kapat();

                        txtMdrKod.Enabled = false;
                        txtMdrAd.Enabled = false;
                        //btnYeni.Text = "Yeni";
                        kayitliMdrDoldur();
                        txtMdrAd.Text = string.Empty;
                        txtMdrKod.Text = string.Empty;
                        comboBox_il.SelectedIndex = -1;
                        yeniKayit = true;
                        toolTip1.SetToolTip(btnYeni, "Yeni Kayıt");
                        btnYeni.Focus(); //görsel amaçlı
                    }
                    else
                    {
                        MessageBox.Show("Müdürlük kodu veya müdürlük adı kısmı boş!");
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
                if (txtMdrKod.Text != string.Empty && txtMdrAd.Text != string.Empty) // yine boş verilerle bir yeri update edemeyiz
                {
                    Database db = new Database();
                    int ilNo = PRG.cboxKeyGetir(ref comboBox_il);
                    db.Sorgu("update Mudurluk set mudurlukAdi=@0, ilNo=@1,mudurlukNo=@2 where mudurlukNo=@3", txtMdrAd.Text, ilNo.ToString(), txtMdrKod.Text, mudurlukno);

                    db.Kapat();
                    txtMdrAd.Text = string.Empty;
                    txtMdrKod.Text = string.Empty;
                    mudurlukno = string.Empty;
                    txtMdrAd.Enabled = false;
                    txtMdrKod.Enabled = false;
                    btnKaydet.Enabled = false;
                    btnSil.Enabled = false;
                    listvMdr.Items.Clear();
                    comboBox_il.SelectedIndex = -1;
                    kayitliMdrDoldur();
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
                Database db1 = new Database();
                string countBirim = "0";
                var data = db1.DataOku("SELECT COUNT (birimNo) 'count' FROM birim WHERE mudurlukNo = @0", mudurlukno);
                if (data.Read())
                {
                    countBirim = data["count"].ToString();
                }
                db1.Kapat();
                Database db2 = new Database();
                string countKisi = "0";
                var data2 = db2.DataOku("SELECT COUNT (sicilNo) 'count' FROM Uyeler WHERE mudurlukNo = @0", mudurlukno);
                if (data2.Read())
                {
                    countKisi = data2["count"].ToString();
                }
                db2.Kapat();

                Database db3 = new Database();
                string countAidat = "0";
                var data3 = db3.DataOku("SELECT COUNT (aidatLogNo) 'count' FROM Uyeler u JOIN AidatLog a on u.sicilNo=a.sicilNo WHERE u.mudurlukNo = @0", mudurlukno);
                if (data3.Read())
                {
                    countAidat = data3["count"].ToString();
                }
                db3.Kapat();
                DialogResult dialogResult;
                if (countAidat != "0" && countBirim != "0" && countKisi != "0")
                    dialogResult = MessageBox.Show("Seçili müdürlük ve altında kayıtlı birimler silinecek.\nSilinecek birim sayısı: " + countBirim + "\nSilinecek kişi sayısı: " + countKisi + "\nSilinecek aidat kaydı: " + countAidat + " \nEmin misiniz?", "Müdürlük Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                else
                    dialogResult = MessageBox.Show("Seçili müdürlük ve altında kayıtlı birimler silinecek. Emin misiniz?", "Müdürlük Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    if (mudurlukno != string.Empty)
                    {
                        Database db = new Database();

                        db.Sorgu("DELETE FROM Mudurluk Where mudurlukNo = @0", mudurlukno);
                        db.Kapat();

                        listvMdr.Items.Clear();
                        txtMdrAd.Text = string.Empty;
                        txtMdrKod.Text = string.Empty;
                        mudurlukno = string.Empty;
                        kayitliMdrDoldur();
                        comboBox_il.SelectedIndex = -1;
                        MessageBox.Show("Müdürlük silindi!", "Müdürlük Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                else if (dialogResult == DialogResult.Cancel)
                    return;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        string mudurlukno;
        private void listvMdr_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (listvMdr.SelectedItems.Count> 0)
                {

                    Database db = new Database();
                    mudurlukno = listvMdr.SelectedItems[0].SubItems[0].Text;
                    string ilKodu = listvMdr.SelectedItems[0].SubItems[2].Text;
                    var data = db.DataOku("SELECT i.ilAdi,m.mudurlukNo,m.mudurlukAdi " +
                          "FROM Mudurluk m, il i WHERE m.ilNo = i.ilNo AND m.mudurlukno = @0 AND i.ilNo =@1", mudurlukno, ilKodu);

                    if (data.Read())
                    {

                        txtMdrKod.Text = data["mudurlukNo"].ToString();
                        txtMdrAd.Text = data["mudurlukAdi"].ToString();
                        comboBox_il.Text = data["ilAdi"].ToString();

                    }
                    db.Kapat();

                    // txtMdrKod.Text = mdrKod;
                    btnKaydet.Enabled = true;
                    btnSil.Enabled = true;
                    txtMdrAd.Enabled = true;
                    txtMdrKod.Enabled = false;
                    comboBox_il.Enabled = true;
                    //btnYeni.Text = "Yeni";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmTanimMudurluk_Resize(object sender, EventArgs e)
        {
            try
            { 
                listvMdr.Size = new Size(listvMdr.Size.Width, this.Size.Height - 264);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void txtMdrKod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }

    }
}
