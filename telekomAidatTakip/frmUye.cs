using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telekomAidatTakip
{
    public partial class frmUye : MetroForm
    {
        string sicilno;
        string resimPath;
        public frmUye() // yeni kayıt eklenirken
        {
            InitializeComponent();
        }
        public frmUye(string sicilno) //raporuye den çağırılınca
        {
            this.sicilno = sicilno;
            InitializeComponent();
        }



        private void frmUye_Load(object sender, EventArgs e)
        {
            // DoldurKomple();
            try
            {

                this.MaximumSize = this.Size;
                this.MinimumSize = this.Size;
                if (sicilno != null)
                {
                    btnSil.Enabled = true;
                    btnSil.Visible = true;
                    btnSil2.Enabled = true;
                    btnSil2.Visible = true;
                    btnSil3.Enabled = true;
                    btnSil3.Visible = true;
                    btnSil4.Enabled = true;
                    btnSil4.Visible = true;
                    btnSil5.Enabled = true;
                    btnSil5.Visible = true;
                    DoldurKomple(sicilno);
                    
                }
                else
                {
                    DoldurKomple();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.BeginInvoke(new MethodInvoker(Close));
            }
        }

        private void DoldurKomple()
        {
            PRG.DoldurTahsil(ref cboxTahsil);
            PRG.DoldurUnvan(ref cboxUnvan);
            PRG.DoldurIl(ref cboxIl);

            //3 kere daha aynı sql sorgusunu yapmasın diye cboxilden çekiyoruz verileri
            PRG.DoldurIlKopyala(ref cboxEvIl, cboxIl);
            PRG.DoldurIlKopyala(ref cboxIsIl, cboxIl);
            PRG.DoldurIlKopyala(ref cboxNufusIl, cboxIl);

            PRG.DoldurUyelikTipi(ref cboxUyelikTipi);
            PRG.DoldurKanGrubu(ref cboxNufusKan);



        }

        private void DoldurKomple(string sicilno)
        {
            DoldurKomple();
            DoldurTemelBilgiler(sicilno);
            DoldurFotograf(sicilno);
            DoldurAdresBilgiler(sicilno);
            DoldurNufusBilgileri(sicilno);
            DoldurAidatBilgileri(sicilno);
        }
        byte[] imgBytes;
        private void DoldurFotograf(string sicilno)
        {

            Database db = new Database();

            var data = db.DataOku("select fotograf from uyeFotograf where sicilno=@0", sicilno);

            if (data.Read())
            {
                imgBytes = (byte[])data["fotograf"];
            }
            db.Kapat();

            if (imgBytes == null || imgBytes.Length == 0)
            {
                pictureBox1.Image = Properties.Resources._default;
                return;
            }



            TypeConverter tc = TypeDescriptor.GetConverter(typeof(Bitmap));
            Bitmap foto = (Bitmap)tc.ConvertFrom(imgBytes);
            pictureBox1.Image = foto;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void DoldurNufusBilgileri(string sicilno)
        {
            Database db = new Database();
            var data = db.DataOku("select * from nufusbilgileri where sicilno=@0", sicilno);

            if (data.Read())
            {
                txtNufusBaba.Text = data["baba"].ToString();
                txtNufusAnne.Text = data["anne"].ToString();
                txtNufusDogumYeri.Text = data["dogumyeri"].ToString();
                dateNufusDogum.Value = Convert.ToDateTime(data["dogumTarihi"]);
                cboxNufusMedeni.SelectedIndex = Convert.ToInt32(data["medeniHali"]);
                cboxNufusKan.SelectedItem = PRG.cboxIndexBul(ref cboxNufusKan, data["kangrubuno"]);
                cboxNufusIl.SelectedItem = PRG.cboxIndexBul(ref cboxNufusIl, data["ilno"]);
                txtNufusIlce.Text = data["ilce"].ToString();
                txtNufusMahalle.Text = data["mahalle"].ToString();
                txtNufusSira.Text = data["sirano"].ToString();
                txtNufusCilt.Text = data["ciltno"].ToString();
                txtNufusAile.Text = data["ailesirano"].ToString();
            }
            db.Kapat();
        }
        private void DoldurAdresBilgiler(string sicilno)
        {
            Database db = new Database();
            var data = db.DataOku("select * from adres where sicilno=@0", sicilno);
            if (data.Read())
            {
                txtEvAdresi.Text = data["ev"].ToString();
                cboxEvIl.SelectedItem = PRG.cboxIndexBul(ref cboxEvIl, data["evilno"]);
                cboxIsIl.SelectedItem = PRG.cboxIndexBul(ref cboxIsIl, data["isilno"]);
                txtIsAdresi.Text = data["is"].ToString();
                txtEvTel.Text = data["evtel"].ToString();
                txtIsTel.Text = data["istel"].ToString();
                txtCepTel.Text = data["ceptel"].ToString();
                txtAdresEmail.Text = data["email"].ToString();

            }
            db.Kapat();
        }

        private void DoldurTemelBilgiler(string sicilno)
        {
            Database db = new Database();

            var data = db.DataOku("select * from uyeler where sicilno=@0", sicilno);
            if (data.Read())
            {
                txtAdSoyad.Text = data["adsoyad"].ToString();
                txtSicilNo.Text = sicilno;
                cboxTahsil.SelectedItem = PRG.cboxIndexBul(ref cboxTahsil, data["tahsilno"]);
                cboxUnvan.SelectedItem = PRG.cboxIndexBul(ref cboxUnvan, data["unvanno"]);
                cboxIl.SelectedItem = PRG.cboxIndexBul(ref cboxIl, data["ilno"]);
                PRG.DoldurMudurluk(ref cboxMudurluk, data["ilno"].ToString());
                PRG.DoldurBirim(ref cboxBirim, data["mudurlukno"].ToString());
                cboxMudurluk.SelectedItem = PRG.cboxIndexBul(ref cboxMudurluk, data["mudurlukno"]);
                cboxBirim.SelectedItem = PRG.cboxIndexBul(ref cboxBirim, data["birimno"]);
                cboxUyelikTipi.SelectedItem = PRG.cboxIndexBul(ref cboxUyelikTipi, data["uyeliktipino"]);

                if (!(bool)data["aktif"])
                {
                    Database db2 = new Database();

                    lblSilinmeBilgisi.Text = db2.DataOkuTek("select silinmenedeni from silinmenedeni where silinmenedenno = @0", "silinmenedeni", data["silinmenedenino"]);
                    db2.Kapat();
                    lblSilinmeBilgisi.Visible = true;
                    lblSilinmeBilgisiLabeli.Visible = true;
                    btnAktiflestir.Location = new Point(lblSilinmeBilgisi.Location.X + lblSilinmeBilgisi.Size.Width + 5, btnAktiflestir.Location.Y);
                    btnAktiflestir.Visible = true;
                    btnSil.Visible = false;
                    btnSil2.Visible = false;
                    btnSil3.Visible = false;
                    btnSil4.Visible = false;
                    btnSil5.Visible = false;
                }

                dateGiris.Value = Convert.ToDateTime(data["girisTarihi"]);
                dateKayit.Value = Convert.ToDateTime(data["kayitTarihi"]);
                txtNot.Text = data["not"].ToString();
            }
            db.Kapat();
        }
        private void DoldurAidatBilgileri(string sicilno)
        {
            Database db = new Database();

            var data = db.DataOku("select * from aidatlog where sicilno=@0", sicilno);
            listAidatLog.Items.Clear();
            while (data.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = data["aidatlogno"].ToString();
                DateTime dt = Convert.ToDateTime(data["tarih"].ToString());
                item.SubItems.Add(dt.ToString("MM.yyyy"));
                item.SubItems.Add(data["miktar"].ToString());
                listAidatLog.Items.Add(item);
            }
            db.Kapat();
            Database db2 = new Database();
            txtAidatMiktari.Text = db2.DataOkuTek("SELECT * FROM aidatmiktar WHERE birimno =@0 ", "aidat", PRG.cboxKeyGetir(ref cboxBirim));
            db2.Kapat();
        }
        public string BosYerVarMi()
        {
            if (txtSicilNo.Text == string.Empty)
            {
                return "Sicil numarası boş bırakılamaz";
            }
            if (txtAdSoyad.Text == string.Empty)
            {
                return "Ad soyad boş bırakılamaz";
            }
            if (cboxTahsil.Text == string.Empty)
            {
                return "Tahsil boş bırakılamaz";
            }
            if (cboxUnvan.Text == string.Empty)
            {
                return "Ünvan boş bırakılamaz";
            }
            if (cboxIl.Text == string.Empty)
            {
                return "İl boş bırakılamaz";
            }
            if (cboxMudurluk.Text == string.Empty)
            {
                return "Müdürlük boş bırakılamaz";
            }
            if (cboxBirim.Text == string.Empty)
            {
                return "Birim boş bırakılamaz";
            }
            if (cboxUyelikTipi.Text == string.Empty)
            {
                return "Üyelik tipi boş bırakılamaz";
            }


            return null;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (BosYerVarMi() == null)
                {
                    if (sicilno == null)
                    {
                        yeniKayitEkle();
                    }
                    else
                    {
                        uyeBilgisiGuncelle();
                    }
                }
                else
                    MessageBox.Show(BosYerVarMi());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void yeniKayitEkle()
        {
            try
            {
                Database db, db2;
                byte[] resim;
                db = new Database();
                db2 = new Database();
                resim = fotografiAl(pictureBox1.Image);

                var kanNo = PRG.cboxKeyGetir(ref cboxNufusKan);// ((KeyValuePair<int, string>)cboxNufusKan.SelectedItem).Key;
                var mdr = PRG.cboxKeyGetir(ref cboxMudurluk);//((KeyValuePair<int, string>)cboxMudurluk.SelectedItem).Key;
                var ilno = PRG.cboxKeyGetir(ref cboxIl);//((KeyValuePair<int, string>)cboxIl.SelectedItem).Key;
                var birimno = PRG.cboxKeyGetir(ref cboxBirim);//((KeyValuePair<int, string>)cboxBirim.SelectedItem).Key;
                var tahsilno = PRG.cboxKeyGetir(ref cboxTahsil);//((KeyValuePair<int, string>)cboxTahsil.SelectedItem).Key;
                var uyeliktipno = PRG.cboxKeyGetir(ref cboxUyelikTipi);//((KeyValuePair<int, string>)cboxUyelikTipi.SelectedItem).Key;
                var unvan = PRG.cboxKeyGetir(ref cboxUnvan);//((KeyValuePair<int, string>)cboxUnvan.SelectedItem).Key;
                var evilNo = PRG.cboxKeyGetir(ref cboxEvIl);//((KeyValuePair<int, string>)cboxEvIl.SelectedItem).Key;
                var isilNo = PRG.cboxKeyGetir(ref cboxIsIl);//((KeyValuePair<int, string>)cboxIsIl.SelectedItem).Key;




                db.Sorgu("insert into Uyeler (sicilNo,adSoyad,tahsilNo,unvanNo,ilNo,mudurlukNo,birimNo,uyelikTipiNo,girisTarihi,kayitTarihi,aktif, [not]) values (@0,@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11);" +
                "insert into Adres (sicilNo,ev,evilNo,[is],isilNo,evTel,istel,ceptel,email) values (@12,@13,@14,@15,@16,@17,@18,@19,@20);" +
                "insert into nufusBilgileri (sicilNo,baba,anne,dogumYeri,dogumTarihi,medeniHali,kanGrubuno,ilNo,ilce,mahalle,ciltNo,aileSiraNo,siraNo) values (@21,@22,@23,@24,@25,@26,@27,@28,@29,@30,@31,@32,@33);", txtSicilNo.Text, txtAdSoyad.Text, tahsilno, unvan, ilno, mdr, birimno, uyeliktipno, dateGiris.Value.Date, dateKayit.Value.Date, "1", txtNot.Text, txtSicilNo.Text, txtEvAdresi.Text, evilNo, txtIsAdresi.Text, isilNo, txtEvTel.Text, txtIsTel.Text, txtCepTel.Text, txtAdresEmail.Text, txtSicilNo.Text, txtNufusBaba.Text, txtNufusAnne.Text, txtNufusDogumYeri.Text, dateNufusDogum.Value.Date, cboxNufusMedeni.SelectedIndex, kanNo, ilno, txtNufusIlce.Text, txtNufusMahalle.Text, txtNufusCilt.Text, txtNufusAile.Text, txtNufusSira.Text);

                if (pictureBox1.Image != null)
                    db2.Sorgu("insert into UyeFotograf (sicilNo,Fotograf) values (@0,@1)", txtSicilNo.Text, resim);
                MessageBox.Show("Yeni üye kaydedildi.", "Üye Kayıt", MessageBoxButtons.OK);

                db.Kapat();
                db2.Kapat();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        private void uyeBilgisiGuncelle()
        {
            try
            {
                Database db, db2, db3;
                byte[] resim = fotografiAl(pictureBox1.Image);
                db = new Database();
                db2 = new Database();
                db3 = new Database();


                var kanNo = PRG.cboxKeyGetir(ref cboxNufusKan);// ((KeyValuePair<int, string>)cboxNufusKan.SelectedItem).Key;
                var mdr = PRG.cboxKeyGetir(ref cboxMudurluk);//((KeyValuePair<int, string>)cboxMudurluk.SelectedItem).Key;
                var ilno = PRG.cboxKeyGetir(ref cboxIl);//((KeyValuePair<int, string>)cboxIl.SelectedItem).Key;
                var birimno = PRG.cboxKeyGetir(ref cboxBirim);//((KeyValuePair<int, string>)cboxBirim.SelectedItem).Key;
                var tahsilno = PRG.cboxKeyGetir(ref cboxTahsil);//((KeyValuePair<int, string>)cboxTahsil.SelectedItem).Key;
                var uyeliktipno = PRG.cboxKeyGetir(ref cboxUyelikTipi);//((KeyValuePair<int, string>)cboxUyelikTipi.SelectedItem).Key;
                var unvan = PRG.cboxKeyGetir(ref cboxUnvan);//((KeyValuePair<int, string>)cboxUnvan.SelectedItem).Key;
                var evilNo = PRG.cboxKeyGetir(ref cboxEvIl);//((KeyValuePair<int, string>)cboxEvIl.SelectedItem).Key;
                var isilNo = PRG.cboxKeyGetir(ref cboxIsIl);//((KeyValuePair<int, string>)cboxIsIl.SelectedItem).Key;


                db.Sorgu("UPDATE Uyeler SET adSoyad=@0,tahsilNo=@1,unvanNo=@2,ilNo=@3,mudurlukNo=@4,birimNo=@5,uyelikTipiNo=@6,girisTarihi=@7,kayitTarihi=@8, [not]=@9 WHERE sicilNo=@10;" +
                "UPDATE Adres SET ev=@11,evilNo=@12,[is]=@13,isilNo=@14,evTel=@15,istel=@16,ceptel=@17, email=@18 wHERE SİCİLNO=@10 ;" +
                "UPDATE nufusBilgileri SET baba=@19,anne=@20,dogumYeri=@21,dogumTarihi=@22,medeniHali=@23,kanGrubuno=@24,ilNo=@25,ilce=@26,mahalle=@27,ciltNo=@28,aileSiraNo=@29,siraNo=@30 WHERE sicilNo=@10;",
                txtAdSoyad.Text, tahsilno.ToString(), unvan.ToString(), ilno.ToString(), mdr.ToString(), birimno.ToString(), uyeliktipno.ToString(), dateGiris.Value.Date, dateKayit.Value.Date, txtNot.Text, sicilno,
                txtEvAdresi.Text, evilNo, txtIsAdresi.Text, isilNo, txtEvTel.Text, txtIsTel.Text, txtCepTel.Text, txtAdresEmail.Text,
                txtNufusBaba.Text, txtNufusAnne.Text, txtNufusDogumYeri.Text, dateNufusDogum.Value.Date, cboxNufusMedeni.SelectedIndex, kanNo, ilno, txtNufusIlce.Text, txtNufusMahalle.Text, txtNufusCilt.Text, txtNufusAile.Text, txtNufusSira.Text);

                var data = db2.DataOku("SELECT * FROM uyeFotograf WHERE sicilNo=@0", sicilno);

                if (data.Read())
                {
                    db3.Sorgu("UPDATE uyeFotograf SET fotograf = @0 WHERE sicilNo = @1", resim, sicilno);
                    db3.Kapat();
                }
                else
                {
                    db3.Sorgu("insert into UyeFotograf (sicilNo,Fotograf) values (@0,@1)", sicilno, resim);
                    db3.Kapat();
                }
                db2.Kapat();

                MessageBox.Show("Kayıt güncellendi!", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();


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
                if (sicilno != string.Empty)
                {
                    frmUyeSil frm = new frmUyeSil(sicilno);
                    frm.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                    {
                        DoldurKomple(sicilno);
                    }

                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Silme işlemi için sicil numarası gerekli.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnYeniResim_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fd = new OpenFileDialog();
                fd.Title = "Resim seç";
                fd.Filter = "Resim Dosyaları (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

                if (fd.ShowDialog() == DialogResult.OK)
                {
                    this.pictureBox1.Image = new Bitmap(fd.OpenFile());
                    resimPath = fd.FileName.ToString();
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnResimSil_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private byte[] fotografiAl(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        private void btnAidatEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Database db = new Database();
                db.Sorgu("insert into aidatlog (sicilNo,miktar,tarih) Values (@0, @1,@2)", sicilno, txtAidatMiktari.Text, dateAidatTarih.Value.Date);
                db.Kapat();
                DoldurAidatBilgileri(sicilno);

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
                if (cboxIl.SelectedIndex != -1)
                    PRG.DoldurMudurluk(ref cboxMudurluk, ((KeyValuePair<int, string>)cboxIl.SelectedItem).Key.ToString());

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
                if (cboxMudurluk.SelectedIndex != -1)
                    PRG.DoldurBirim(ref cboxBirim, ((KeyValuePair<int, string>)cboxMudurluk.SelectedItem).Key.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Buradan sonrası.. Ömer
        private void txtSayiKontrol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }
        /* bu kadar fonksiyona ne gerek var :D
        private void txtSicilNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }

        private void txtEvTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }

        private void txtIsTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }

        private void txtCepTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }

        private void txtNufusCilt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }

        private void txtNufusAile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }

        private void txtNufusSira_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }
        */

        private void txtSicilNo_Leave(object sender, EventArgs e)
        {
            try
            {
                Database db = new Database();
                var data = db.DataOku("select sicilNo from Uyeler");
                while (data.Read())
                {
                    String sicilDb = data["sicilNo"].ToString();
                    if (sicilDb.Equals(txtSicilNo.Text.ToString()))
                    {
                        MessageBox.Show("Bu sicil Numarası kayıtlı.");
                        txtSicilNo.Clear();
                        txtSicilNo.Select();
                    }
                }
                db.Kapat();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAktiflestir_Click(object sender, EventArgs e)
        {
            try
            {
                Database db = new Database();
                db.Sorgu("update uyeler set aktif = 1, silinmenedenino= NULL where sicilno=@0", sicilno);
                db.Kapat();
                lblSilinmeBilgisi.Visible = false;
                lblSilinmeBilgisiLabeli.Visible = false;
                btnAktiflestir.Visible = false;
                frmUye_Load(this, null);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtAdresEmail_Leave(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            if (txtAdresEmail.Text != string.Empty)
            {

                if (!reg.IsMatch(txtAdresEmail.Text))
                {
                    MessageBox.Show("Email formatı yanlış.\n" + "Örnek: kullaniciAdi@turktelekom.com.tr");
                    txtAdresEmail.Clear();
                    txtAdresEmail.Select();

                }
            }
        }
    }
}
