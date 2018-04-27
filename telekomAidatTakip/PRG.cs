using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telekomAidatTakip
{
    static class PRG
    {
        public static void DoldurTahsil(ref MetroComboBox cboxTahsil)
        {
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            Database db = new Database();
            var data = db.DataOku("select * from tahsil");

            while (data.Read())
                cboxSource.Add(Convert.ToInt32(data["tahsilno"]), data["tahsiladi"].ToString());
            if (cboxSource.Count == 0)
            {
                cboxSource.Add(-1, "Veri Yok");
                cboxTahsil.Enabled = false;
            }
            cboxTahsil.DataSource = new BindingSource(cboxSource, null);
            cboxTahsil.DisplayMember = "Value";
            cboxTahsil.ValueMember = "Key";
            cboxTahsil.Enabled = true;
            cboxTahsil.SelectedIndex = -1;
            db.Kapat();
        }
        
        public static void DoldurUnvan(ref MetroComboBox cboxUnvan)
        {
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            Database db = new Database();
            var data = db.DataOku("select * from unvan");

            while (data.Read())
                cboxSource.Add(Convert.ToInt32(data["unvanNo"]), data["Unvanadi"].ToString());
            if (cboxSource.Count == 0)
            {
                cboxSource.Add(-1, "Veri Yok");
                cboxUnvan.Enabled = false;
            }
            cboxUnvan.DataSource = new BindingSource(cboxSource, null);
            cboxUnvan.DisplayMember = "Value";
            cboxUnvan.ValueMember = "Key";
            cboxUnvan.Enabled = true;
            cboxUnvan.SelectedIndex = -1;
            db.Kapat();
        }
        public static void DoldurIl(ref MetroComboBox cboxIl)
        {
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            Database db = new Database();
            var data = db.DataOku("select * from il");

            while (data.Read())
                cboxSource.Add(Convert.ToInt32(data["ilno"]), data["iladi"].ToString());
            if (cboxSource.Count == 0)
            {
                cboxSource.Add(-1, "Veri Yok");
                cboxIl.Enabled = false;
            }
            cboxIl.DataSource = new BindingSource(cboxSource, null);
            cboxIl.DisplayMember = "Value";
            cboxIl.ValueMember = "Key";
            cboxIl.Enabled = true;
            cboxIl.SelectedIndex = -1;
            db.Kapat();
        }
        public static void DoldurIlKopyala(ref MetroComboBox cbox, MetroComboBox cboxIl)
        {
            cbox.DataSource = new BindingSource(cboxIl.DataSource, null);
            cbox.DisplayMember = "Value";
            cbox.ValueMember = "Key";
            cbox.SelectedIndex = -1;
            cbox.Enabled = true;
        }
        public static void DoldurUyelikTipi(ref MetroComboBox cboxUyelikTipi)
        {
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            Database db = new Database();
            var data = db.DataOku("select * from uyeliktipi");

            while (data.Read())
                cboxSource.Add(Convert.ToInt32(data["uyeliktipno"]), data["uyeliktipadi"].ToString());
            if (cboxSource.Count == 0)
            {
                cboxSource.Add(-1, "Veri Yok");
                cboxUyelikTipi.Enabled = false;
            }
            cboxUyelikTipi.DataSource = new BindingSource(cboxSource, null);
            cboxUyelikTipi.DisplayMember = "Value";
            cboxUyelikTipi.ValueMember = "Key";
            cboxUyelikTipi.Enabled = true;
            cboxUyelikTipi.SelectedIndex = -1;
            db.Kapat();
        }
        public static void DoldurKanGrubu(ref MetroComboBox cboxKanGrubu)
        {
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            Database db = new Database();
            var data = db.DataOku("select * from kangrubu");

            while (data.Read())
                cboxSource.Add(Convert.ToInt32(data["kangrubuno"]), data["kangrubu"].ToString());
            if (cboxSource.Count == 0)
            {
                cboxSource.Add(-1, "Veri Yok");
                cboxKanGrubu.Enabled = false;
            }
            cboxKanGrubu.DataSource = new BindingSource(cboxSource, null);
            cboxKanGrubu.DisplayMember = "Value";
            cboxKanGrubu.ValueMember = "Key";
            cboxKanGrubu.Enabled = true;
            cboxKanGrubu.SelectedIndex = -1;
            db.Kapat();
        }
        public static void DoldurSilinmeNedeni(ref MetroComboBox cboxSilinmeNedeni)
        {
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            Database db = new Database();
            var data = db.DataOku("select * from silinmenedeni");

            while (data.Read())
                cboxSource.Add(Convert.ToInt32(data["silinmenedenno"]), data["silinmenedeni"].ToString());
            if (cboxSource.Count == 0)
            {
                cboxSource.Add(-1, "Veri Yok");
                cboxSilinmeNedeni.Enabled = false;
            }
            cboxSilinmeNedeni.DataSource = new BindingSource(cboxSource, null);
            cboxSilinmeNedeni.DisplayMember = "Value";
            cboxSilinmeNedeni.ValueMember = "Key";
            cboxSilinmeNedeni.Enabled = true;
            cboxSilinmeNedeni.SelectedIndex = -1;
            db.Kapat();
        }
        public static void DoldurMudurluk(ref MetroComboBox cboxMudurluk, string ilNo)
        {
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            if (ilNo != string.Empty)
            {
                Database db = new Database();
                var data = db.DataOku("select * from mudurluk where ilno=@0", ilNo);

                while (data.Read())
                    cboxSource.Add(Convert.ToInt32(data["mudurlukno"]), data["mudurlukadi"].ToString());
                if (cboxSource.Count == 0)
                {
                    cboxSource.Add(-1, "Veri Yok");
                    cboxMudurluk.Enabled = false;
                }
                db.Kapat();
            }
            else
            {
                cboxSource.Add(-2, "İlk önce il seçin");
                cboxMudurluk.Enabled = false;
            }
            cboxMudurluk.DataSource = new BindingSource(cboxSource, null);
            cboxMudurluk.DisplayMember = "Value";
            cboxMudurluk.ValueMember = "Key";
            cboxMudurluk.Enabled = true;
            cboxMudurluk.SelectedIndex = -1;
        }
        public static void DoldurBirim(ref MetroComboBox cboxBirim, string mudurlukNo)
        {
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            if (mudurlukNo != string.Empty)
            {
                Database db = new Database();
                var data = db.DataOku("select * from birim where mudurlukno=@0", mudurlukNo);

                while (data.Read())
                    cboxSource.Add(Convert.ToInt32(data["birimno"]), data["birimadi"].ToString());
                if (cboxSource.Count == 0)
                {
                    cboxSource.Add(-1, "Veri Yok");
                    cboxBirim.Enabled = false;
                }
                db.Kapat();
            }
            else
            {
                cboxSource.Add(-2, "İlk önce il seçin");
                cboxBirim.Enabled = false;
            }
            cboxBirim.DataSource = new BindingSource(cboxSource, null);
            cboxBirim.DisplayMember = "Value";
            cboxBirim.ValueMember = "Key";
            cboxBirim.Enabled = true;
            cboxBirim.SelectedIndex = -1;
        }
        public static object cboxIndexBul(ref MetroComboBox cbox, object key)
        {
            int key1 = Convert.ToInt32(key);
            foreach (object item in cbox.Items)
            {
                if (((KeyValuePair < int, string>)item).Key == key1)
                {
                    return item;
                }
            }
            return null;
        }
        public static int cboxKeyGetir(ref MetroComboBox cbox)
        {
            if (cbox.SelectedIndex != -1)
            {
                return ((KeyValuePair<int, string>)cbox.SelectedItem).Key;
            }
            return -1;
        }
        public static void DoldurTahsil(ref ComboBox cboxTahsil)
        {
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            Database db = new Database();
            var data = db.DataOku("select * from tahsil");

            while (data.Read())
                cboxSource.Add(Convert.ToInt32(data["tahsilno"]), data["tahsiladi"].ToString());
            if (cboxSource.Count == 0)
            {
                cboxSource.Add(-1, "Veri Yok");
                cboxTahsil.Enabled = false;
            }
            cboxTahsil.DataSource = new BindingSource(cboxSource, null);
            cboxTahsil.DisplayMember = "Value";
            cboxTahsil.ValueMember = "Key";
            cboxTahsil.Enabled = true;
            cboxTahsil.SelectedIndex = -1;
            db.Kapat();
        }

        public static void DoldurUnvan(ref ComboBox cboxUnvan)
        {
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            Database db = new Database();
            var data = db.DataOku("select * from unvan");

            while (data.Read())
                cboxSource.Add(Convert.ToInt32(data["unvanNo"]), data["Unvanadi"].ToString());
            if (cboxSource.Count == 0)
            {
                cboxSource.Add(-1, "Veri Yok");
                cboxUnvan.Enabled = false;
            }
            cboxUnvan.DataSource = new BindingSource(cboxSource, null);
            cboxUnvan.DisplayMember = "Value";
            cboxUnvan.ValueMember = "Key";
            cboxUnvan.Enabled = true;
            cboxUnvan.SelectedIndex = -1;
            db.Kapat();
        }
        public static void DoldurIl(ref ComboBox cboxIl)
        {
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            Database db = new Database();
            var data = db.DataOku("select * from il");

            while (data.Read())
                cboxSource.Add(Convert.ToInt32(data["ilno"]), data["iladi"].ToString());
            if (cboxSource.Count == 0)
            {
                cboxSource.Add(-1, "Veri Yok");
                cboxIl.Enabled = false;
            }
            cboxIl.DataSource = new BindingSource(cboxSource, null);
            cboxIl.DisplayMember = "Value";
            cboxIl.ValueMember = "Key";
            cboxIl.Enabled = true;
            cboxIl.SelectedIndex = -1;
            db.Kapat();
        }
        public static void DoldurIlKopyala(ref ComboBox cbox, ComboBox cboxIl)
        {
            cbox.DataSource = new BindingSource(cboxIl.DataSource, null);
            cbox.DisplayMember = "Value";
            cbox.ValueMember = "Key";
            cbox.SelectedIndex = -1;
            cbox.Enabled = true;
        }
        public static void DoldurUyelikTipi(ref ComboBox cboxUyelikTipi)
        {
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            Database db = new Database();
            var data = db.DataOku("select * from uyeliktipi");

            while (data.Read())
                cboxSource.Add(Convert.ToInt32(data["uyeliktipno"]), data["uyeliktipadi"].ToString());
            if (cboxSource.Count == 0)
            {
                cboxSource.Add(-1, "Veri Yok");
                cboxUyelikTipi.Enabled = false;
            }
            cboxUyelikTipi.DataSource = new BindingSource(cboxSource, null);
            cboxUyelikTipi.DisplayMember = "Value";
            cboxUyelikTipi.ValueMember = "Key";
            cboxUyelikTipi.Enabled = true;
            cboxUyelikTipi.SelectedIndex = -1;
            db.Kapat();
        }
        public static void DoldurKanGrubu(ref ComboBox cboxKanGrubu)
        {
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            Database db = new Database();
            var data = db.DataOku("select * from kangrubu");

            while (data.Read())
                cboxSource.Add(Convert.ToInt32(data["kangrubuno"]), data["kangrubu"].ToString());
            if (cboxSource.Count == 0)
            {
                cboxSource.Add(-1, "Veri Yok");
                cboxKanGrubu.Enabled = false;
            }
            cboxKanGrubu.DataSource = new BindingSource(cboxSource, null);
            cboxKanGrubu.DisplayMember = "Value";
            cboxKanGrubu.ValueMember = "Key";
            cboxKanGrubu.Enabled = true;
            cboxKanGrubu.SelectedIndex = -1;
            db.Kapat();
        }
        public static void DoldurSilinmeNedeni(ref ComboBox cboxSilinmeNedeni)
        {
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            Database db = new Database();
            var data = db.DataOku("select * from silinmenedeni");

            while (data.Read())
                cboxSource.Add(Convert.ToInt32(data["silinmenedenno"]), data["silinmenedeni"].ToString());
            if (cboxSource.Count == 0)
            {
                cboxSource.Add(-1, "Veri Yok");
                cboxSilinmeNedeni.Enabled = false;
            }
            cboxSilinmeNedeni.DataSource = new BindingSource(cboxSource, null);
            cboxSilinmeNedeni.DisplayMember = "Value";
            cboxSilinmeNedeni.ValueMember = "Key";
            cboxSilinmeNedeni.Enabled = true;
            cboxSilinmeNedeni.SelectedIndex = -1;
            db.Kapat();
        }
        public static void DoldurMudurluk(ref ComboBox cboxMudurluk, string ilNo)
        {
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            if (ilNo != string.Empty)
            {
                Database db = new Database();
                var data = db.DataOku("select * from mudurluk where ilno=@0", ilNo);

                while (data.Read())
                    cboxSource.Add(Convert.ToInt32(data["mudurlukno"]), data["mudurlukadi"].ToString());
                if (cboxSource.Count == 0)
                {
                    cboxSource.Add(-1, "Veri Yok");
                    cboxMudurluk.Enabled = false;
                }
                db.Kapat();
            }
            else
            {
                cboxSource.Add(-2, "İlk önce il seçin");
                cboxMudurluk.Enabled = false;
            }
            cboxMudurluk.DataSource = new BindingSource(cboxSource, null);
            cboxMudurluk.DisplayMember = "Value";
            cboxMudurluk.ValueMember = "Key";
            cboxMudurluk.Enabled = true;
            cboxMudurluk.SelectedIndex = -1;
        }
        public static void DoldurBirim(ref ComboBox cboxBirim, string mudurlukNo)
        {
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            if (mudurlukNo != string.Empty)
            {
                Database db = new Database();
                var data = db.DataOku("select * from birim where mudurlukno=@0", mudurlukNo);

                while (data.Read())
                    cboxSource.Add(Convert.ToInt32(data["birimno"]), data["birimadi"].ToString());
                if (cboxSource.Count == 0)
                {
                    cboxSource.Add(-1, "Veri Yok");
                    cboxBirim.Enabled = false;
                }
                db.Kapat();
            }
            else
            {
                cboxSource.Add(-2, "İlk önce il seçin");
                cboxBirim.Enabled = false;
            }
            cboxBirim.DataSource = new BindingSource(cboxSource, null);
            cboxBirim.DisplayMember = "Value";
            cboxBirim.ValueMember = "Key";
            cboxBirim.Enabled = true;
            cboxBirim.SelectedIndex = -1;
        }
        public static object cboxIndexBul(ref ComboBox cbox, object key)
        {
            int key1 = Convert.ToInt32(key);
            foreach (object item in cbox.Items)
            {
                if (((KeyValuePair<int, string>)item).Key == key1)
                {
                    return item;
                }
            }
            return null;
        }
        public static int cboxKeyGetir(ref ComboBox cbox)
        {
            if (cbox.SelectedIndex != -1)
            {
                return ((KeyValuePair<int, string>)cbox.SelectedItem).Key;
            }
            return -1;
        }
    }
}
