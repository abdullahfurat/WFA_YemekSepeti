namespace WFA_YemekSepeti
{
    partial class Form1
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
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbIkinciYemek = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cmbBirinciYemek = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.btnSiparisAl = new MetroFramework.Controls.MetroTile();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(1035, 78);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(46, 25);
            this.metroLabel6.TabIndex = 26;
            this.metroLabel6.Text = "0 TL";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(636, 74);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(308, 25);
            this.metroLabel5.TabIndex = 25;
            this.metroLabel5.Text = "Toplam Ödenemeniz Gereken Tutar : ";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(333, 161);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(196, 20);
            this.metroLabel4.TabIndex = 18;
            this.metroLabel4.Text = "Lütfen Porsiyon Bilgisi Giriniz : ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(31, 161);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(196, 20);
            this.metroLabel3.TabIndex = 19;
            this.metroLabel3.Text = "Lütfen Porsiyon Bilgisi Giriniz : ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(333, 188);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(293, 22);
            this.textBox2.TabIndex = 16;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 188);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 22);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbIkinciYemek
            // 
            this.cmbIkinciYemek.FormattingEnabled = true;
            this.cmbIkinciYemek.ItemHeight = 24;
            this.cmbIkinciYemek.Items.AddRange(new object[] {
            "Kebap",
            "Pilav"});
            this.cmbIkinciYemek.Location = new System.Drawing.Point(333, 112);
            this.cmbIkinciYemek.Margin = new System.Windows.Forms.Padding(4);
            this.cmbIkinciYemek.Name = "cmbIkinciYemek";
            this.cmbIkinciYemek.Size = new System.Drawing.Size(293, 30);
            this.cmbIkinciYemek.TabIndex = 14;
            this.cmbIkinciYemek.UseSelectable = true;
            this.cmbIkinciYemek.TextChanged += new System.EventHandler(this.cmbIkinciYemek_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(333, 74);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(151, 20);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Lütfen Yemek Seçiniz : ";
            // 
            // cmbBirinciYemek
            // 
            this.cmbBirinciYemek.FormattingEnabled = true;
            this.cmbBirinciYemek.ItemHeight = 24;
            this.cmbBirinciYemek.Items.AddRange(new object[] {
            "Kebap",
            "Pilav"});
            this.cmbBirinciYemek.Location = new System.Drawing.Point(31, 112);
            this.cmbBirinciYemek.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBirinciYemek.Name = "cmbBirinciYemek";
            this.cmbBirinciYemek.Size = new System.Drawing.Size(293, 30);
            this.cmbBirinciYemek.TabIndex = 15;
            this.cmbBirinciYemek.UseSelectable = true;
            this.cmbBirinciYemek.TextUpdate += new System.EventHandler(this.cmbBirinciYemek_TextChanged);
            this.cmbBirinciYemek.TextChanged += new System.EventHandler(this.cmbBirinciYemek_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(31, 74);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(151, 20);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Lütfen Yemek Seçiniz : ";
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.metroTile3.Location = new System.Drawing.Point(839, 190);
            this.metroTile3.Margin = new System.Windows.Forms.Padding(4);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(324, 358);
            this.metroTile3.TabIndex = 24;
            this.metroTile3.Text = "Sipariş Özeti";
            this.metroTile3.TileImage = global::WFA_YemekSepeti.Properties.Resources.asci3;
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.metroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile3.UseCustomBackColor = true;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.metroTile2.Location = new System.Drawing.Point(636, 112);
            this.metroTile2.Margin = new System.Windows.Forms.Padding(4);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(527, 74);
            this.metroTile2.TabIndex = 23;
            this.metroTile2.Text = "Sipariş İptal";
            this.metroTile2.TileImage = global::WFA_YemekSepeti.Properties.Resources.iconfinder_Close_1031533;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.UseCustomBackColor = true;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // btnSiparisAl
            // 
            this.btnSiparisAl.ActiveControl = null;
            this.btnSiparisAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnSiparisAl.Location = new System.Drawing.Point(636, 188);
            this.btnSiparisAl.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiparisAl.Name = "btnSiparisAl";
            this.btnSiparisAl.Size = new System.Drawing.Size(195, 359);
            this.btnSiparisAl.TabIndex = 22;
            this.btnSiparisAl.Text = "Sipariş Al";
            this.btnSiparisAl.TileImage = global::WFA_YemekSepeti.Properties.Resources.iconfinder_check_2561355;
            this.btnSiparisAl.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSiparisAl.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnSiparisAl.UseCustomBackColor = true;
            this.btnSiparisAl.UseSelectable = true;
            this.btnSiparisAl.UseTileImage = true;
            this.btnSiparisAl.Click += new System.EventHandler(this.btnSiparisAl_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(333, 239);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(291, 308);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(31, 239);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 308);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 577);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.btnSiparisAl);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmbIkinciYemek);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cmbBirinciYemek);
            this.Controls.Add(this.metroLabel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Et Lokantası";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile btnSiparisAl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private MetroFramework.Controls.MetroComboBox cmbIkinciYemek;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cmbBirinciYemek;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}

