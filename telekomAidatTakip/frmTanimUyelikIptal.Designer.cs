namespace telekomAidatTakip
{
    partial class frmTanimUyelikIptal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTanimUyelikIptal));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabelKod = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listvSilinme = new System.Windows.Forms.ListView();
            this.columnHeaderKod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAciklama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtKod = new MetroFramework.Controls.MetroTextBox();
            this.txtAciklama = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(34, 119);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 27;
            this.metroLabel1.Text = "Açıklama :";
            // 
            // metroLabelKod
            // 
            this.metroLabelKod.AutoSize = true;
            this.metroLabelKod.Location = new System.Drawing.Point(34, 84);
            this.metroLabelKod.Name = "metroLabelKod";
            this.metroLabelKod.Size = new System.Drawing.Size(39, 19);
            this.metroLabelKod.TabIndex = 26;
            this.metroLabelKod.Text = "Kod :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 84);
            this.label1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 84);
            this.label2.TabIndex = 21;
            // 
            // listvSilinme
            // 
            this.listvSilinme.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listvSilinme.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderKod,
            this.columnHeaderAciklama});
            this.listvSilinme.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listvSilinme.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listvSilinme.FullRowSelect = true;
            this.listvSilinme.Location = new System.Drawing.Point(20, 197);
            this.listvSilinme.Name = "listvSilinme";
            this.listvSilinme.Size = new System.Drawing.Size(407, 186);
            this.listvSilinme.TabIndex = 29;
            this.listvSilinme.UseCompatibleStateImageBehavior = false;
            this.listvSilinme.View = System.Windows.Forms.View.Details;
            this.listvSilinme.DoubleClick += new System.EventHandler(this.listvSilinme_DoubleClick);
            // 
            // columnHeaderKod
            // 
            this.columnHeaderKod.Text = "Kod";
            this.columnHeaderKod.Width = 130;
            // 
            // columnHeaderAciklama
            // 
            this.columnHeaderAciklama.Text = "Açıklama";
            this.columnHeaderAciklama.Width = 188;
            // 
            // txtKod
            // 
            // 
            // 
            // 
            this.txtKod.CustomButton.Image = null;
            this.txtKod.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.txtKod.CustomButton.Name = "";
            this.txtKod.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtKod.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKod.CustomButton.TabIndex = 1;
            this.txtKod.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKod.CustomButton.UseSelectable = true;
            this.txtKod.CustomButton.Visible = false;
            this.txtKod.Lines = new string[0];
            this.txtKod.Location = new System.Drawing.Point(121, 79);
            this.txtKod.MaxLength = 32767;
            this.txtKod.Name = "txtKod";
            this.txtKod.PasswordChar = '\0';
            this.txtKod.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKod.SelectedText = "";
            this.txtKod.SelectionLength = 0;
            this.txtKod.SelectionStart = 0;
            this.txtKod.ShortcutsEnabled = true;
            this.txtKod.Size = new System.Drawing.Size(161, 29);
            this.txtKod.TabIndex = 31;
            this.txtKod.UseSelectable = true;
            this.txtKod.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKod.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtKod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKod_KeyPress);
            // 
            // txtAciklama
            // 
            // 
            // 
            // 
            this.txtAciklama.CustomButton.Image = null;
            this.txtAciklama.CustomButton.Location = new System.Drawing.Point(233, 1);
            this.txtAciklama.CustomButton.Name = "";
            this.txtAciklama.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtAciklama.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAciklama.CustomButton.TabIndex = 1;
            this.txtAciklama.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAciklama.CustomButton.UseSelectable = true;
            this.txtAciklama.CustomButton.Visible = false;
            this.txtAciklama.Lines = new string[0];
            this.txtAciklama.Location = new System.Drawing.Point(121, 114);
            this.txtAciklama.MaxLength = 32767;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.PasswordChar = '\0';
            this.txtAciklama.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAciklama.SelectedText = "";
            this.txtAciklama.SelectionLength = 0;
            this.txtAciklama.SelectionStart = 0;
            this.txtAciklama.ShortcutsEnabled = true;
            this.txtAciklama.Size = new System.Drawing.Size(261, 29);
            this.txtAciklama.TabIndex = 32;
            this.txtAciklama.UseSelectable = true;
            this.txtAciklama.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAciklama.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 17);
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
            this.btnYeni.Location = new System.Drawing.Point(238, 146);
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
            this.btnKaydet.Location = new System.Drawing.Point(286, 146);
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
            this.btnSil.Location = new System.Drawing.Point(334, 146);
            this.btnSil.Margin = new System.Windows.Forms.Padding(0);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(48, 48);
            this.btnSil.TabIndex = 51;
            this.toolTip1.SetToolTip(this.btnSil, "Sil");
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // frmTanimUyelikIptal
            // 
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.ClientSize = new System.Drawing.Size(447, 403);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.listvSilinme);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabelKod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Cambria Math", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTanimUyelikIptal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Text = "       Silinme Nedeni Tanımlama";
            this.Load += new System.EventHandler(this.frmTanimUyelikIptal_Load);
            this.BackColorChanged += new System.EventHandler(this.frmTanimUyelikIptal_Resize);
            this.Resize += new System.EventHandler(this.frmTanimUyelikIptal_Resize_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabelKod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listvSilinme;
        private System.Windows.Forms.ColumnHeader columnHeaderKod;
        private System.Windows.Forms.ColumnHeader columnHeaderAciklama;
        private MetroFramework.Controls.MetroTextBox txtKod;
        private MetroFramework.Controls.MetroTextBox txtAciklama;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
    }
}