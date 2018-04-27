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
    public partial class frmRaporAidat : MetroForm
    {
        public frmRaporAidat()
        {
            InitializeComponent();
        }

        private void frmRaporAidat_Load(object sender, EventArgs e)
        {
            try
            {
                this.MinimumSize = this.Size;

                PRG.DoldurIl(ref cboxil);
                cboxil.SelectedIndex = -1;
                cboxMudurluk.SelectedIndex = -1;
                cboxBirim.SelectedIndex = -1;
                cboxMudurluk.Enabled = false;
                cboxBirim.Enabled = false;
                cboxil.Enabled = false;
                checkBirim.Enabled = false;
                checkMudurluk.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.BeginInvoke(new MethodInvoker(Close));
            }
        }






        private void btnListele_Click(object sender, EventArgs e)
        {
            try
            {
                //tarih ve ödenmeyenleri listele kısımları kullanılmıyor şimdilik
                Database db = new Database();
                string query = "select u.sicilNo, u.adSoyad, (select aidat from AidatMiktar where birimno = u.birimNo) 'Miktar', alog.toplam 'toplammiktar', i.ilAdi, m.mudurlukAdi, b.birimAdi from uyeler u join il i on i.ilNo = u.ilNo join Mudurluk m on m.mudurlukNo = u.mudurlukNo join birim b on b.birimNo = u.birimNo join (select SUM(miktar) toplam, sicilno from aidatlog group by sicilno) alog on alog.sicilno=u.sicilno ";
                List<SqlParameter> paramList = new List<SqlParameter>();
                if (checkBirim.Checked || checkMudurluk.Checked || checkIl.Checked)
                {
                    string ekquery = " where ";

                    SqlParameter paramTemp;
                    if (checkIl.Checked)
                    {
                        if (cboxil.SelectedIndex == -1)
                        {
                            MessageBox.Show("İl seçin yada yanındaki ticki kaldırın.");
                            return;
                        }
                        ekquery += "i.ilno = @il and ";
                        String ilNo = ((KeyValuePair<int, string>)cboxil.SelectedItem).Key.ToString();
                        paramTemp = new SqlParameter("@il", ilNo);
                        paramList.Add(paramTemp);
                    }


                    if (checkMudurluk.Checked)
                    {
                        if (cboxMudurluk.SelectedIndex == -1)
                        {
                            MessageBox.Show("Müdürlük seçin yada yanındaki ticki kaldırın.");
                            return;
                        }
                        ekquery += "m.mudurlukno = @mudurluk and ";
                        String mudurlukno = ((KeyValuePair<int, string>)cboxMudurluk.SelectedItem).Key.ToString();
                        paramTemp = new SqlParameter("@mudurluk", mudurlukno);
                        paramList.Add(paramTemp);
                    }
                    if (checkBirim.Checked)
                    {
                        if (cboxBirim.SelectedIndex == -1)
                        {
                            MessageBox.Show("Birim seçin yada yanındaki ticki kaldırın.");
                            return;
                        }
                        ekquery += "b.birimno = @birim and ";
                        String birimno = ((KeyValuePair<int, string>)cboxBirim.SelectedItem).Key.ToString();
                        paramTemp = new SqlParameter("@birim", birimno);
                        paramList.Add(paramTemp);
                    }

                    ekquery = ekquery.Trim().Substring(0, ekquery.Length - 5);
                    query += ekquery;
                }

                var data = db.DataOku(query, paramList);
                listUyeKayitlari.Items.Clear();
                if (data.HasRows)
                {
                    yazdir.list = listUyeKayitlari;
                    yazdir.baslik = "Aidat Listesi";
                    btnYazdir.Enabled = true;
                }
                while (data.Read())
                {

                    ListViewItem item = new ListViewItem();
                    item.Text = data["sicilNo"].ToString();
                    item.SubItems.Add(data["adSoyad"].ToString());
                    if (data["miktar"].ToString() == string.Empty)
                        item.SubItems.Add("0");
                    else
                        item.SubItems.Add(data["miktar"].ToString());

                    if (data["toplammiktar"].ToString() == string.Empty)
                        item.SubItems.Add("0");
                    else
                        item.SubItems.Add(data["toplammiktar"].ToString());

                    item.SubItems.Add(data["ilAdi"].ToString());
                    item.SubItems.Add(data["mudurlukAdi"].ToString());
                    item.SubItems.Add(data["birimAdi"].ToString());

                    listUyeKayitlari.Items.Add(item);
                }
                db.Kapat();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        Yazdir yazdir = new Yazdir(1);

        private void cboxil_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cboxil.SelectedIndex != -1)
                {
                    PRG.DoldurMudurluk(ref cboxMudurluk, ((KeyValuePair<int, string>)cboxil.SelectedItem).Key.ToString());
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

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            yazdir.printPre.ShowDialog();
        }

        private void listUyeKayitlari_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (listUyeKayitlari.SelectedItems.Count > 0)
                {
                    frmUye frm = new frmUye(listUyeKayitlari.SelectedItems[0].Text);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void checkIl_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkIl.Checked)
                {
                    cboxil.Enabled = true;
                    cboxMudurluk.Enabled = false;
                    if (cboxil.SelectedIndex == -1)
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
                    cboxil.Enabled = false;
                    cboxil.SelectedIndex = -1;
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

        private void checkMudurluk_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkMudurluk.Checked)
                {
                    cboxil_SelectionChangeCommitted(this, null);
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
                    cboxBirim.Enabled = true;
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

        private void cboxil_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkMudurluk.Checked)
                {
                    checkMudurluk.Checked = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmRaporAidat_Resize(object sender, EventArgs e)
        {
            listUyeKayitlari.Size = new Size(listUyeKayitlari.Size.Width, this.Size.Height - 241);
        }
    }



}

