using MetroFramework.Forms;
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
    public partial class frmUyeSil : MetroForm
    {
        string sicilno;
        public frmUyeSil(string sicilno)
        {
            this.sicilno = sicilno;
            InitializeComponent();
        }

        private void frmUyeSil_Load(object sender, EventArgs e)
        {
            try
            {

                this.MaximumSize = this.Size;
                this.MinimumSize = this.Size;
                PRG.DoldurSilinmeNedeni(ref comboBox1);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.BeginInvoke(new MethodInvoker(Close));
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                Database db = new Database();
                db.Sorgu("update uyeler set aktif = 0, silinmenedenino=@0 where sicilno=@1", PRG.cboxKeyGetir(ref comboBox1), sicilno);
                db.Kapat();
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
