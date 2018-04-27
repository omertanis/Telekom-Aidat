using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telekomAidatTakip
{
    public partial class frmRaporUye : MetroForm
    {
        public frmRaporUye()
        {
            InitializeComponent();
        }


        public frmRaporUye(string ilNo)
        {
            try
            {
                InitializeComponent();
                //checkbox tikle
                checkIl.Checked = true;
                cboxIl.SelectedItem = PRG.cboxIndexBul(ref cboxIl, ilNo);
                btnEkranaListele_Click(this, null);
                //checkboxda il seç
                //ekran listeleye tıklat

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }




        //PRG.DoldurTahsil(ref cboxTahsil);
        //PRG.DoldurUyelikTipi(ref cboxUyelikDurumu);




        private void checkIl_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkIl.Checked)
                {
                    cboxIl.Enabled = true;
                    PRG.DoldurIl(ref cboxIl);
                    if (cboxIl.SelectedIndex == -1)
                    {
                        checkMudurluk.Enabled = false;
                        cboxMudurluk.Enabled = false;
                    }

                    else
                    {
                        checkMudurluk.Enabled = true;
                        cboxMudurluk.Enabled = false;
                    }
                }
                else
                {
                    cboxIl.Enabled = false;
                    cboxIl.SelectedIndex = -1;
                    cboxMudurluk.Enabled = false;
                    checkMudurluk.Checked = false;
                    checkMudurluk.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /* private void cboxII_SelectedIndexChanged(object sender, EventArgs e)
         {
             /*if (checkMudurluk.Checked && checkIl.Checked)
             {
                 PRG.DoldurMudurluk(ref cboxMudurluk, ((KeyValuePair<int, string>)cboxII.SelectedItem).Key.ToString());
                 cboxMudurluk.Enabled = true;
             }  

             if (checkMudurluk.Checked)
             {
                 checkMudurluk.Checked = false;
             }
         }*/


        private void checkMudurluk_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkMudurluk.Checked)
                {
                    cboxII_SelectionChangeCommitted(this, null);
                    cboxMudurluk.Enabled = true;
                    if (cboxMudurluk.SelectedIndex == -1)
                    {
                        checkBirim.Enabled = false;
                        cboxBirim.Enabled = false;
                    }

                    else
                    {
                        checkBirim.Enabled = true;
                        cboxBirim.Enabled = false;
                    }

                }
                else
                {
                    cboxBirim.Enabled = false;
                    cboxMudurluk.Enabled = false;
                    cboxMudurluk.SelectedIndex = -1;
                    checkBirim.Enabled = false;
                    checkBirim.Checked = false;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void checkBirim_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBirim.Checked)
                {
                    cboxMudurluk_SelectionChangeCommitted(this, null);
                    cboxMudurluk.Enabled = true;
                }
                else
                {
                    cboxBirim.SelectedIndex = -1;
                    cboxBirim.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkUnvan_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkUnvan.Checked)
                {
                    PRG.DoldurUnvan(ref cboxUnvan);
                }

                else
                {
                    cboxUnvan.Enabled = false;
                    cboxUnvan.SelectedIndex = -1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkTahsil_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkTahsil.Checked)
                {
                    PRG.DoldurTahsil(ref cboxTahsil);
                }

                else
                {
                    cboxTahsil.Enabled = false;
                    cboxTahsil.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkUyelik_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkUyelik.Checked)
                {
                    PRG.DoldurUyelikTipi(ref cboxUyelikDurumu);
                }

                else
                {
                    cboxUyelikDurumu.Enabled = false;
                    cboxUyelikDurumu.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkKanGrubu_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkKanGrubu.Checked)
                {
                    PRG.DoldurKanGrubu(ref cboxKanGrubu);
                }

                else
                {
                    cboxKanGrubu.Enabled = false;
                    cboxKanGrubu.SelectedIndex = -1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEkranaListele_Click(object sender, EventArgs e)
        {
            try
            {
                //TABLODA VERİ YOKKEN VERİ YOK DİYECEK.


                //kısaltma olarak FROM uyeler u dediğimde hata veriyor ondan uzun uzun yazdım küfür etmeyin
                //tek satırda yazmazsam da hata veriyor ömer buralarda çıldırdı
                Database db = new Database();
                SqlParameter paramTemp;
                string temelSorgu = "SELECT u.adSoyad, u.sicilNo, kg.kanGrubu, i.ilAdi, m.mudurlukAdi, b.birimAdi, unv.unvanAdi, t.tahsilAdi FROM uyeler u left join nufusbilgileri nufus on nufus.sicilno = u.sicilno left join kangrubu kg on nufus.kanGrubuNo = kg.kanGrubuNo left join il i on u.ilNo = i.ilNo left join mudurluk m on u.mudurlukNo = m.mudurlukNo left join birim b on u.birimNo = b.birimNo left join unvan unv on u.unvanNo = unv.unvanNo left join tahsil t on u.tahsilNo = t.tahsilNo ";
                string ekSorgu = string.Empty;



                List<SqlParameter> paramList = new List<SqlParameter>();
                if (checkIl.Checked)
                {
                    ekSorgu += "AND u.ilNo = @il ";
                    temelSorgu.Replace("left join il", "join il");
                    paramTemp = new SqlParameter("@il", PRG.cboxKeyGetir(ref cboxIl));
                    paramList.Add(paramTemp);
                }


                if (checkMudurluk.Checked)
                {
                    ekSorgu += "AND u.mudurlukNo = @mudurlukNo ";
                    temelSorgu.Replace("left join mudurluk", "join mudurluk");
                    paramTemp = new SqlParameter("@mudurlukNo", PRG.cboxKeyGetir(ref cboxMudurluk));
                    paramList.Add(paramTemp);
                }

                if (checkBirim.Checked)
                {
                    ekSorgu += "AND u.birimNo = @birimNo ";
                    temelSorgu.Replace("left join birim", "join birim");
                    paramTemp = new SqlParameter("@birimNo", PRG.cboxKeyGetir(ref cboxBirim));
                    paramList.Add(paramTemp);
                }

                if (checkUnvan.Checked)
                {
                    ekSorgu += "AND u.unvanNo = @unvanNo ";
                    temelSorgu.Replace("left join unvan", "join unvan");
                    paramTemp = new SqlParameter("@unvanNo", PRG.cboxKeyGetir(ref cboxUnvan));
                    paramList.Add(paramTemp);
                }

                if (checkTahsil.Checked)
                {
                    ekSorgu += "AND u.tahsilNo = @tahsilNo ";
                    temelSorgu.Replace("left join tahsil", "join tahsil");
                    paramTemp = new SqlParameter("@tahsilNo", PRG.cboxKeyGetir(ref cboxTahsil));
                    paramList.Add(paramTemp);
                }

                if (checkUyelik.Checked)
                {
                    ekSorgu += "AND u.uyelikTipiNo = @uyelikTipiNo ";
                    paramTemp = new SqlParameter("@uyelikTipiNo", PRG.cboxKeyGetir(ref cboxUyelikDurumu));
                    paramList.Add(paramTemp);
                }

                if (checkKanGrubu.Checked)
                {
                    ekSorgu += "AND nufus.kanGrubuNo = @kanGrubuNo ";
                    temelSorgu.Replace("left join kangrubu", "join kangrubu");
                    paramTemp = new SqlParameter("@kanGrubuNo", PRG.cboxKeyGetir(ref cboxKanGrubu));
                    paramList.Add(paramTemp);
                }


                if (radioAktif.Checked)
                {
                    string uyelikTipiNo = 2.ToString();
                    ekSorgu += "AND u.aktif = '1'";
                }
                else if (radioPasif.Checked)
                {
                    string uyelikTipiNo = 2.ToString();
                    ekSorgu += "AND u.aktif = '0'";
                }
                if (ekSorgu != string.Empty)
                    ekSorgu = "where " + ekSorgu.Substring(4);
                temelSorgu += ekSorgu;

                var data = db.DataOku(temelSorgu, paramList);
                listUye.Items.Clear();
                listUye.Items.Clear();
                if (data.HasRows)
                {
                    btnYazdir.Enabled = true;
                    yazdir.list = listUye;
                    yazdir.baslik = "Üye Listesi";
                }
                while (data.Read())
                {
                    string ilMudBir = data["ilAdi"].ToString() + "/" + data["mudurlukAdi"].ToString() + "/" + data["birimAdi"].ToString();
                    ListViewItem item = new ListViewItem();
                    item.Text = data["sicilNo"].ToString();
                    item.SubItems.Add(data["adSoyad"].ToString());
                    item.SubItems.Add(data["kanGrubu"].ToString());
                    item.SubItems.Add(ilMudBir);
                    item.SubItems.Add(data["unvanAdi"].ToString());
                    item.SubItems.Add(data["tahsilAdi"].ToString());

                    listUye.Items.Add(item);
                }
                db.Kapat();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listUye_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (listUye.SelectedItems.Count > 0)
                {
                    frmUye frm = new frmUye(listUye.SelectedItems[0].Text);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    btnEkranaListele_Click(this, null);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

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
        Yazdir yazdir = new Yazdir(1);
        private void frmRaporUye_Load(object sender, EventArgs e)
        {

            this.MinimumSize = this.Size;
            //this.Controls.Add(yazdir.printPre);

        }

        private void cboxII_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cboxIl.SelectedIndex != -1)
                {
                    PRG.DoldurMudurluk(ref cboxMudurluk, ((KeyValuePair<int, string>)cboxIl.SelectedItem).Key.ToString());
                    if (!checkMudurluk.Checked)
                        cboxMudurluk.Enabled = false;
                    checkMudurluk.Enabled = true;

                }
                else
                {
                    checkMudurluk.Checked = false;
                    checkMudurluk.Enabled = false;
                    checkBirim.Enabled = false;
                    checkBirim.Checked = false;
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
                int mdr = PRG.cboxKeyGetir(ref cboxMudurluk);
                if (mdr != -1)
                {
                    PRG.DoldurBirim(ref cboxBirim, mdr.ToString());
                    if (!checkBirim.Checked)
                        cboxBirim.Enabled = false;
                    checkBirim.Enabled = true;
                }
                else
                {
                    checkBirim.Enabled = false;
                    checkBirim.Checked = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboxII_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkMudurluk.Checked)
            {
                checkMudurluk.Checked = false;
            }
        }

        private void frmRaporUye_Resize(object sender, EventArgs e)
        {
            listUye.Size = new Size(listUye.Size.Width, this.Size.Height - 366);
        }
    }
}
