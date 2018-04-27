namespace telekomAidatTakip
{
    partial class frmRaporAidat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRaporAidat));
            this.checkBirim = new MetroFramework.Controls.MetroCheckBox();
            this.checkMudurluk = new MetroFramework.Controls.MetroCheckBox();
            this.checkIl = new MetroFramework.Controls.MetroCheckBox();
            this.cboxBirim = new MetroFramework.Controls.MetroComboBox();
            this.cboxMudurluk = new MetroFramework.Controls.MetroComboBox();
            this.cboxil = new MetroFramework.Controls.MetroComboBox();
            this.listUyeKayitlari = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBirim
            // 
            this.checkBirim.AutoSize = true;
            this.checkBirim.Location = new System.Drawing.Point(22, 141);
            this.checkBirim.Margin = new System.Windows.Forms.Padding(2);
            this.checkBirim.Name = "checkBirim";
            this.checkBirim.Size = new System.Drawing.Size(54, 15);
            this.checkBirim.TabIndex = 19;
            this.checkBirim.Text = "Birim:";
            this.checkBirim.UseSelectable = true;
            this.checkBirim.CheckedChanged += new System.EventHandler(this.checkBirim_CheckedChanged);
            // 
            // checkMudurluk
            // 
            this.checkMudurluk.AutoSize = true;
            this.checkMudurluk.Location = new System.Drawing.Point(22, 108);
            this.checkMudurluk.Margin = new System.Windows.Forms.Padding(2);
            this.checkMudurluk.Name = "checkMudurluk";
            this.checkMudurluk.Size = new System.Drawing.Size(78, 15);
            this.checkMudurluk.TabIndex = 18;
            this.checkMudurluk.Text = "Müdürlük:";
            this.checkMudurluk.UseSelectable = true;
            this.checkMudurluk.CheckedChanged += new System.EventHandler(this.checkMudurluk_CheckedChanged);
            // 
            // checkIl
            // 
            this.checkIl.AutoSize = true;
            this.checkIl.Location = new System.Drawing.Point(22, 75);
            this.checkIl.Margin = new System.Windows.Forms.Padding(2);
            this.checkIl.Name = "checkIl";
            this.checkIl.Size = new System.Drawing.Size(32, 15);
            this.checkIl.TabIndex = 17;
            this.checkIl.Text = "İl:";
            this.checkIl.UseSelectable = true;
            this.checkIl.CheckedChanged += new System.EventHandler(this.checkIl_CheckedChanged);
            // 
            // cboxBirim
            // 
            this.cboxBirim.FormattingEnabled = true;
            this.cboxBirim.ItemHeight = 23;
            this.cboxBirim.Location = new System.Drawing.Point(152, 132);
            this.cboxBirim.Margin = new System.Windows.Forms.Padding(2);
            this.cboxBirim.Name = "cboxBirim";
            this.cboxBirim.Size = new System.Drawing.Size(214, 29);
            this.cboxBirim.TabIndex = 16;
            this.cboxBirim.UseSelectable = true;
            // 
            // cboxMudurluk
            // 
            this.cboxMudurluk.FormattingEnabled = true;
            this.cboxMudurluk.ItemHeight = 23;
            this.cboxMudurluk.Location = new System.Drawing.Point(152, 99);
            this.cboxMudurluk.Margin = new System.Windows.Forms.Padding(2);
            this.cboxMudurluk.Name = "cboxMudurluk";
            this.cboxMudurluk.Size = new System.Drawing.Size(214, 29);
            this.cboxMudurluk.TabIndex = 15;
            this.cboxMudurluk.UseSelectable = true;
            this.cboxMudurluk.SelectionChangeCommitted += new System.EventHandler(this.cboxMudurluk_SelectionChangeCommitted);
            // 
            // cboxil
            // 
            this.cboxil.ItemHeight = 23;
            this.cboxil.Location = new System.Drawing.Point(152, 66);
            this.cboxil.Margin = new System.Windows.Forms.Padding(2);
            this.cboxil.Name = "cboxil";
            this.cboxil.Size = new System.Drawing.Size(214, 29);
            this.cboxil.TabIndex = 0;
            this.cboxil.UseSelectable = true;
            this.cboxil.SelectedIndexChanged += new System.EventHandler(this.cboxil_SelectedIndexChanged);
            this.cboxil.SelectionChangeCommitted += new System.EventHandler(this.cboxil_SelectionChangeCommitted);
            // 
            // listUyeKayitlari
            // 
            this.listUyeKayitlari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listUyeKayitlari.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listUyeKayitlari.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listUyeKayitlari.FullRowSelect = true;
            this.listUyeKayitlari.Location = new System.Drawing.Point(15, 225);
            this.listUyeKayitlari.Name = "listUyeKayitlari";
            this.listUyeKayitlari.Size = new System.Drawing.Size(645, 213);
            this.listUyeKayitlari.TabIndex = 0;
            this.listUyeKayitlari.UseCompatibleStateImageBehavior = false;
            this.listUyeKayitlari.View = System.Windows.Forms.View.Details;
            this.listUyeKayitlari.DoubleClick += new System.EventHandler(this.listUyeKayitlari_DoubleClick);
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "Sicil No";
            this.columnHeader0.Width = 88;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad Soyad";
            this.columnHeader1.Width = 106;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Aidat";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Genel Toplamı";
            this.columnHeader5.Width = 123;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "İl";
            this.columnHeader6.Width = 71;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Müdürlük";
            this.columnHeader7.Width = 103;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Birim";
            this.columnHeader8.Width = 100;
            // 
            // btnYazdir
            // 
            this.btnYazdir.BackColor = System.Drawing.Color.White;
            this.btnYazdir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnYazdir.Enabled = false;
            this.btnYazdir.FlatAppearance.BorderSize = 0;
            this.btnYazdir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYazdir.Image = global::telekomAidatTakip.Properties.Resources.if_ic_local_print_shop_48px_352513;
            this.btnYazdir.Location = new System.Drawing.Point(318, 163);
            this.btnYazdir.Margin = new System.Windows.Forms.Padding(0);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(48, 48);
            this.btnYazdir.TabIndex = 49;
            this.toolTip1.SetToolTip(this.btnYazdir, "Yazdır");
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
            this.btnListele.Location = new System.Drawing.Point(270, 163);
            this.btnListele.Margin = new System.Windows.Forms.Padding(0);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(48, 48);
            this.btnListele.TabIndex = 49;
            this.toolTip1.SetToolTip(this.btnListele, "Ekrana Listele");
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // frmRaporAidat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 454);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listUyeKayitlari);
            this.Controls.Add(this.checkBirim);
            this.Controls.Add(this.cboxil);
            this.Controls.Add(this.checkMudurluk);
            this.Controls.Add(this.cboxMudurluk);
            this.Controls.Add(this.checkIl);
            this.Controls.Add(this.cboxBirim);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRaporAidat";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "       Aidat Raporları";
            this.Load += new System.EventHandler(this.frmRaporAidat_Load);
            this.Resize += new System.EventHandler(this.frmRaporAidat_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox cboxil;
        private MetroFramework.Controls.MetroCheckBox checkMudurluk;
        private MetroFramework.Controls.MetroCheckBox checkIl;
        private MetroFramework.Controls.MetroComboBox cboxBirim;
        private MetroFramework.Controls.MetroComboBox cboxMudurluk;
        private MetroFramework.Controls.MetroCheckBox checkBirim;
        private System.Windows.Forms.ListView listUyeKayitlari;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}