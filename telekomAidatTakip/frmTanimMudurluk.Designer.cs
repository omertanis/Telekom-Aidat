namespace telekomAidatTakip
{
    partial class frmTanimMudurluk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTanimMudurluk));
            this.txtMdrKod = new MetroFramework.Controls.MetroTextBox();
            this.comboBox_il = new MetroFramework.Controls.MetroComboBox();
            this.txtMdrAd = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.labelMdrNo = new MetroFramework.Controls.MetroLabel();
            this.listvMdr = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMdrKod
            // 
            // 
            // 
            // 
            this.txtMdrKod.CustomButton.Image = null;
            this.txtMdrKod.CustomButton.Location = new System.Drawing.Point(94, 2);
            this.txtMdrKod.CustomButton.Name = "";
            this.txtMdrKod.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtMdrKod.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMdrKod.CustomButton.TabIndex = 1;
            this.txtMdrKod.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMdrKod.CustomButton.UseSelectable = true;
            this.txtMdrKod.CustomButton.Visible = false;
            this.txtMdrKod.Lines = new string[0];
            this.txtMdrKod.Location = new System.Drawing.Point(159, 67);
            this.txtMdrKod.MaxLength = 32767;
            this.txtMdrKod.Name = "txtMdrKod";
            this.txtMdrKod.PasswordChar = '\0';
            this.txtMdrKod.PromptText = "Müdürlük no giriniz.";
            this.txtMdrKod.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMdrKod.SelectedText = "";
            this.txtMdrKod.SelectionLength = 0;
            this.txtMdrKod.SelectionStart = 0;
            this.txtMdrKod.ShortcutsEnabled = true;
            this.txtMdrKod.Size = new System.Drawing.Size(122, 30);
            this.txtMdrKod.TabIndex = 0;
            this.txtMdrKod.UseSelectable = true;
            this.txtMdrKod.WaterMark = "Müdürlük no giriniz.";
            this.txtMdrKod.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMdrKod.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMdrKod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMdrKod_KeyPress);
            // 
            // comboBox_il
            // 
            this.comboBox_il.Enabled = false;
            this.comboBox_il.FormattingEnabled = true;
            this.comboBox_il.ItemHeight = 24;
            this.comboBox_il.Location = new System.Drawing.Point(159, 142);
            this.comboBox_il.Name = "comboBox_il";
            this.comboBox_il.PromptText = "İl seçiniz.";
            this.comboBox_il.Size = new System.Drawing.Size(369, 30);
            this.comboBox_il.TabIndex = 2;
            this.comboBox_il.Tag = "";
            this.comboBox_il.UseSelectable = true;
            // 
            // txtMdrAd
            // 
            // 
            // 
            // 
            this.txtMdrAd.CustomButton.Image = null;
            this.txtMdrAd.CustomButton.Location = new System.Drawing.Point(341, 2);
            this.txtMdrAd.CustomButton.Name = "";
            this.txtMdrAd.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtMdrAd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMdrAd.CustomButton.TabIndex = 1;
            this.txtMdrAd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMdrAd.CustomButton.UseSelectable = true;
            this.txtMdrAd.CustomButton.Visible = false;
            this.txtMdrAd.Lines = new string[0];
            this.txtMdrAd.Location = new System.Drawing.Point(159, 104);
            this.txtMdrAd.MaxLength = 32767;
            this.txtMdrAd.Name = "txtMdrAd";
            this.txtMdrAd.PasswordChar = '\0';
            this.txtMdrAd.PromptText = "Müdürlük adı giriniz.";
            this.txtMdrAd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMdrAd.SelectedText = "";
            this.txtMdrAd.SelectionLength = 0;
            this.txtMdrAd.SelectionStart = 0;
            this.txtMdrAd.ShortcutsEnabled = true;
            this.txtMdrAd.Size = new System.Drawing.Size(369, 30);
            this.txtMdrAd.TabIndex = 1;
            this.txtMdrAd.UseSelectable = true;
            this.txtMdrAd.WaterMark = "Müdürlük adı giriniz.";
            this.txtMdrAd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMdrAd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(30, 110);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 20);
            this.metroLabel1.TabIndex = 25;
            this.metroLabel1.Text = "Müdürlük: ";
            // 
            // labelMdrNo
            // 
            this.labelMdrNo.AutoSize = true;
            this.labelMdrNo.Location = new System.Drawing.Point(30, 73);
            this.labelMdrNo.Name = "labelMdrNo";
            this.labelMdrNo.Size = new System.Drawing.Size(98, 20);
            this.labelMdrNo.TabIndex = 24;
            this.labelMdrNo.Text = "Müdürlük No: ";
            // 
            // listvMdr
            // 
            this.listvMdr.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listvMdr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listvMdr.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listvMdr.FullRowSelect = true;
            this.listvMdr.Location = new System.Drawing.Point(27, 239);
            this.listvMdr.Name = "listvMdr";
            this.listvMdr.Size = new System.Drawing.Size(501, 252);
            this.listvMdr.TabIndex = 6;
            this.listvMdr.UseCompatibleStateImageBehavior = false;
            this.listvMdr.View = System.Windows.Forms.View.Details;
            this.listvMdr.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listvMdr_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Müdürlük No";
            this.columnHeader1.Width = 129;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Müdürlük";
            this.columnHeader2.Width = 168;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "İl No";
            this.columnHeader3.Width = 84;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "İl";
            this.columnHeader4.Width = 112;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(30, 147);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(18, 20);
            this.metroLabel2.TabIndex = 25;
            this.metroLabel2.Text = "İl:";
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
            // btnYeni
            // 
            this.btnYeni.BackColor = System.Drawing.Color.White;
            this.btnYeni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnYeni.FlatAppearance.BorderSize = 0;
            this.btnYeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeni.Image = global::telekomAidatTakip.Properties.Resources.if_ic_control_point_48px_352288;
            this.btnYeni.Location = new System.Drawing.Point(384, 175);
            this.btnYeni.Margin = new System.Windows.Forms.Padding(0);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(48, 48);
            this.btnYeni.TabIndex = 3;
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
            this.btnKaydet.Location = new System.Drawing.Point(432, 175);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(0);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(48, 48);
            this.btnKaydet.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnKaydet, "Kaydet");
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
            this.btnSil.Location = new System.Drawing.Point(480, 175);
            this.btnSil.Margin = new System.Windows.Forms.Padding(0);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(48, 48);
            this.btnSil.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnSil, "Sil");
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // frmTanimMudurluk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 516);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listvMdr);
            this.Controls.Add(this.txtMdrKod);
            this.Controls.Add(this.comboBox_il);
            this.Controls.Add(this.txtMdrAd);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.labelMdrNo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(555, 516);
            this.Name = "frmTanimMudurluk";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "       MÜDÜRLÜK TANIMLAMA";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmTanimMudurluk_Load);
            this.Resize += new System.EventHandler(this.frmTanimMudurluk_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txtMdrKod;
        private MetroFramework.Controls.MetroComboBox comboBox_il;
        private MetroFramework.Controls.MetroTextBox txtMdrAd;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel labelMdrNo;
        private System.Windows.Forms.ListView listvMdr;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}