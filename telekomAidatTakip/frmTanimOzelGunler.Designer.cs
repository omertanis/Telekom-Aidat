namespace telekomAidatTakip
{
    partial class frmTanimOzelGunler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTanimOzelGunler));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtGunNo = new MetroFramework.Controls.MetroTextBox();
            this.btnBirim = new MetroFramework.Controls.MetroTile();
            this.btnMudurluk = new MetroFramework.Controls.MetroTile();
            this.btnSehir = new MetroFramework.Controls.MetroTile();
            this.btnSicilNo = new MetroFramework.Controls.MetroTile();
            this.btnAdi = new MetroFramework.Controls.MetroTile();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtBaslik = new MetroFramework.Controls.MetroTextBox();
            this.dateTimeTarih = new MetroFramework.Controls.MetroDateTime();
            this.txtMsj = new MetroFramework.Controls.MetroTextBox();
            this.txtYorum = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(20, 424);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(565, 181);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Özel Gün No";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Mail Başlığı";
            this.columnHeader7.Width = 128;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tarih";
            this.columnHeader8.Width = 86;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Mesaj";
            this.columnHeader9.Width = 168;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Yorum";
            this.columnHeader10.Width = 185;
            // 
            // txtGunNo
            // 
            // 
            // 
            // 
            this.txtGunNo.CustomButton.Image = null;
            this.txtGunNo.CustomButton.Location = new System.Drawing.Point(79, 1);
            this.txtGunNo.CustomButton.Name = "";
            this.txtGunNo.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtGunNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGunNo.CustomButton.TabIndex = 1;
            this.txtGunNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGunNo.CustomButton.UseSelectable = true;
            this.txtGunNo.CustomButton.Visible = false;
            this.txtGunNo.Lines = new string[0];
            this.txtGunNo.Location = new System.Drawing.Point(120, 79);
            this.txtGunNo.MaxLength = 32767;
            this.txtGunNo.Name = "txtGunNo";
            this.txtGunNo.PasswordChar = '\0';
            this.txtGunNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGunNo.SelectedText = "";
            this.txtGunNo.SelectionLength = 0;
            this.txtGunNo.SelectionStart = 0;
            this.txtGunNo.ShortcutsEnabled = true;
            this.txtGunNo.Size = new System.Drawing.Size(107, 29);
            this.txtGunNo.TabIndex = 0;
            this.txtGunNo.UseSelectable = true;
            this.txtGunNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGunNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtGunNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGunNo_KeyPress);
            // 
            // btnBirim
            // 
            this.btnBirim.ActiveControl = null;
            this.btnBirim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBirim.Location = new System.Drawing.Point(502, 261);
            this.btnBirim.Name = "btnBirim";
            this.btnBirim.Size = new System.Drawing.Size(80, 35);
            this.btnBirim.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnBirim.TabIndex = 8;
            this.btnBirim.Text = "Birim";
            this.btnBirim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBirim.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnBirim.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnBirim.UseSelectable = true;
            this.btnBirim.Click += new System.EventHandler(this.btnBirim_Click);
            // 
            // btnMudurluk
            // 
            this.btnMudurluk.ActiveControl = null;
            this.btnMudurluk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnMudurluk.Location = new System.Drawing.Point(502, 215);
            this.btnMudurluk.Name = "btnMudurluk";
            this.btnMudurluk.Size = new System.Drawing.Size(80, 35);
            this.btnMudurluk.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnMudurluk.TabIndex = 7;
            this.btnMudurluk.Text = "Müdürlük";
            this.btnMudurluk.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnMudurluk.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnMudurluk.UseSelectable = true;
            this.btnMudurluk.Click += new System.EventHandler(this.btnMudurluk_Click);
            // 
            // btnSehir
            // 
            this.btnSehir.ActiveControl = null;
            this.btnSehir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSehir.Location = new System.Drawing.Point(502, 170);
            this.btnSehir.Name = "btnSehir";
            this.btnSehir.Size = new System.Drawing.Size(80, 35);
            this.btnSehir.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnSehir.TabIndex = 6;
            this.btnSehir.Text = "Şehir";
            this.btnSehir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSehir.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnSehir.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnSehir.UseSelectable = true;
            this.btnSehir.Click += new System.EventHandler(this.btnSehir_Click);
            // 
            // btnSicilNo
            // 
            this.btnSicilNo.ActiveControl = null;
            this.btnSicilNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSicilNo.Location = new System.Drawing.Point(502, 124);
            this.btnSicilNo.Name = "btnSicilNo";
            this.btnSicilNo.Size = new System.Drawing.Size(80, 35);
            this.btnSicilNo.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnSicilNo.TabIndex = 5;
            this.btnSicilNo.Text = "Sicil No";
            this.btnSicilNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSicilNo.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnSicilNo.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnSicilNo.UseSelectable = true;
            this.btnSicilNo.Click += new System.EventHandler(this.btnSicilNo_Click);
            // 
            // btnAdi
            // 
            this.btnAdi.ActiveControl = null;
            this.btnAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAdi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdi.Location = new System.Drawing.Point(502, 79);
            this.btnAdi.Name = "btnAdi";
            this.btnAdi.Size = new System.Drawing.Size(80, 35);
            this.btnAdi.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAdi.TabIndex = 4;
            this.btnAdi.Text = "Ad Soyad";
            this.btnAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdi.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAdi.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnAdi.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnAdi.UseCustomForeColor = true;
            this.btnAdi.UseSelectable = true;
            this.btnAdi.UseStyleColors = true;
            this.btnAdi.Click += new System.EventHandler(this.btnAdi_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(26, 280);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(51, 19);
            this.metroLabel5.TabIndex = 36;
            this.metroLabel5.Text = "Yorum:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(26, 189);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(46, 19);
            this.metroLabel4.TabIndex = 35;
            this.metroLabel4.Text = "Mesaj:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(26, 154);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(39, 19);
            this.metroLabel3.TabIndex = 34;
            this.metroLabel3.Text = "Tarih:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(26, 119);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(78, 19);
            this.metroLabel2.TabIndex = 33;
            this.metroLabel2.Text = "Mail Başlığı:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(26, 84);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 19);
            this.metroLabel1.TabIndex = 32;
            this.metroLabel1.Text = "Özel Gün No:";
            // 
            // txtBaslik
            // 
            // 
            // 
            // 
            this.txtBaslik.CustomButton.Image = null;
            this.txtBaslik.CustomButton.Location = new System.Drawing.Point(329, 1);
            this.txtBaslik.CustomButton.Name = "";
            this.txtBaslik.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtBaslik.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBaslik.CustomButton.TabIndex = 1;
            this.txtBaslik.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBaslik.CustomButton.UseSelectable = true;
            this.txtBaslik.CustomButton.Visible = false;
            this.txtBaslik.Lines = new string[0];
            this.txtBaslik.Location = new System.Drawing.Point(120, 114);
            this.txtBaslik.MaxLength = 32767;
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.PasswordChar = '\0';
            this.txtBaslik.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBaslik.SelectedText = "";
            this.txtBaslik.SelectionLength = 0;
            this.txtBaslik.SelectionStart = 0;
            this.txtBaslik.ShortcutsEnabled = true;
            this.txtBaslik.Size = new System.Drawing.Size(357, 29);
            this.txtBaslik.TabIndex = 1;
            this.txtBaslik.UseSelectable = true;
            this.txtBaslik.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBaslik.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dateTimeTarih
            // 
            this.dateTimeTarih.Location = new System.Drawing.Point(120, 149);
            this.dateTimeTarih.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTimeTarih.Name = "dateTimeTarih";
            this.dateTimeTarih.Size = new System.Drawing.Size(357, 29);
            this.dateTimeTarih.TabIndex = 2;
            // 
            // txtMsj
            // 
            // 
            // 
            // 
            this.txtMsj.CustomButton.Image = null;
            this.txtMsj.CustomButton.Location = new System.Drawing.Point(269, 2);
            this.txtMsj.CustomButton.Name = "";
            this.txtMsj.CustomButton.Size = new System.Drawing.Size(85, 85);
            this.txtMsj.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMsj.CustomButton.TabIndex = 1;
            this.txtMsj.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMsj.CustomButton.UseSelectable = true;
            this.txtMsj.CustomButton.Visible = false;
            this.txtMsj.Lines = new string[0];
            this.txtMsj.Location = new System.Drawing.Point(120, 184);
            this.txtMsj.MaxLength = 32767;
            this.txtMsj.Multiline = true;
            this.txtMsj.Name = "txtMsj";
            this.txtMsj.PasswordChar = '\0';
            this.txtMsj.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMsj.SelectedText = "";
            this.txtMsj.SelectionLength = 0;
            this.txtMsj.SelectionStart = 0;
            this.txtMsj.ShortcutsEnabled = true;
            this.txtMsj.Size = new System.Drawing.Size(357, 90);
            this.txtMsj.TabIndex = 3;
            this.txtMsj.UseSelectable = true;
            this.txtMsj.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMsj.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtYorum
            // 
            // 
            // 
            // 
            this.txtYorum.CustomButton.Image = null;
            this.txtYorum.CustomButton.Location = new System.Drawing.Point(269, 2);
            this.txtYorum.CustomButton.Name = "";
            this.txtYorum.CustomButton.Size = new System.Drawing.Size(85, 85);
            this.txtYorum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtYorum.CustomButton.TabIndex = 1;
            this.txtYorum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtYorum.CustomButton.UseSelectable = true;
            this.txtYorum.CustomButton.Visible = false;
            this.txtYorum.Lines = new string[0];
            this.txtYorum.Location = new System.Drawing.Point(120, 280);
            this.txtYorum.MaxLength = 32767;
            this.txtYorum.Multiline = true;
            this.txtYorum.Name = "txtYorum";
            this.txtYorum.PasswordChar = '\0';
            this.txtYorum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtYorum.SelectedText = "";
            this.txtYorum.SelectionLength = 0;
            this.txtYorum.SelectionStart = 0;
            this.txtYorum.ShortcutsEnabled = true;
            this.txtYorum.Size = new System.Drawing.Size(357, 90);
            this.txtYorum.TabIndex = 9;
            this.txtYorum.UseSelectable = true;
            this.txtYorum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtYorum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.metroLabel6.Location = new System.Drawing.Point(77, 50);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(0, 0);
            this.metroLabel6.TabIndex = 47;
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            this.metroLabel6.UseStyleColors = true;
            // 
            // btnYeni
            // 
            this.btnYeni.BackColor = System.Drawing.Color.White;
            this.btnYeni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnYeni.FlatAppearance.BorderSize = 0;
            this.btnYeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeni.Image = global::telekomAidatTakip.Properties.Resources.if_ic_control_point_48px_352288;
            this.btnYeni.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnYeni.Location = new System.Drawing.Point(321, 373);
            this.btnYeni.Margin = new System.Windows.Forms.Padding(0);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(48, 48);
            this.btnYeni.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnYeni, "Yeni Kayıt");
            this.btnYeni.UseVisualStyleBackColor = false;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.White;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKaydet.Enabled = false;
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Image = global::telekomAidatTakip.Properties.Resources.if_icons_check_1564499;
            this.btnKaydet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnKaydet.Location = new System.Drawing.Point(375, 373);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(0);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(48, 48);
            this.btnKaydet.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnKaydet, " Kaydet");
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.White;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSil.Enabled = false;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Image = global::telekomAidatTakip.Properties.Resources.if_icons_exit_1564505;
            this.btnSil.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSil.Location = new System.Drawing.Point(429, 373);
            this.btnSil.Margin = new System.Windows.Forms.Padding(0);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(48, 48);
            this.btnSil.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnSil, "Sil");
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // frmTanimOzelGunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(605, 625);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtYorum);
            this.Controls.Add(this.txtMsj);
            this.Controls.Add(this.dateTimeTarih);
            this.Controls.Add(this.txtBaslik);
            this.Controls.Add(this.btnBirim);
            this.Controls.Add(this.btnMudurluk);
            this.Controls.Add(this.btnSehir);
            this.Controls.Add(this.btnSicilNo);
            this.Controls.Add(this.btnAdi);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtGunNo);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(605, 544);
            this.Name = "frmTanimOzelGunler";
            this.Text = "       ÖZEL GÜN TANIMLAMA";
            this.Load += new System.EventHandler(this.frmTanimOzelGunler_Load);
            this.Resize += new System.EventHandler(this.frmTanimOzelGunler_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private MetroFramework.Controls.MetroTextBox txtGunNo;
        private MetroFramework.Controls.MetroTile btnBirim;
        private MetroFramework.Controls.MetroTile btnMudurluk;
        private MetroFramework.Controls.MetroTile btnSehir;
        private MetroFramework.Controls.MetroTile btnSicilNo;
        private MetroFramework.Controls.MetroTile btnAdi;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtBaslik;
        private MetroFramework.Controls.MetroDateTime dateTimeTarih;
        private MetroFramework.Controls.MetroTextBox txtMsj;
        private MetroFramework.Controls.MetroTextBox txtYorum;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}