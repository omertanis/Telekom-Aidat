namespace telekomAidatTakip
{
    partial class frmTanimBirim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTanimBirim));
            this.cBoxMudurluk = new MetroFramework.Controls.MetroComboBox();
            this.txtBirimKodu = new MetroFramework.Controls.MetroTextBox();
            this.txtBirimAdi = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.listBirim = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cBoxMudurluk
            // 
            this.cBoxMudurluk.Enabled = false;
            this.cBoxMudurluk.FormattingEnabled = true;
            this.cBoxMudurluk.ItemHeight = 24;
            this.cBoxMudurluk.Location = new System.Drawing.Point(157, 137);
            this.cBoxMudurluk.Name = "cBoxMudurluk";
            this.cBoxMudurluk.PromptText = "-";
            this.cBoxMudurluk.Size = new System.Drawing.Size(279, 30);
            this.cBoxMudurluk.TabIndex = 2;
            this.cBoxMudurluk.UseSelectable = true;
            // 
            // txtBirimKodu
            // 
            // 
            // 
            // 
            this.txtBirimKodu.CustomButton.Image = null;
            this.txtBirimKodu.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.txtBirimKodu.CustomButton.Name = "";
            this.txtBirimKodu.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtBirimKodu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBirimKodu.CustomButton.TabIndex = 1;
            this.txtBirimKodu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBirimKodu.CustomButton.UseSelectable = true;
            this.txtBirimKodu.CustomButton.Visible = false;
            this.txtBirimKodu.Enabled = false;
            this.txtBirimKodu.Lines = new string[0];
            this.txtBirimKodu.Location = new System.Drawing.Point(157, 67);
            this.txtBirimKodu.MaxLength = 32767;
            this.txtBirimKodu.Name = "txtBirimKodu";
            this.txtBirimKodu.PasswordChar = '\0';
            this.txtBirimKodu.PromptText = "Birim no giriniz.";
            this.txtBirimKodu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBirimKodu.SelectedText = "";
            this.txtBirimKodu.SelectionLength = 0;
            this.txtBirimKodu.SelectionStart = 0;
            this.txtBirimKodu.ShortcutsEnabled = true;
            this.txtBirimKodu.Size = new System.Drawing.Size(161, 29);
            this.txtBirimKodu.TabIndex = 0;
            this.txtBirimKodu.UseSelectable = true;
            this.txtBirimKodu.WaterMark = "Birim no giriniz.";
            this.txtBirimKodu.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBirimKodu.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBirimKodu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBirimKodu_KeyPress);
            // 
            // txtBirimAdi
            // 
            // 
            // 
            // 
            this.txtBirimAdi.CustomButton.Image = null;
            this.txtBirimAdi.CustomButton.Location = new System.Drawing.Point(252, 1);
            this.txtBirimAdi.CustomButton.Name = "";
            this.txtBirimAdi.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtBirimAdi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBirimAdi.CustomButton.TabIndex = 1;
            this.txtBirimAdi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBirimAdi.CustomButton.UseSelectable = true;
            this.txtBirimAdi.CustomButton.Visible = false;
            this.txtBirimAdi.Enabled = false;
            this.txtBirimAdi.Lines = new string[0];
            this.txtBirimAdi.Location = new System.Drawing.Point(157, 102);
            this.txtBirimAdi.MaxLength = 32767;
            this.txtBirimAdi.Name = "txtBirimAdi";
            this.txtBirimAdi.PasswordChar = '\0';
            this.txtBirimAdi.PromptText = "Birim adı giriniz.";
            this.txtBirimAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBirimAdi.SelectedText = "";
            this.txtBirimAdi.SelectionLength = 0;
            this.txtBirimAdi.SelectionStart = 0;
            this.txtBirimAdi.ShortcutsEnabled = true;
            this.txtBirimAdi.Size = new System.Drawing.Size(280, 29);
            this.txtBirimAdi.TabIndex = 1;
            this.txtBirimAdi.UseSelectable = true;
            this.txtBirimAdi.WaterMark = "Birim adı giriniz.";
            this.txtBirimAdi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBirimAdi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(73, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 20);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Birim No:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(73, 107);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(43, 20);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Birim:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(73, 142);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(71, 20);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Müdürlük:";
            // 
            // listBirim
            // 
            this.listBirim.AllowColumnReorder = true;
            this.listBirim.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listBirim.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBirim.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listBirim.FullRowSelect = true;
            this.listBirim.GridLines = true;
            this.listBirim.Location = new System.Drawing.Point(20, 230);
            this.listBirim.MultiSelect = false;
            this.listBirim.Name = "listBirim";
            this.listBirim.Size = new System.Drawing.Size(472, 214);
            this.listBirim.TabIndex = 6;
            this.listBirim.UseCompatibleStateImageBehavior = false;
            this.listBirim.View = System.Windows.Forms.View.Details;
            this.listBirim.DoubleClick += new System.EventHandler(this.listvil_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Birim No";
            this.columnHeader1.Width = 65;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Birim";
            this.columnHeader2.Width = 136;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Müdürlük No";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Müdürlük";
            this.columnHeader4.Width = 155;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(15, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.White;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSil.Enabled = false;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Image = global::telekomAidatTakip.Properties.Resources.if_icons_exit_1564505;
            this.btnSil.Location = new System.Drawing.Point(389, 172);
            this.btnSil.Margin = new System.Windows.Forms.Padding(0);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(48, 48);
            this.btnSil.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnSil, "Sil");
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.White;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKaydet.Enabled = false;
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Image = global::telekomAidatTakip.Properties.Resources.if_icons_check_1564499;
            this.btnKaydet.Location = new System.Drawing.Point(335, 173);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(0);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(48, 48);
            this.btnKaydet.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnKaydet, "Kaydet");
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.BackColor = System.Drawing.Color.White;
            this.btnYeni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnYeni.FlatAppearance.BorderSize = 0;
            this.btnYeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeni.Image = global::telekomAidatTakip.Properties.Resources.if_ic_control_point_48px_352288;
            this.btnYeni.Location = new System.Drawing.Point(281, 173);
            this.btnYeni.Margin = new System.Windows.Forms.Padding(0);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(48, 48);
            this.btnYeni.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnYeni, "Yeni Kayıt");
            this.btnYeni.UseVisualStyleBackColor = false;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // frmTanimBirim
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(512, 464);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.listBirim);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cBoxMudurluk);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtBirimKodu);
            this.Controls.Add(this.txtBirimAdi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTanimBirim";
            this.Text = "       Birim Tanımlama";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.frmTanimBirim_Load);
            this.Resize += new System.EventHandler(this.frmTanimBirim_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtBirimAdi;
        private MetroFramework.Controls.MetroTextBox txtBirimKodu;
        private MetroFramework.Controls.MetroComboBox cBoxMudurluk;
        private System.Windows.Forms.ListView listBirim;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnYeni;
    }
}