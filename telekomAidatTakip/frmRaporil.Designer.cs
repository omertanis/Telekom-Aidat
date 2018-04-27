namespace telekomAidatTakip
{
    partial class frmRaporIl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRaporIl));
            this.listIl = new System.Windows.Forms.ListView();
            this.listIlNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listİlAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListAktif = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListPasif = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListToplam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listIl
            // 
            this.listIl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listIl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listIlNo,
            this.listİlAdi,
            this.ListAktif,
            this.ListPasif,
            this.ListToplam});
            this.listIl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listIl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listIl.FullRowSelect = true;
            this.listIl.Location = new System.Drawing.Point(20, 117);
            this.listIl.Name = "listIl";
            this.listIl.Size = new System.Drawing.Size(446, 261);
            this.listIl.TabIndex = 0;
            this.listIl.UseCompatibleStateImageBehavior = false;
            this.listIl.UseWaitCursor = true;
            this.listIl.View = System.Windows.Forms.View.Details;
            this.listIl.SelectedIndexChanged += new System.EventHandler(this.listIl_SelectedIndexChanged);
            this.listIl.DoubleClick += new System.EventHandler(this.listIl_DoubleClick);
            // 
            // listIlNo
            // 
            this.listIlNo.Text = "İl No";
            this.listIlNo.Width = 91;
            // 
            // listİlAdi
            // 
            this.listİlAdi.Text = "İl";
            this.listİlAdi.Width = 76;
            // 
            // ListAktif
            // 
            this.ListAktif.Text = "Aktif";
            this.ListAktif.Width = 87;
            // 
            // ListPasif
            // 
            this.ListPasif.Text = "Pasif";
            this.ListPasif.Width = 90;
            // 
            // ListToplam
            // 
            this.ListToplam.Text = "Toplam";
            this.ListToplam.Width = 98;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(182, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "İllere Göre Üye Dağılım Listesi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
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
            this.btnYazdir.Location = new System.Drawing.Point(418, 66);
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
            this.btnListele.Location = new System.Drawing.Point(370, 66);
            this.btnListele.Margin = new System.Windows.Forms.Padding(0);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(48, 48);
            this.btnListele.TabIndex = 51;
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnEkranaListele_Click);
            // 
            // frmRaporIl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 398);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listIl);
            this.Controls.Add(this.metroLabel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRaporIl";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "       İl Raporları";
            this.Load += new System.EventHandler(this.frmRaporIl_Load);
            this.Resize += new System.EventHandler(this.frmRaporIl_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listIl;
        private System.Windows.Forms.ColumnHeader ListAktif;
        private System.Windows.Forms.ColumnHeader ListPasif;
        private System.Windows.Forms.ColumnHeader ListToplam;
        private System.Windows.Forms.ColumnHeader listIlNo;
        private System.Windows.Forms.ColumnHeader listİlAdi;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnListele;
    }
}