namespace ActYazbeeBot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtIsimler = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoyisimler = new System.Windows.Forms.RichTextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKullaniciAdiSonu = new System.Windows.Forms.TextBox();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.lblIsim = new System.Windows.Forms.Label();
            this.lblSoyisim = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTakip = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtIsimler
            // 
            this.txtIsimler.Location = new System.Drawing.Point(13, 41);
            this.txtIsimler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIsimler.Name = "txtIsimler";
            this.txtIsimler.Size = new System.Drawing.Size(194, 342);
            this.txtIsimler.TabIndex = 0;
            this.txtIsimler.Text = "";
            this.txtIsimler.TextChanged += new System.EventHandler(this.txtIsimler_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "İsimler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyisimler";
            // 
            // txtSoyisimler
            // 
            this.txtSoyisimler.Location = new System.Drawing.Point(215, 41);
            this.txtSoyisimler.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoyisimler.Name = "txtSoyisimler";
            this.txtSoyisimler.Size = new System.Drawing.Size(194, 342);
            this.txtSoyisimler.TabIndex = 2;
            this.txtSoyisimler.Text = "";
            this.txtSoyisimler.TextChanged += new System.EventHandler(this.txtSoyisimler_TextChanged);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(416, 41);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '•';
            this.txtSifre.Size = new System.Drawing.Size(183, 23);
            this.txtSifre.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Şifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kullanıcı Adının Sonuna Ekle";
            // 
            // txtKullaniciAdiSonu
            // 
            this.txtKullaniciAdiSonu.Location = new System.Drawing.Point(416, 96);
            this.txtKullaniciAdiSonu.Name = "txtKullaniciAdiSonu";
            this.txtKullaniciAdiSonu.Size = new System.Drawing.Size(183, 23);
            this.txtKullaniciAdiSonu.TabIndex = 6;
            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.ItemHeight = 17;
            this.lstLog.Location = new System.Drawing.Point(13, 391);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(586, 174);
            this.lstLog.TabIndex = 8;
            // 
            // btnBaslat
            // 
            this.btnBaslat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaslat.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.btnBaslat.Location = new System.Drawing.Point(418, 227);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(181, 152);
            this.btnBaslat.TabIndex = 9;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.BackColor = System.Drawing.Color.Black;
            this.lblIsim.ForeColor = System.Drawing.Color.White;
            this.lblIsim.Location = new System.Drawing.Point(17, 362);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(83, 17);
            this.lblIsim.TabIndex = 10;
            this.lblIsim.Text = "İsim Sayısı: 0";
            // 
            // lblSoyisim
            // 
            this.lblSoyisim.AutoSize = true;
            this.lblSoyisim.BackColor = System.Drawing.Color.Black;
            this.lblSoyisim.ForeColor = System.Drawing.Color.White;
            this.lblSoyisim.Location = new System.Drawing.Point(220, 362);
            this.lblSoyisim.Name = "lblSoyisim";
            this.lblSoyisim.Size = new System.Drawing.Size(104, 17);
            this.lblSoyisim.TabIndex = 11;
            this.lblSoyisim.Text = "Soyisim Sayısı: 0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Takip Edilecek Kişi";
            // 
            // txtTakip
            // 
            this.txtTakip.Location = new System.Drawing.Point(417, 147);
            this.txtTakip.Name = "txtTakip";
            this.txtTakip.Size = new System.Drawing.Size(182, 23);
            this.txtTakip.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 178);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Mail(Oto)";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(418, 198);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(182, 23);
            this.txtMail.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(612, 575);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTakip);
            this.Controls.Add(this.lblSoyisim);
            this.Controls.Add(this.lblIsim);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKullaniciAdiSonu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoyisimler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIsimler);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACT Yazbee Bot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtIsimler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtSoyisimler;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKullaniciAdiSonu;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.Label lblSoyisim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTakip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMail;
    }
}

