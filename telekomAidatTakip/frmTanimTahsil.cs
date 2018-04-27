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
    public partial class frmTanimTahsil : MetroFramework.Forms.MetroForm
    {
        public frmTanimTahsil()
        {
            InitializeComponent();
        }

        private void frmTanimTahsil_Load(object sender, EventArgs e)
        {
            try
            {
                this.MinimumSize = this.Size;
                TahsilListesiDoldur();
                txtTahsilAd.WaterMark = "Yeni kayıt açınız.";
                txtTahsilKodu.WaterMark = "Yeni kayıt açınız.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.BeginInvoke(new MethodInvoker(Close));
            }
        }

        private void TahsilListesiDoldur()
        {
            Database db = new Database();
            //data objesi sqlreadera dönüşüp veriyi alır. 
            //direk sqldatareaderda yazılabilir fakat bu sefer forum içerisinde using bilmemne yazmamız gerekir
            //var kelimesi ile tanımlanan değişkene ilk olarak ne eşitlersek o değişken tipinde olur
            var data = db.DataOku("select * from Tahsil");

            //listview içeriğini boşaltmamız gerekiyor il önce
            listvTanimTahsil.Items.Clear();

            while (data.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = data["tahsilNo"].ToString();
                item.SubItems.Add(data["tahsilAdi"].ToString());

                listvTanimTahsil.Items.Add(item);
                //oluşturulan item liste eklenir
            }
            db.Kapat();

            txtTahsilAd.Enabled = false;
            txtTahsilKodu.Enabled = false;
            btnSil.Enabled = false;
            btnKaydet.Enabled = false;
            btnYeni.Enabled = true;

        }



        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTahsilKodu.Text != string.Empty && txtTahsilAd.Text != string.Empty) // yine boş verilerle bir yeri update edemeyiz
                {
                    Database db = new Database();
                    db.Sorgu("update Tahsil set tahsilAdi=@0,tahsilNo=@1 where tahsilNo=@2", txtTahsilAd.Text, txtTahsilKodu.Text, tahsilKodu);
                    db.Kapat();

                    txtTahsilAd.Text = string.Empty;
                    txtTahsilKodu.Text = string.Empty;
                    tahsilKodu = string.Empty;
                    txtTahsilAd.Enabled = false;
                    txtTahsilAd.Enabled = false;
                    btnKaydet.Enabled = false;
                    btnSil.Enabled = false;
                    TahsilListesiDoldur();
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
                if (tahsilKodu != string.Empty) //plaka kodu olmadan veri silmek tabiki biraz zor olur
                {
                    Database db2 = new Database();
                    string countKisi = "0";
                    var data2 = db2.DataOku("SELECT COUNT (sicilNo) 'count' FROM Uyeler WHERE tahsilNo = @0", tahsilKodu);
                    if (data2.Read())
                    {
                        countKisi = data2["count"].ToString();
                    }
                    db2.Kapat();

                    Database db3 = new Database();
                    string countAidat = "0";
                    var data3 = db3.DataOku("SELECT COUNT (aidatLogNo) 'count' FROM Uyeler u JOIN AidatLog a on u.sicilNo=a.sicilNo WHERE u.tahsilno = @0", tahsilKodu);
                    if (data3.Read())
                    {
                        countAidat = data3["count"].ToString();
                    }
                    db3.Kapat();
                    // 0dan büyüklerse bu soruyu sormak lazım.
                    DialogResult dialogResult;
                    if (countAidat != "0" && countKisi != "0")
                        dialogResult = MessageBox.Show("Bu işlem ile sadece seçtiğiniz tahsili değil, ona kayıtlı olan kişileri ve aidat kayıtlarınıda sileceksiniz. \nSilinecek kişi sayısı: " + countKisi + "\nSilinecek aidat kaydı: " + countAidat + " \nEmin misiniz?", "Birim Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    else
                        dialogResult = MessageBox.Show("Seçili tahsil silinecek. Emin misiniz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        Database db = new Database();
                        db.Sorgu("delete from Tahsil where tahsilNo=@0", tahsilKodu);
                        db.Kapat();
                        txtTahsilKodu.Clear();
                        txtTahsilAd.Clear();
                        txtTahsilAd.WaterMark = "Yeni kayıt açınız.";
                        txtTahsilKodu.WaterMark = "Yeni kayıt açınız.";
                        TahsilListesiDoldur();
                        txtTahsilAd.Text = string.Empty;
                        tahsilKodu = string.Empty;
                    }
                }
                else
                    MessageBox.Show("Tahsil no kısmı boş");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void frmTanimTahsil_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //burda form penceresi kapatılırken çalışacak kodlar bulunuyor
                if (btnYeni.Text == "Ekle" || btnKaydet.Enabled) //btnYeni nin ismi Ekle ise veya btnKaydet aktif ise bir düzenleme veya kayıt yapılıyor demektir.
                {
                    DialogResult dialogResult = MessageBox.Show("Değişiklikleri kaydetmek istiyor musunuz?", "", MessageBoxButtons.YesNoCancel);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (btnYeni.Text == "Ekle")
                            btnYeni_Click(this, null); //btnYeni_Click fonksiyonunu çağırdık
                        else
                            btnKaydet_Click(this, null); //btnYeni_Click fonksiyonunu çağırdık
                    }
                    else if (dialogResult == DialogResult.Cancel)
                    {
                        e.Cancel = true; //bu işlem ile formun kapanma işlemi iptal ediliyor
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        bool yeniKayit = true;
        private void btnYeni_Click(object sender, EventArgs e)
        {
            try
            {
                // butonun ismine göre yeni kaydın veritabanına ekleneceğini mi yoksa ekleme sayfasına mı geçileceğini mi tespit ediyoruz

                if (yeniKayit) // butonun ismi "Yeni" ise ekleme sayfası oluşturulmalı
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
                    txtTahsilKodu.Text = string.Empty;
                    txtTahsilAd.Text = string.Empty;
                    txtTahsilKodu.Enabled = true;
                    txtTahsilAd.Enabled = true;
                    toolTip.SetToolTip(btnYeni, "Ekle");
                    btnKaydet.Enabled = false;
                    btnSil.Enabled = false;
                    txtTahsilAd.WaterMark = "Tahsil adını giriniz.";
                    txtTahsilKodu.WaterMark = "Tahsil kodunu giriniz.";
                }
                else //butonun ismi Yeni değilse demekki yeni kayıt sayfasındayız
                {
                    if (txtTahsilAd.Text != string.Empty && txtTahsilKodu.Text != string.Empty) //yeni kayıt eklemek için bu iki verinin boş olmaması gerekiyor
                    {
                        Database db = new Database();
                        db.Sorgu("insert into Tahsil (tahsilAdi,tahsilNo) values (@0,@1)", txtTahsilAd.Text, txtTahsilKodu.Text);
                        db.Kapat();

                        txtTahsilAd.Enabled = false;
                        txtTahsilKodu.Enabled = false;
                        TahsilListesiDoldur();
                        txtTahsilAd.Text = string.Empty;
                        txtTahsilKodu.Text = string.Empty;
                        btnYeni.Focus(); //görsel amaçlı
                        yeniKayit = false;
                        toolTip.SetToolTip(btnYeni, "Yeni Kayıt");
                        txtTahsilAd.WaterMark = "Yeni kayıt açınız.";
                        txtTahsilKodu.WaterMark = "Yeni kayıt açınız.";
                    }
                    else
                    {
                        MessageBox.Show("Tahsil kodu veya adı kısmı boş!");
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmTanimTahsil_Resize(object sender, EventArgs e)
        {
            try
            {
                listvTanimTahsil.Size = new Size(listvTanimTahsil.Size.Width, this.Size.Height - 209);
                // pictureBox1.Location = new Point(this.Width - 70, pictureBox1.Location.Y);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        string tahsilKodu;
        private void listvTanimTahsil_DoubleClick_1(object sender, EventArgs e)
        {
            try
            {
                if (listvTanimTahsil.SelectedItems.Count > 0)
                {
                    tahsilKodu = listvTanimTahsil.SelectedItems[0].Text; //listvilde seçili olan satırlardan ilkini alıp, bunun ilk sütunundaki veriyi çekiyor

                    Database db = new Database();
                    //iladi nı veritabanından çekiyoruz ki güncel olsun. listvil den alabilirdik direk fakat böyle daha güvenli (tabi biraz daha yavaş fakat localde önemsenmeyecek kadar az)
                    txtTahsilAd.Text = db.DataOkuTek("select tahsilAdi from Tahsil where tahsilNo=@0", "tahsilAdi", tahsilKodu);
                    db.Kapat();

                    txtTahsilKodu.Text = tahsilKodu;
                    btnKaydet.Enabled = true;
                    btnSil.Enabled = true;
                    txtTahsilAd.Enabled = true;
                    txtTahsilKodu.Enabled = true;
                    yeniKayit = true;
                    toolTip.SetToolTip(btnYeni, "Yeni Kayıt");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listvTanimTahsil_DoubleClick(object sender, EventArgs e)
        {

        }

        private void txtTahsilKodu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }
    }
}
