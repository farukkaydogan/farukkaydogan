namespace RentCar.UserInterface
{
    partial class YeniArac
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
            this.txtKapiSayisi = new System.Windows.Forms.ComboBox();
            this.txtMotorGucu = new System.Windows.Forms.ComboBox();
            this.btn_ResimSec = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRenk = new System.Windows.Forms.ComboBox();
            this.txtVites = new System.Windows.Forms.ComboBox();
            this.txtYakit = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.rdo_HasarYok = new System.Windows.Forms.RadioButton();
            this.txtSonKm = new System.Windows.Forms.TextBox();
            this.rdo_HasarVar = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtKasaTipi = new System.Windows.Forms.ComboBox();
            this.txtCekisTuru = new System.Windows.Forms.ComboBox();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKapiSayisi
            // 
            this.txtKapiSayisi.FormattingEnabled = true;
            this.txtKapiSayisi.Items.AddRange(new object[] {
            "Tek Kapı (Spor)",
            "Dört Kapı (Standart)"});
            this.txtKapiSayisi.Location = new System.Drawing.Point(77, 56);
            this.txtKapiSayisi.Name = "txtKapiSayisi";
            this.txtKapiSayisi.Size = new System.Drawing.Size(130, 26);
            this.txtKapiSayisi.TabIndex = 11;
            // 
            // txtMotorGucu
            // 
            this.txtMotorGucu.FormattingEnabled = true;
            this.txtMotorGucu.Items.AddRange(new object[] {
            "1.000 Altı",
            "1.2",
            "1.4",
            "1.6",
            "1.8",
            "2.0",
            "2.5",
            "2.7",
            "3.0",
            "3.5",
            "4.0",
            "5.0",
            "5 ve Üzeri"});
            this.txtMotorGucu.Location = new System.Drawing.Point(293, 269);
            this.txtMotorGucu.Name = "txtMotorGucu";
            this.txtMotorGucu.Size = new System.Drawing.Size(113, 26);
            this.txtMotorGucu.TabIndex = 9;
            // 
            // btn_ResimSec
            // 
            this.btn_ResimSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ResimSec.ForeColor = System.Drawing.Color.Maroon;
            this.btn_ResimSec.Location = new System.Drawing.Point(59, 258);
            this.btn_ResimSec.Name = "btn_ResimSec";
            this.btn_ResimSec.Size = new System.Drawing.Size(88, 37);
            this.btn_ResimSec.TabIndex = 1;
            this.btn_ResimSec.Text = "Resim Seç";
            this.btn_ResimSec.UseVisualStyleBackColor = true;
            this.btn_ResimSec.Click += new System.EventHandler(this.btn_ResimSec_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Yıl";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Model";
            // 
            // txtRenk
            // 
            this.txtRenk.FormattingEnabled = true;
            this.txtRenk.Items.AddRange(new object[] {
            "Siyah",
            "Beyaz",
            "Kırmızı",
            "Mavi",
            "Sarı",
            "Pembe",
            "Kahverengi",
            "Bordo"});
            this.txtRenk.Location = new System.Drawing.Point(78, 126);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(130, 26);
            this.txtRenk.TabIndex = 13;
            // 
            // txtVites
            // 
            this.txtVites.FormattingEnabled = true;
            this.txtVites.Items.AddRange(new object[] {
            "Manuel",
            "Yarı Otomatik",
            "Tam Otomatik"});
            this.txtVites.Location = new System.Drawing.Point(293, 199);
            this.txtVites.Name = "txtVites";
            this.txtVites.Size = new System.Drawing.Size(113, 26);
            this.txtVites.TabIndex = 6;
            // 
            // txtYakit
            // 
            this.txtYakit.FormattingEnabled = true;
            this.txtYakit.Items.AddRange(new object[] {
            "Benzin",
            "Dizel",
            "LPG",
            "Benzin + LPG"});
            this.txtYakit.Location = new System.Drawing.Point(293, 165);
            this.txtYakit.Name = "txtYakit";
            this.txtYakit.Size = new System.Drawing.Size(113, 26);
            this.txtYakit.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::RentCar.UserInterface.Properties.Resources.pTq8oakjc;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(10, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Motor Gücü";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "SON KM";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(234, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vites";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yakıt";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(239, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 18);
            this.label10.TabIndex = 1;
            this.label10.Text = "Plaka";
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(290, 27);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(116, 24);
            this.txtPlaka.TabIndex = 1;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(290, 61);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(116, 24);
            this.txtMarka.TabIndex = 2;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kaydet.Image = global::RentCar.UserInterface.Properties.Resources.save4848;
            this.btn_Kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Kaydet.Location = new System.Drawing.Point(60, 208);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(147, 78);
            this.btn_Kaydet.TabIndex = 12;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 18);
            this.label12.TabIndex = 1;
            this.label12.Text = "Renk";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 18);
            this.label13.TabIndex = 1;
            this.label13.Text = "Hasar ";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(290, 94);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(116, 24);
            this.txtModel.TabIndex = 3;
            // 
            // rdo_HasarYok
            // 
            this.rdo_HasarYok.AutoSize = true;
            this.rdo_HasarYok.Location = new System.Drawing.Point(136, 167);
            this.rdo_HasarYok.Name = "rdo_HasarYok";
            this.rdo_HasarYok.Size = new System.Drawing.Size(52, 22);
            this.rdo_HasarYok.TabIndex = 13;
            this.rdo_HasarYok.TabStop = true;
            this.rdo_HasarYok.Text = "Yok";
            this.rdo_HasarYok.UseVisualStyleBackColor = true;
            // 
            // txtSonKm
            // 
            this.txtSonKm.Location = new System.Drawing.Point(293, 236);
            this.txtSonKm.Name = "txtSonKm";
            this.txtSonKm.Size = new System.Drawing.Size(113, 24);
            this.txtSonKm.TabIndex = 7;
            // 
            // rdo_HasarVar
            // 
            this.rdo_HasarVar.AutoSize = true;
            this.rdo_HasarVar.Location = new System.Drawing.Point(89, 167);
            this.rdo_HasarVar.Name = "rdo_HasarVar";
            this.rdo_HasarVar.Size = new System.Drawing.Size(48, 22);
            this.rdo_HasarVar.TabIndex = 13;
            this.rdo_HasarVar.TabStop = true;
            this.rdo_HasarVar.Text = "Var";
            this.rdo_HasarVar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Çekiş";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Kapı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "Kasa Tipi";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtKasaTipi);
            this.groupBox3.Controls.Add(this.rdo_HasarYok);
            this.groupBox3.Controls.Add(this.rdo_HasarVar);
            this.groupBox3.Controls.Add(this.btn_Kaydet);
            this.groupBox3.Controls.Add(this.txtRenk);
            this.groupBox3.Controls.Add(this.txtCekisTuru);
            this.groupBox3.Controls.Add(this.txtKapiSayisi);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(444, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(239, 301);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ehliyet / Diğer";
            // 
            // txtKasaTipi
            // 
            this.txtKasaTipi.FormattingEnabled = true;
            this.txtKasaTipi.Items.AddRange(new object[] {
            "Sedan",
            "Hatchback",
            "Station Wagon",
            "Coupe",
            "Cabrio",
            "SUV (ARAZİ)"});
            this.txtKasaTipi.Location = new System.Drawing.Point(78, 94);
            this.txtKasaTipi.Name = "txtKasaTipi";
            this.txtKasaTipi.Size = new System.Drawing.Size(130, 26);
            this.txtKasaTipi.TabIndex = 14;
            // 
            // txtCekisTuru
            // 
            this.txtCekisTuru.FormattingEnabled = true;
            this.txtCekisTuru.Items.AddRange(new object[] {
            "2X4",
            "4X4"});
            this.txtCekisTuru.Location = new System.Drawing.Point(77, 22);
            this.txtCekisTuru.Name = "txtCekisTuru";
            this.txtCekisTuru.Size = new System.Drawing.Size(130, 26);
            this.txtCekisTuru.TabIndex = 10;
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(290, 131);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(116, 24);
            this.txtYil.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMotorGucu);
            this.groupBox1.Controls.Add(this.txtVites);
            this.groupBox1.Controls.Add(this.btn_ResimSec);
            this.groupBox1.Controls.Add(this.txtYakit);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtPlaka);
            this.groupBox1.Controls.Add(this.txtMarka);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Controls.Add(this.txtSonKm);
            this.groupBox1.Controls.Add(this.txtYil);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 301);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araç Temel Bilgileri";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ID.Location = new System.Drawing.Point(341, 320);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(11, 15);
            this.lbl_ID.TabIndex = 13;
            this.lbl_ID.Text = "-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(315, 318);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 18);
            this.label14.TabIndex = 12;
            this.label14.Text = "ID:";
            // 
            // YeniArac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(693, 341);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "YeniArac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Araç Kaydetme Ekranı ~~ SahinSezgin.com";
            this.Load += new System.EventHandler(this.YeniArac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtPlaka;
        public System.Windows.Forms.TextBox txtMarka;
        public System.Windows.Forms.TextBox txtModel;
        public System.Windows.Forms.TextBox txtSonKm;
        public System.Windows.Forms.TextBox txtYil;
        public System.Windows.Forms.ComboBox txtKapiSayisi;
        public System.Windows.Forms.ComboBox txtMotorGucu;
        public System.Windows.Forms.Button btn_ResimSec;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox txtRenk;
        public System.Windows.Forms.ComboBox txtVites;
        public System.Windows.Forms.ComboBox txtYakit;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Button btn_Kaydet;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.RadioButton rdo_HasarYok;
        public System.Windows.Forms.RadioButton rdo_HasarVar;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.ComboBox txtCekisTuru;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.ComboBox txtKasaTipi;
        public System.Windows.Forms.Label lbl_ID;
        public System.Windows.Forms.Label label14;
    }
}