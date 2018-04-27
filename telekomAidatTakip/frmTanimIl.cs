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
    public partial class frmTanimIl : MetroFramework.Forms.MetroForm
    {
        public frmTanimIl()
        {
            InitializeComponent();
        }

        private void frmTanimil_Load(object sender, EventArgs e)
        {
            try
            {
                this.MinimumSize = this.Size;
                frmTanimIl_Resize(this, null);
                IlListesiniDoldur();
                txtPlakaKodu.WaterMark = "Yeni kayıt açınız.";
                txtAdi.WaterMark = "Yeni kayıt açınız.";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.BeginInvoke(new MethodInvoker(Close));
            }
        }
        private void IlListesiniDoldur()
        {
            Database db = new Database();
            //data objesi sqlreadera dönüşüp veriyi alır. 
            //direk sqldatareaderda yazılabilir fakat bu sefer forum içerisinde using bilmemne yazmamız gerekir
            //var kelimesi ile tanımlanan değişkene ilk olarak ne eşitlersek o değişken tipinde olur
            var data = db.DataOku("select * from il");

            //listview içeriğini boşaltmamız gerekiyor il önce
            listvil.Items.Clear();

            while (data.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = data["ilNo"].ToString();
                item.SubItems.Add(data["ilAdi"].ToString());

                listvil.Items.Add(item);
                //oluşturulan item liste eklenir
            }
            db.Kapat();
            txtAdi.Enabled = false;
            txtPlakaKodu.Enabled = false;
            btnSil.Enabled = false;
            btnKaydet.Enabled = false;
            btnYeni.Enabled = true;
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
                    txtPlakaKodu.WaterMark = "Plaka kodunu giriniz.";
                    txtAdi.WaterMark = "İl adını giriniz.";
                    txtAdi.Text = string.Empty;
                    txtPlakaKodu.Text = string.Empty;
                    yeniKayit = false;
                    txtPlakaKodu.Enabled = true;
                    txtAdi.Enabled = true;
                    //  btnYeni.Text = "Ekle";
                    btnKaydet.Enabled = false;
                    btnSil.Enabled = false;
                    toolTip1.SetToolTip(btnYeni, "Ekle");
                }
                else //butonun ismi Yeni değilse demekki yeni kayıt sayfasındayız
                {
                    if (txtPlakaKodu.Text != string.Empty && txtAdi.Text != string.Empty) //yeni kayıt eklemek için bu iki verinin boş olmaması gerekiyor
                    {
                        Database db = new Database();
                        db.Sorgu("insert into il (ilno,iladi) values (@0,@1)", txtPlakaKodu.Text, txtAdi.Text);
                        db.Kapat();
                        DialogResult dialogResult = MessageBox.Show("Yeni kayıt eklendi.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPlakaKodu.Enabled = false;
                        txtAdi.Enabled = false;
                        //  btnYeni.Text = "Yeni";
                        IlListesiniDoldur();
                        txtAdi.Text = string.Empty;
                        txtPlakaKodu.Text = string.Empty;
                        txtPlakaKodu.WaterMark = "Yeni kayıt açınız.";
                        txtAdi.WaterMark = "Yeni kayıt açınız.";
                        btnYeni.Focus(); //görsel amaçlı
                        yeniKayit = true;
                        // toolTip1.SetToolTip(btnYeni, "Yeni Kayıt");
                    }
                    else
                    {
                        MessageBox.Show("Plaka kodu veya il adı kısmı boş!");
                    }

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
                if (plakakodu != string.Empty) //plaka kodu olmadan veri silmek tabiki biraz zor olur
                {
                    Database db1 = new Database();
                    string countMudurluk = "0";

                    var data = db1.DataOku("select count(mudurlukNo) 'count' from Mudurluk where ilNo=@0", plakakodu);
                    if (data.Read())
                    {
                        countMudurluk = data["count"].ToString();
                    }
                    db1.Kapat();
                    Database db2 = new Database();
                    string countUye = "0";

                    var data2 = db2.DataOku("select count(sicilNo) 'count' from Uyeler where ilNo=@0", plakakodu);
                    if (data2.Read())
                    {
                        countUye = data2["count"].ToString();
                    }
                    db2.Kapat();
                    Database db3 = new Database();
                    string countBirim = "0";
                    var data3 = db3.DataOku("select count(birimno) 'count' from Birim b join mudurluk m on m.mudurlukno = b.mudurlukno where m.ilno =@0", plakakodu);
                    if (data3.Read())
                    {
                        countBirim = data3["count"].ToString();
                    }
                    db3.Kapat();
                    Database db4 = new Database();
                    string countAidatLog = "0";
                    var data4 = db4.DataOku("select count(aidatLogNo) 'count' from AidatLog a join Uyeler u on u.sicilNo = a.sicilNo where u.ilNo =@0", plakakodu);
                    if (data4.Read())
                    {
                        countAidatLog = data4["count"].ToString();
                    }
                    db4.Kapat();
                    DialogResult dialogresult;
                    if (countAidatLog != "0" && countBirim != "0" && countMudurluk != "0" && countUye != "0")
                        dialogresult = MessageBox.Show("Bu işlem ile sadece ili değil, onun altında kayıtlı olan müdürlükleri, birimleri, kişileri ve aidat kayıtlarını da sileceksiniz.\n" + " \nSilinecek Müdürlük Sayısı: " + countMudurluk + "\nSilinecek Birim Sayısı: " + countBirim + "\nSilinecek Üye Sayısı:" + countUye + "\nSilinecek Aidat Kaydı:" + countAidatLog + "\n\nDevam etmek istediğinize emin misiniz?", "İl Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    else
                        dialogresult = MessageBox.Show("Seçili il silinecek. Emin misiniz?", "İl Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogresult == DialogResult.Yes)
                    {
                        Database db = new Database();
                        // Database db5 = new Database();
                        //  Database db6 = new Database();
                        // Database db7 = new Database();

                        // db6.Sorgu("delete from Uyeler where ilNo=@0",txtPlakaKodu.Text);
                        //  db5.Sorgu("delete from Mudurluk where ilNo=@0", txtPlakaKodu.Text);
                        db.Sorgu("delete from il where ilNo=@0", plakakodu);
                        db.Kapat();


                        IlListesiniDoldur();
                        txtAdi.Clear();
                        txtPlakaKodu.Clear();
                        plakakodu = string.Empty;
                        txtPlakaKodu.WaterMark = "Yeni kayıt açınız.";
                        txtAdi.WaterMark = "Yeni kayıt açınız.";
                        MessageBox.Show("Seçili il silindi!", "Kayıt Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (dialogresult == DialogResult.Cancel)
                        return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        string plakakodu;
        private void listvil_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                plakakodu = listvil.SelectedItems[0].Text; //listvilde seçili olan satırlardan ilkini alıp, bunun ilk sütunundaki veriyi çekiyor

                Database db = new Database();
                //iladi nı veritabanından çekiyoruz ki güncel olsun. listvil den alabilirdik direk fakat böyle daha güvenli (tabi biraz daha yavaş fakat localde önemsenmeyecek kadar az)
                txtAdi.Text = db.DataOkuTek("select iladi from il where ilNo=@0", "ilAdi", plakakodu);
                db.Kapat();

                txtPlakaKodu.Text = plakakodu;
                btnKaydet.Enabled = true;
                btnSil.Enabled = true;
                txtAdi.Enabled = true;
                txtPlakaKodu.Enabled = true;
                // btnYeni.Text = "Yeni";
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
                if (txtPlakaKodu.Text != string.Empty && txtAdi.Text != string.Empty) // yine boş verilerle bir yeri update edemeyiz
                {
                    Database db = new Database();
                    db.Sorgu("update il set iladi=@0,ilno=@1 where ilno=@2", txtAdi.Text, txtPlakaKodu.Text, plakakodu);
                    db.Kapat();

                    DialogResult dialogResult = MessageBox.Show("Değişiklikler kaydedildi.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAdi.Text = string.Empty;
                    txtPlakaKodu.Text = string.Empty;
                    plakakodu = string.Empty;
                    txtAdi.Enabled = false;
                    txtPlakaKodu.Enabled = false;
                    btnKaydet.Enabled = false;
                    btnSil.Enabled = false;
                    IlListesiniDoldur();
                    txtPlakaKodu.WaterMark = "Yeni kayıt açınız.";
                    txtAdi.WaterMark = "Yeni kayıt açınız.";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmTanimIl_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmTanimIl_Resize(object sender, EventArgs e)
        {
            //groupBox2.Width = this.Width - 49; //design sekmesindeki boyut farklarını buraya yazdık
            // groupBox2.Height = this.Height - 252;
            listvil.Size = new Size(listvil.Size.Width, this.Size.Height - 214);
        }


        private void txtPlakaKodu_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtPlakaKodu.Text != string.Empty)
                {
                    Database db = new Database();
                    var data = db.DataOku("select ilNo from il");
                    while (data.Read())
                    {
                        String sicilDb = data["ilNo"].ToString();
                        if (sicilDb.Equals(txtPlakaKodu.Text.ToString()))
                        {
                            MessageBox.Show("Bu plaka kodu kayıtlı.");
                            txtPlakaKodu.Clear();
                            txtPlakaKodu.Select();
                        }
                    }
                    db.Kapat();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPlakaKodu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }

    }
}
