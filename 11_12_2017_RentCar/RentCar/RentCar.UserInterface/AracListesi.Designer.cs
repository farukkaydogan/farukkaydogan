namespace RentCar.UserInterface
{
    partial class AracListesi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataGridTumAraclar = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DataGridMusaitAraclar = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DataGridKiradakiAraclar = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.chk_AktifEt = new System.Windows.Forms.CheckBox();
            this.groupBoxButonlar = new System.Windows.Forms.GroupBox();
            this.btn_Yazdir = new System.Windows.Forms.Button();
            this.btn_QRCodeOlustur = new System.Windows.Forms.Button();
            this.btn_ExcelAktar = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Duzenle = new System.Windows.Forms.Button();
            this.btn_Renkendir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTumAraclar)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMusaitAraclar)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridKiradakiAraclar)).BeginInit();
            this.groupBoxButonlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataGridTumAraclar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(13, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tüm Araçların Listesi (ARAÇ İŞLEMLERİ)";
            // 
            // DataGridTumAraclar
            // 
            this.DataGridTumAraclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridTumAraclar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridTumAraclar.Location = new System.Drawing.Point(3, 16);
            this.DataGridTumAraclar.Name = "DataGridTumAraclar";
            this.DataGridTumAraclar.Size = new System.Drawing.Size(738, 235);
            this.DataGridTumAraclar.TabIndex = 0;
            this.DataGridTumAraclar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridTumAraclar_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DataGridMusaitAraclar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.Green;
            this.groupBox2.Location = new System.Drawing.Point(13, 353);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 219);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müsait Olan Araçların  Listesi";
            // 
            // DataGridMusaitAraclar
            // 
            this.DataGridMusaitAraclar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridMusaitAraclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridMusaitAraclar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridMusaitAraclar.Location = new System.Drawing.Point(3, 16);
            this.DataGridMusaitAraclar.Name = "DataGridMusaitAraclar";
            this.DataGridMusaitAraclar.Size = new System.Drawing.Size(362, 200);
            this.DataGridMusaitAraclar.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DataGridKiradakiAraclar);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(387, 353);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(370, 219);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kirada Olan Araçların Listesi";
            // 
            // DataGridKiradakiAraclar
            // 
            this.DataGridKiradakiAraclar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridKiradakiAraclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridKiradakiAraclar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridKiradakiAraclar.Location = new System.Drawing.Point(3, 16);
            this.DataGridKiradakiAraclar.Name = "DataGridKiradakiAraclar";
            this.DataGridKiradakiAraclar.Size = new System.Drawing.Size(364, 200);
            this.DataGridKiradakiAraclar.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(3, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 16);
            this.label17.TabIndex = 6;
            this.label17.Text = "Aktif";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(9, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 16);
            this.label14.TabIndex = 7;
            this.label14.Text = "Et";
            // 
            // chk_AktifEt
            // 
            this.chk_AktifEt.AutoSize = true;
            this.chk_AktifEt.Location = new System.Drawing.Point(12, 55);
            this.chk_AktifEt.Name = "chk_AktifEt";
            this.chk_AktifEt.Size = new System.Drawing.Size(15, 14);
            this.chk_AktifEt.TabIndex = 5;
            this.chk_AktifEt.UseVisualStyleBackColor = true;
            this.chk_AktifEt.CheckedChanged += new System.EventHandler(this.chk_AktifEt_CheckedChanged);
            // 
            // groupBoxButonlar
            // 
            this.groupBoxButonlar.Controls.Add(this.btn_Yazdir);
            this.groupBoxButonlar.Controls.Add(this.btn_QRCodeOlustur);
            this.groupBoxButonlar.Controls.Add(this.btn_ExcelAktar);
            this.groupBoxButonlar.Controls.Add(this.btn_Sil);
            this.groupBoxButonlar.Controls.Add(this.btn_Duzenle);
            this.groupBoxButonlar.Controls.Add(this.btn_Renkendir);
            this.groupBoxButonlar.Enabled = false;
            this.groupBoxButonlar.Location = new System.Drawing.Point(33, 9);
            this.groupBoxButonlar.Name = "groupBoxButonlar";
            this.groupBoxButonlar.Size = new System.Drawing.Size(724, 77);
            this.groupBoxButonlar.TabIndex = 4;
            this.groupBoxButonlar.TabStop = false;
            this.groupBoxButonlar.Text = "İşlem Menüsü";
            // 
            // btn_Yazdir
            // 
            this.btn_Yazdir.Image = global::RentCar.UserInterface.Properties.Resources.yazdir;
            this.btn_Yazdir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Yazdir.Location = new System.Drawing.Point(637, 14);
            this.btn_Yazdir.Name = "btn_Yazdir";
            this.btn_Yazdir.Size = new System.Drawing.Size(75, 55);
            this.btn_Yazdir.TabIndex = 2;
            this.btn_Yazdir.Text = "Yazdır";
            this.btn_Yazdir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Yazdir.UseVisualStyleBackColor = true;
            // 
            // btn_QRCodeOlustur
            // 
            this.btn_QRCodeOlustur.Image = global::RentCar.UserInterface.Properties.Resources.qr;
            this.btn_QRCodeOlustur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QRCodeOlustur.Location = new System.Drawing.Point(346, 14);
            this.btn_QRCodeOlustur.Name = "btn_QRCodeOlustur";
            this.btn_QRCodeOlustur.Size = new System.Drawing.Size(132, 55);
            this.btn_QRCodeOlustur.TabIndex = 3;
            this.btn_QRCodeOlustur.Text = "QR Code Oluştur";
            this.btn_QRCodeOlustur.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_QRCodeOlustur.UseVisualStyleBackColor = true;
            // 
            // btn_ExcelAktar
            // 
            this.btn_ExcelAktar.Image = global::RentCar.UserInterface.Properties.Resources.excel_icob;
            this.btn_ExcelAktar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ExcelAktar.Location = new System.Drawing.Point(501, 14);
            this.btn_ExcelAktar.Name = "btn_ExcelAktar";
            this.btn_ExcelAktar.Size = new System.Drawing.Size(113, 55);
            this.btn_ExcelAktar.TabIndex = 4;
            this.btn_ExcelAktar.Text = "Excel\'e Aktar";
            this.btn_ExcelAktar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ExcelAktar.UseVisualStyleBackColor = true;
            // 
            // btn_Sil
            // 
            this.btn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.Image = global::RentCar.UserInterface.Properties.Resources.Sil;
            this.btn_Sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sil.Location = new System.Drawing.Point(244, 14);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(79, 55);
            this.btn_Sil.TabIndex = 5;
            this.btn_Sil.Text = "SİL";
            this.btn_Sil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Duzenle
            // 
            this.btn_Duzenle.Image = global::RentCar.UserInterface.Properties.Resources.Guncelle;
            this.btn_Duzenle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Duzenle.Location = new System.Drawing.Point(128, 14);
            this.btn_Duzenle.Name = "btn_Duzenle";
            this.btn_Duzenle.Size = new System.Drawing.Size(93, 55);
            this.btn_Duzenle.TabIndex = 6;
            this.btn_Duzenle.Text = "Düzenle";
            this.btn_Duzenle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Duzenle.UseVisualStyleBackColor = true;
            this.btn_Duzenle.Click += new System.EventHandler(this.btn_Duzenle_Click);
            // 
            // btn_Renkendir
            // 
            this.btn_Renkendir.Image = global::RentCar.UserInterface.Properties.Resources.RenklendirDogruBoyut;
            this.btn_Renkendir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Renkendir.Location = new System.Drawing.Point(8, 14);
            this.btn_Renkendir.Name = "btn_Renkendir";
            this.btn_Renkendir.Size = new System.Drawing.Size(97, 55);
            this.btn_Renkendir.TabIndex = 7;
            this.btn_Renkendir.Text = "Renklendir";
            this.btn_Renkendir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Renkendir.UseVisualStyleBackColor = true;
            // 
            // AracListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 582);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.chk_AktifEt);
            this.Controls.Add(this.groupBoxButonlar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AracListesi";
            this.Text = "AracListesi";
            this.Load += new System.EventHandler(this.AracListesi_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTumAraclar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMusaitAraclar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridKiradakiAraclar)).EndInit();
            this.groupBoxButonlar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chk_AktifEt;
        private System.Windows.Forms.GroupBox groupBoxButonlar;
        private System.Windows.Forms.Button btn_Yazdir;
        private System.Windows.Forms.Button btn_QRCodeOlustur;
        private System.Windows.Forms.Button btn_ExcelAktar;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Duzenle;
        private System.Windows.Forms.Button btn_Renkendir;
        private System.Windows.Forms.DataGridView DataGridTumAraclar;
        private System.Windows.Forms.DataGridView DataGridMusaitAraclar;
        private System.Windows.Forms.DataGridView DataGridKiradakiAraclar;
    }
}