namespace telekomAidatTakip
{
    partial class frmTanimUnvan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTanimUnvan));
            this.txtUnvanNo = new MetroFramework.Controls.MetroTextBox();
            this.txtUnvanAdi = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.listUnvan = new System.Windows.Forms.ListView();
            this.unvanNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unvanAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUnvanNo
            // 
            // 
            // 
            // 
            this.txtUnvanNo.CustomButton.Image = null;
            this.txtUnvanNo.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtUnvanNo.CustomButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUnvanNo.CustomButton.Name = "";
            this.txtUnvanNo.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtUnvanNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUnvanNo.CustomButton.TabIndex = 1;
            this.txtUnvanNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUnvanNo.CustomButton.UseSelectable = true;
            this.txtUnvanNo.CustomButton.Visible = false;
            this.txtUnvanNo.Lines = new string[0];
            this.txtUnvanNo.Location = new System.Drawing.Point(128, 72);
            this.txtUnvanNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUnvanNo.MaxLength = 32767;
            this.txtUnvanNo.Name = "txtUnvanNo";
            this.txtUnvanNo.PasswordChar = '\0';
            this.txtUnvanNo.PromptText = "Ünvan no girniz.";
            this.txtUnvanNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUnvanNo.SelectedText = "";
            this.txtUnvanNo.SelectionLength = 0;
            this.txtUnvanNo.SelectionStart = 0;
            this.txtUnvanNo.ShortcutsEnabled = true;
            this.txtUnvanNo.Size = new System.Drawing.Size(145, 29);
            this.txtUnvanNo.TabIndex = 4;
            this.txtUnvanNo.UseSelectable = true;
            this.txtUnvanNo.WaterMark = "Ünvan no girniz.";
            this.txtUnvanNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUnvanNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtUnvanNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnvanNo_KeyPress);
            // 
            // txtUnvanAdi
            // 
            // 
            // 
            // 
            this.txtUnvanAdi.CustomButton.Image = null;
            this.txtUnvanAdi.CustomButton.Location = new System.Drawing.Point(211, 1);
            this.txtUnvanAdi.CustomButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUnvanAdi.CustomButton.Name = "";
            this.txtUnvanAdi.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtUnvanAdi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUnvanAdi.CustomButton.TabIndex = 1;
            this.txtUnvanAdi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUnvanAdi.CustomButton.UseSelectable = true;
            this.txtUnvanAdi.CustomButton.Visible = false;
            this.txtUnvanAdi.Lines = new string[0];
            this.txtUnvanAdi.Location = new System.Drawing.Point(128, 106);
            this.txtUnvanAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUnvanAdi.MaxLength = 32767;
            this.txtUnvanAdi.Name = "txtUnvanAdi";
            this.txtUnvanAdi.PasswordChar = '\0';
            this.txtUnvanAdi.PromptText = "Ünvan adı giriniz.";
            this.txtUnvanAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUnvanAdi.SelectedText = "";
            this.txtUnvanAdi.SelectionLength = 0;
            this.txtUnvanAdi.SelectionStart = 0;
            this.txtUnvanAdi.ShortcutsEnabled = true;
            this.txtUnvanAdi.Size = new System.Drawing.Size(239, 29);
            this.txtUnvanAdi.TabIndex = 5;
            this.txtUnvanAdi.UseSelectable = true;
            this.txtUnvanAdi.WaterMark = "Ünvan adı giriniz.";
            this.txtUnvanAdi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUnvanAdi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(36, 77);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 20);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Ünvan No:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(36, 111);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(76, 20);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Ünvan Adı:";
            // 
            // listUnvan
            // 
            this.listUnvan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.unvanNo,
            this.unvanAdi});
            this.listUnvan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listUnvan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listUnvan.FullRowSelect = true;
            this.listUnvan.Location = new System.Drawing.Point(20, 193);
            this.listUnvan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listUnvan.Name = "listUnvan";
            this.listUnvan.Size = new System.Drawing.Size(401, 222);
            this.listUnvan.TabIndex = 10;
            this.listUnvan.UseCompatibleStateImageBehavior = false;
            this.listUnvan.View = System.Windows.Forms.View.Details;
            this.listUnvan.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // unvanNo
            // 
            this.unvanNo.Text = "Ünvan No";
            this.unvanNo.Width = 122;
            // 
            // unvanAdi
            // 
            this.unvanAdi.Text = "Ünvan Adı";
            this.unvanAdi.Width = 131;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(17, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // btnYeni
            // 
            this.btnYeni.BackColor = System.Drawing.Color.White;
            this.btnYeni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnYeni.FlatAppearance.BorderSize = 0;
            this.btnYeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeni.Image = global::telekomAidatTakip.Properties.Resources.if_ic_control_point_48px_352288;
            this.btnYeni.Location = new System.Drawing.Point(223, 140);
            this.btnYeni.Margin = new System.Windows.Forms.Padding(0);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(48, 48);
            this.btnYeni.TabIndex = 49;
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
            this.btnKaydet.Location = new System.Drawing.Point(271, 140);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(0);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(48, 48);
            this.btnKaydet.TabIndex = 50;
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
            this.btnSil.Location = new System.Drawing.Point(319, 140);
            this.btnSil.Margin = new System.Windows.Forms.Padding(0);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(48, 48);
            this.btnSil.TabIndex = 51;
            this.toolTip1.SetToolTip(this.btnSil, "Sil");
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // frmTanimUnvan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 435);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.listUnvan);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtUnvanNo);
            this.Controls.Add(this.txtUnvanAdi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTanimUnvan";
            this.Text = "       Ünvan Tanımlama";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTanimUnvan_FormClosing);
            this.Load += new System.EventHandler(this.frmTanimUnvan_Load);
            this.Resize += new System.EventHandler(this.frmTanimUnvan_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txtUnvanAdi;
        private MetroFramework.Controls.MetroTextBox txtUnvanNo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ListView listUnvan;
        private System.Windows.Forms.ColumnHeader unvanNo;
        private System.Windows.Forms.ColumnHeader unvanAdi;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}