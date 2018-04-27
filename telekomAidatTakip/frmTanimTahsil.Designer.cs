namespace telekomAidatTakip
{
    partial class frmTanimTahsil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTanimTahsil));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTahsilAd = new MetroFramework.Controls.MetroTextBox();
            this.txtTahsilKodu = new MetroFramework.Controls.MetroTextBox();
            this.tahsilAd = new MetroFramework.Controls.MetroLabel();
            this.tahsilNo = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listvTanimTahsil = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.toolTip = new MetroFramework.Components.MetroToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // txtTahsilAd
            // 
            // 
            // 
            // 
            this.txtTahsilAd.CustomButton.Image = null;
            this.txtTahsilAd.CustomButton.Location = new System.Drawing.Point(206, 1);
            this.txtTahsilAd.CustomButton.Name = "";
            this.txtTahsilAd.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtTahsilAd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTahsilAd.CustomButton.TabIndex = 1;
            this.txtTahsilAd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTahsilAd.CustomButton.UseSelectable = true;
            this.txtTahsilAd.CustomButton.Visible = false;
            this.txtTahsilAd.Lines = new string[0];
            this.txtTahsilAd.Location = new System.Drawing.Point(154, 106);
            this.txtTahsilAd.MaxLength = 32767;
            this.txtTahsilAd.Name = "txtTahsilAd";
            this.txtTahsilAd.PasswordChar = '\0';
            this.txtTahsilAd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTahsilAd.SelectedText = "";
            this.txtTahsilAd.SelectionLength = 0;
            this.txtTahsilAd.SelectionStart = 0;
            this.txtTahsilAd.ShortcutsEnabled = true;
            this.txtTahsilAd.Size = new System.Drawing.Size(234, 29);
            this.txtTahsilAd.TabIndex = 11;
            this.txtTahsilAd.UseSelectable = true;
            this.txtTahsilAd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTahsilAd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTahsilKodu
            // 
            // 
            // 
            // 
            this.txtTahsilKodu.CustomButton.Image = null;
            this.txtTahsilKodu.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.txtTahsilKodu.CustomButton.Name = "";
            this.txtTahsilKodu.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtTahsilKodu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTahsilKodu.CustomButton.TabIndex = 1;
            this.txtTahsilKodu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTahsilKodu.CustomButton.UseSelectable = true;
            this.txtTahsilKodu.CustomButton.Visible = false;
            this.txtTahsilKodu.Lines = new string[0];
            this.txtTahsilKodu.Location = new System.Drawing.Point(154, 71);
            this.txtTahsilKodu.MaxLength = 32767;
            this.txtTahsilKodu.Name = "txtTahsilKodu";
            this.txtTahsilKodu.PasswordChar = '\0';
            this.txtTahsilKodu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTahsilKodu.SelectedText = "";
            this.txtTahsilKodu.SelectionLength = 0;
            this.txtTahsilKodu.SelectionStart = 0;
            this.txtTahsilKodu.ShortcutsEnabled = true;
            this.txtTahsilKodu.Size = new System.Drawing.Size(148, 29);
            this.txtTahsilKodu.TabIndex = 10;
            this.txtTahsilKodu.UseSelectable = true;
            this.txtTahsilKodu.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTahsilKodu.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTahsilKodu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTahsilKodu_KeyPress);
            // 
            // tahsilAd
            // 
            this.tahsilAd.AutoSize = true;
            this.tahsilAd.Location = new System.Drawing.Point(65, 111);
            this.tahsilAd.Name = "tahsilAd";
            this.tahsilAd.Size = new System.Drawing.Size(63, 19);
            this.tahsilAd.TabIndex = 9;
            this.tahsilAd.Text = "Tahsil Ad:";
            // 
            // tahsilNo
            // 
            this.tahsilNo.AutoSize = true;
            this.tahsilNo.Location = new System.Drawing.Point(65, 76);
            this.tahsilNo.Name = "tahsilNo";
            this.tahsilNo.Size = new System.Drawing.Size(69, 19);
            this.tahsilNo.TabIndex = 8;
            this.tahsilNo.Text = "Tahsil Kod:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // listvTanimTahsil
            // 
            this.listvTanimTahsil.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listvTanimTahsil.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listvTanimTahsil.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listvTanimTahsil.FullRowSelect = true;
            this.listvTanimTahsil.Location = new System.Drawing.Point(20, 189);
            this.listvTanimTahsil.Name = "listvTanimTahsil";
            this.listvTanimTahsil.Size = new System.Drawing.Size(433, 200);
            this.listvTanimTahsil.TabIndex = 13;
            this.listvTanimTahsil.UseCompatibleStateImageBehavior = false;
            this.listvTanimTahsil.View = System.Windows.Forms.View.Details;
            this.listvTanimTahsil.DoubleClick += new System.EventHandler(this.listvTanimTahsil_DoubleClick_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tahsil Kodu";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tahsil Açıklama";
            this.columnHeader2.Width = 389;
            // 
            // btnYeni
            // 
            this.btnYeni.BackColor = System.Drawing.Color.White;
            this.btnYeni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnYeni.FlatAppearance.BorderSize = 0;
            this.btnYeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeni.Image = global::telekomAidatTakip.Properties.Resources.if_ic_control_point_48px_352288;
            this.btnYeni.Location = new System.Drawing.Point(244, 138);
            this.btnYeni.Margin = new System.Windows.Forms.Padding(0);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(48, 48);
            this.btnYeni.TabIndex = 49;
            this.toolTip.SetToolTip(this.btnYeni, "Yeni Kayıt");
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
            this.btnKaydet.Location = new System.Drawing.Point(292, 138);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(0);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(48, 48);
            this.btnKaydet.TabIndex = 50;
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
            this.btnSil.Location = new System.Drawing.Point(340, 138);
            this.btnSil.Margin = new System.Windows.Forms.Padding(0);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(48, 48);
            this.btnSil.TabIndex = 51;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // toolTip
            // 
            this.toolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.toolTip.StyleManager = null;
            this.toolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // frmTanimTahsil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 409);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.listvTanimTahsil);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTahsilAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTahsilKodu);
            this.Controls.Add(this.tahsilNo);
            this.Controls.Add(this.tahsilAd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTanimTahsil";
            this.Text = "       Tahsil Tanımlama";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTanimTahsil_FormClosing);
            this.Load += new System.EventHandler(this.frmTanimTahsil_Load);
            this.Resize += new System.EventHandler(this.frmTanimTahsil_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel tahsilAd;
        private MetroFramework.Controls.MetroLabel tahsilNo;
        private MetroFramework.Controls.MetroTextBox txtTahsilKodu;
        private MetroFramework.Controls.MetroTextBox txtTahsilAd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listvTanimTahsil;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private MetroFramework.Components.MetroToolTip toolTip;
    }
}