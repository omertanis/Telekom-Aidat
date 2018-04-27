namespace telekomAidatTakip
{
    partial class frmRaporUye
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRaporUye));
            this.listUye = new System.Windows.Forms.ListView();
            this.ListKurumSicil = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListAdSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListKanGrubu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListIlMudurlukKısım = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListUnvan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListTahsil = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkIl = new MetroFramework.Controls.MetroCheckBox();
            this.cboxIl = new MetroFramework.Controls.MetroComboBox();
            this.checkMudurluk = new MetroFramework.Controls.MetroCheckBox();
            this.cboxMudurluk = new MetroFramework.Controls.MetroComboBox();
            this.checkBirim = new MetroFramework.Controls.MetroCheckBox();
            this.cboxBirim = new MetroFramework.Controls.MetroComboBox();
            this.checkUnvan = new MetroFramework.Controls.MetroCheckBox();
            this.cboxUnvan = new MetroFramework.Controls.MetroComboBox();
            this.checkUyelik = new MetroFramework.Controls.MetroCheckBox();
            this.cboxUyelikDurumu = new MetroFramework.Controls.MetroComboBox();
            this.checkTahsil = new MetroFramework.Controls.MetroCheckBox();
            this.checkKanGrubu = new MetroFramework.Controls.MetroCheckBox();
            this.cboxTahsil = new MetroFramework.Controls.MetroComboBox();
            this.cboxKanGrubu = new MetroFramework.Controls.MetroComboBox();
            this.radioAktif = new MetroFramework.Controls.MetroRadioButton();
            this.radioPasif = new MetroFramework.Controls.MetroRadioButton();
            this.radioHepsi = new MetroFramework.Controls.MetroRadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listUye
            // 
            this.listUye.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ListKurumSicil,
            this.ListAdSoyad,
            this.ListKanGrubu,
            this.ListIlMudurlukKısım,
            this.ListUnvan,
            this.ListTahsil});
            this.listUye.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listUye.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listUye.FullRowSelect = true;
            this.listUye.Location = new System.Drawing.Point(20, 346);
            this.listUye.Name = "listUye";
            this.listUye.Size = new System.Drawing.Size(689, 208);
            this.listUye.TabIndex = 0;
            this.listUye.UseCompatibleStateImageBehavior = false;
            this.listUye.View = System.Windows.Forms.View.Details;
            this.listUye.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listUye_MouseDoubleClick);
            // 
            // ListKurumSicil
            // 
            this.ListKurumSicil.Text = "Sicil No";
            this.ListKurumSicil.Width = 78;
            // 
            // ListAdSoyad
            // 
            this.ListAdSoyad.Text = "Ad Soyad";
            this.ListAdSoyad.Width = 141;
            // 
            // ListKanGrubu
            // 
            this.ListKanGrubu.Text = "Kan Grubu";
            this.ListKanGrubu.Width = 67;
            // 
            // ListIlMudurlukKısım
            // 
            this.ListIlMudurlukKısım.Text = "İl/Müdürlük/Kısım";
            this.ListIlMudurlukKısım.Width = 169;
            // 
            // ListUnvan
            // 
            this.ListUnvan.Text = "Ünvan";
            this.ListUnvan.Width = 103;
            // 
            // ListTahsil
            // 
            this.ListTahsil.Text = "Tahsil";
            this.ListTahsil.Width = 106;
            // 
            // checkIl
            // 
            this.checkIl.AutoSize = true;
            this.checkIl.Location = new System.Drawing.Point(23, 70);
            this.checkIl.Name = "checkIl";
            this.checkIl.Size = new System.Drawing.Size(32, 15);
            this.checkIl.TabIndex = 2;
            this.checkIl.Text = "İl:";
            this.checkIl.UseSelectable = true;
            this.checkIl.CheckedChanged += new System.EventHandler(this.checkIl_CheckedChanged);
            // 
            // cboxIl
            // 
            this.cboxIl.Enabled = false;
            this.cboxIl.FormattingEnabled = true;
            this.cboxIl.ItemHeight = 23;
            this.cboxIl.Location = new System.Drawing.Point(169, 63);
            this.cboxIl.Name = "cboxIl";
            this.cboxIl.Size = new System.Drawing.Size(244, 29);
            this.cboxIl.TabIndex = 3;
            this.cboxIl.UseSelectable = true;
            this.cboxIl.SelectedIndexChanged += new System.EventHandler(this.cboxII_SelectedIndexChanged);
            this.cboxIl.SelectionChangeCommitted += new System.EventHandler(this.cboxII_SelectionChangeCommitted);
            // 
            // checkMudurluk
            // 
            this.checkMudurluk.AutoSize = true;
            this.checkMudurluk.Enabled = false;
            this.checkMudurluk.Location = new System.Drawing.Point(23, 105);
            this.checkMudurluk.Name = "checkMudurluk";
            this.checkMudurluk.Size = new System.Drawing.Size(78, 15);
            this.checkMudurluk.TabIndex = 2;
            this.checkMudurluk.Text = "Müdürlük:";
            this.checkMudurluk.UseSelectable = true;
            this.checkMudurluk.CheckedChanged += new System.EventHandler(this.checkMudurluk_CheckedChanged);
            // 
            // cboxMudurluk
            // 
            this.cboxMudurluk.Enabled = false;
            this.cboxMudurluk.FormattingEnabled = true;
            this.cboxMudurluk.ItemHeight = 23;
            this.cboxMudurluk.Location = new System.Drawing.Point(169, 98);
            this.cboxMudurluk.Name = "cboxMudurluk";
            this.cboxMudurluk.Size = new System.Drawing.Size(244, 29);
            this.cboxMudurluk.TabIndex = 3;
            this.cboxMudurluk.UseSelectable = true;
            this.cboxMudurluk.SelectionChangeCommitted += new System.EventHandler(this.cboxMudurluk_SelectionChangeCommitted);
            // 
            // checkBirim
            // 
            this.checkBirim.AutoSize = true;
            this.checkBirim.Enabled = false;
            this.checkBirim.Location = new System.Drawing.Point(23, 140);
            this.checkBirim.Name = "checkBirim";
            this.checkBirim.Size = new System.Drawing.Size(54, 15);
            this.checkBirim.TabIndex = 2;
            this.checkBirim.Text = "Birim:";
            this.checkBirim.UseSelectable = true;
            this.checkBirim.CheckedChanged += new System.EventHandler(this.checkBirim_CheckedChanged);
            // 
            // cboxBirim
            // 
            this.cboxBirim.Enabled = false;
            this.cboxBirim.FormattingEnabled = true;
            this.cboxBirim.ItemHeight = 23;
            this.cboxBirim.Location = new System.Drawing.Point(169, 133);
            this.cboxBirim.Name = "cboxBirim";
            this.cboxBirim.Size = new System.Drawing.Size(244, 29);
            this.cboxBirim.TabIndex = 3;
            this.cboxBirim.UseSelectable = true;
            // 
            // checkUnvan
            // 
            this.checkUnvan.AutoSize = true;
            this.checkUnvan.Location = new System.Drawing.Point(23, 175);
            this.checkUnvan.Name = "checkUnvan";
            this.checkUnvan.Size = new System.Drawing.Size(60, 15);
            this.checkUnvan.TabIndex = 2;
            this.checkUnvan.Text = "Ünvan:";
            this.checkUnvan.UseSelectable = true;
            this.checkUnvan.CheckedChanged += new System.EventHandler(this.checkUnvan_CheckedChanged);
            // 
            // cboxUnvan
            // 
            this.cboxUnvan.Enabled = false;
            this.cboxUnvan.FormattingEnabled = true;
            this.cboxUnvan.ItemHeight = 23;
            this.cboxUnvan.Location = new System.Drawing.Point(169, 168);
            this.cboxUnvan.Name = "cboxUnvan";
            this.cboxUnvan.Size = new System.Drawing.Size(244, 29);
            this.cboxUnvan.TabIndex = 3;
            this.cboxUnvan.UseSelectable = true;
            // 
            // checkUyelik
            // 
            this.checkUyelik.AutoSize = true;
            this.checkUyelik.Location = new System.Drawing.Point(23, 245);
            this.checkUyelik.Name = "checkUyelik";
            this.checkUyelik.Size = new System.Drawing.Size(81, 15);
            this.checkUyelik.TabIndex = 2;
            this.checkUyelik.Text = "Üyelik Tipi:";
            this.checkUyelik.UseSelectable = true;
            this.checkUyelik.CheckedChanged += new System.EventHandler(this.checkUyelik_CheckedChanged);
            // 
            // cboxUyelikDurumu
            // 
            this.cboxUyelikDurumu.Enabled = false;
            this.cboxUyelikDurumu.FormattingEnabled = true;
            this.cboxUyelikDurumu.ItemHeight = 23;
            this.cboxUyelikDurumu.Location = new System.Drawing.Point(169, 238);
            this.cboxUyelikDurumu.Name = "cboxUyelikDurumu";
            this.cboxUyelikDurumu.Size = new System.Drawing.Size(244, 29);
            this.cboxUyelikDurumu.TabIndex = 3;
            this.cboxUyelikDurumu.UseSelectable = true;
            // 
            // checkTahsil
            // 
            this.checkTahsil.AutoSize = true;
            this.checkTahsil.Location = new System.Drawing.Point(23, 210);
            this.checkTahsil.Name = "checkTahsil";
            this.checkTahsil.Size = new System.Drawing.Size(56, 15);
            this.checkTahsil.TabIndex = 2;
            this.checkTahsil.Text = "Tahsil:";
            this.checkTahsil.UseSelectable = true;
            this.checkTahsil.CheckedChanged += new System.EventHandler(this.checkTahsil_CheckedChanged);
            // 
            // checkKanGrubu
            // 
            this.checkKanGrubu.AutoSize = true;
            this.checkKanGrubu.Location = new System.Drawing.Point(23, 280);
            this.checkKanGrubu.Name = "checkKanGrubu";
            this.checkKanGrubu.Size = new System.Drawing.Size(82, 15);
            this.checkKanGrubu.TabIndex = 2;
            this.checkKanGrubu.Text = "Kan Grubu:";
            this.checkKanGrubu.UseSelectable = true;
            this.checkKanGrubu.CheckedChanged += new System.EventHandler(this.checkKanGrubu_CheckedChanged);
            // 
            // cboxTahsil
            // 
            this.cboxTahsil.Enabled = false;
            this.cboxTahsil.FormattingEnabled = true;
            this.cboxTahsil.ItemHeight = 23;
            this.cboxTahsil.Location = new System.Drawing.Point(169, 203);
            this.cboxTahsil.Name = "cboxTahsil";
            this.cboxTahsil.Size = new System.Drawing.Size(244, 29);
            this.cboxTahsil.TabIndex = 3;
            this.cboxTahsil.UseSelectable = true;
            // 
            // cboxKanGrubu
            // 
            this.cboxKanGrubu.Enabled = false;
            this.cboxKanGrubu.FormattingEnabled = true;
            this.cboxKanGrubu.ItemHeight = 23;
            this.cboxKanGrubu.Location = new System.Drawing.Point(169, 273);
            this.cboxKanGrubu.Name = "cboxKanGrubu";
            this.cboxKanGrubu.Size = new System.Drawing.Size(244, 29);
            this.cboxKanGrubu.TabIndex = 3;
            this.cboxKanGrubu.UseSelectable = true;
            // 
            // radioAktif
            // 
            this.radioAktif.AutoSize = true;
            this.radioAktif.Checked = true;
            this.radioAktif.Location = new System.Drawing.Point(23, 316);
            this.radioAktif.Name = "radioAktif";
            this.radioAktif.Size = new System.Drawing.Size(84, 15);
            this.radioAktif.TabIndex = 4;
            this.radioAktif.TabStop = true;
            this.radioAktif.Text = "Aktif Üyeler";
            this.radioAktif.UseSelectable = true;
            // 
            // radioPasif
            // 
            this.radioPasif.AutoSize = true;
            this.radioPasif.Location = new System.Drawing.Point(113, 316);
            this.radioPasif.Name = "radioPasif";
            this.radioPasif.Size = new System.Drawing.Size(84, 15);
            this.radioPasif.TabIndex = 4;
            this.radioPasif.Text = "Pasif Üyeler";
            this.radioPasif.UseSelectable = true;
            // 
            // radioHepsi
            // 
            this.radioHepsi.AutoSize = true;
            this.radioHepsi.Location = new System.Drawing.Point(203, 316);
            this.radioHepsi.Name = "radioHepsi";
            this.radioHepsi.Size = new System.Drawing.Size(84, 15);
            this.radioHepsi.TabIndex = 4;
            this.radioHepsi.Text = "Tüm Üyeler";
            this.radioHepsi.UseSelectable = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // btnYazdir
            // 
            this.btnYazdir.BackColor = System.Drawing.Color.White;
            this.btnYazdir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnYazdir.Enabled = false;
            this.btnYazdir.FlatAppearance.BorderSize = 0;
            this.btnYazdir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYazdir.Image = global::telekomAidatTakip.Properties.Resources.if_ic_local_print_shop_48px_352513;
            this.btnYazdir.Location = new System.Drawing.Point(661, 295);
            this.btnYazdir.Margin = new System.Windows.Forms.Padding(0);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(48, 48);
            this.btnYazdir.TabIndex = 50;
            this.btnYazdir.UseVisualStyleBackColor = false;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.White;
            this.btnListele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnListele.FlatAppearance.BorderSize = 0;
            this.btnListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListele.Image = global::telekomAidatTakip.Properties.Resources.if_icons_search_1564527;
            this.btnListele.Location = new System.Drawing.Point(613, 295);
            this.btnListele.Margin = new System.Windows.Forms.Padding(0);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(48, 48);
            this.btnListele.TabIndex = 51;
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnEkranaListele_Click);
            // 
            // frmRaporUye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 574);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listUye);
            this.Controls.Add(this.radioHepsi);
            this.Controls.Add(this.radioPasif);
            this.Controls.Add(this.radioAktif);
            this.Controls.Add(this.cboxKanGrubu);
            this.Controls.Add(this.cboxUnvan);
            this.Controls.Add(this.cboxTahsil);
            this.Controls.Add(this.checkKanGrubu);
            this.Controls.Add(this.cboxMudurluk);
            this.Controls.Add(this.checkTahsil);
            this.Controls.Add(this.checkUnvan);
            this.Controls.Add(this.cboxUyelikDurumu);
            this.Controls.Add(this.checkMudurluk);
            this.Controls.Add(this.checkUyelik);
            this.Controls.Add(this.cboxBirim);
            this.Controls.Add(this.checkBirim);
            this.Controls.Add(this.cboxIl);
            this.Controls.Add(this.checkIl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRaporUye";
            this.Text = "       Üye Raporu";
            this.Load += new System.EventHandler(this.frmRaporUye_Load);
            this.Resize += new System.EventHandler(this.frmRaporUye_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listUye;
        private System.Windows.Forms.ColumnHeader ListAdSoyad;
        private System.Windows.Forms.ColumnHeader ListKurumSicil;
        private System.Windows.Forms.ColumnHeader ListKanGrubu;
        private System.Windows.Forms.ColumnHeader ListIlMudurlukKısım;
        private System.Windows.Forms.ColumnHeader ListUnvan;
        private System.Windows.Forms.ColumnHeader ListTahsil;
        private MetroFramework.Controls.MetroCheckBox checkIl;
        private MetroFramework.Controls.MetroComboBox cboxIl;
        private MetroFramework.Controls.MetroCheckBox checkMudurluk;
        private MetroFramework.Controls.MetroComboBox cboxMudurluk;
        private MetroFramework.Controls.MetroCheckBox checkBirim;
        private MetroFramework.Controls.MetroComboBox cboxBirim;
        private MetroFramework.Controls.MetroCheckBox checkUnvan;
        private MetroFramework.Controls.MetroComboBox cboxUnvan;
        private MetroFramework.Controls.MetroCheckBox checkUyelik;
        private MetroFramework.Controls.MetroComboBox cboxUyelikDurumu;
        private MetroFramework.Controls.MetroCheckBox checkTahsil;
        private MetroFramework.Controls.MetroCheckBox checkKanGrubu;
        private MetroFramework.Controls.MetroComboBox cboxTahsil;
        private MetroFramework.Controls.MetroComboBox cboxKanGrubu;
        private MetroFramework.Controls.MetroRadioButton radioAktif;
        private MetroFramework.Controls.MetroRadioButton radioPasif;
        private MetroFramework.Controls.MetroRadioButton radioHepsi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnListele;
    }
}