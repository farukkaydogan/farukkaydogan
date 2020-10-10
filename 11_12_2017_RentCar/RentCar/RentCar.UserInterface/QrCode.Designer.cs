namespace RentCar.UserInterface
{
    partial class QrCode
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_Kapat = new System.Windows.Forms.Button();
            this.btn_QrCodeResimKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 241);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Kapat
            // 
            this.btn_Kapat.Image = global::RentCar.UserInterface.Properties.Resources.Sil;
            this.btn_Kapat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Kapat.Location = new System.Drawing.Point(136, 269);
            this.btn_Kapat.Name = "btn_Kapat";
            this.btn_Kapat.Size = new System.Drawing.Size(85, 45);
            this.btn_Kapat.TabIndex = 4;
            this.btn_Kapat.Text = "KAPAT";
            this.btn_Kapat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Kapat.UseVisualStyleBackColor = true;
            this.btn_Kapat.Click += new System.EventHandler(this.btn_Kapat_Click);
            // 
            // btn_QrCodeResimKaydet
            // 
            this.btn_QrCodeResimKaydet.Image = global::RentCar.UserInterface.Properties.Resources.Save_icon;
            this.btn_QrCodeResimKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QrCodeResimKaydet.Location = new System.Drawing.Point(36, 269);
            this.btn_QrCodeResimKaydet.Name = "btn_QrCodeResimKaydet";
            this.btn_QrCodeResimKaydet.Size = new System.Drawing.Size(83, 45);
            this.btn_QrCodeResimKaydet.TabIndex = 5;
            this.btn_QrCodeResimKaydet.Text = "KAYDET";
            this.btn_QrCodeResimKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_QrCodeResimKaydet.UseVisualStyleBackColor = true;
            this.btn_QrCodeResimKaydet.Click += new System.EventHandler(this.btn_QrCodeResimKaydet_Click);
            // 
            // QrCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(254, 324);
            this.Controls.Add(this.btn_Kapat);
            this.Controls.Add(this.btn_QrCodeResimKaydet);
            this.Controls.Add(this.pictureBox1);
            this.Name = "QrCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QrCode";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Kapat;
        private System.Windows.Forms.Button btn_QrCodeResimKaydet;
    }
}