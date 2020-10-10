namespace RentCar.UserInterface
{
    partial class MailGonder
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
            this.btn_OzelMailGonder = new System.Windows.Forms.Button();
            this.txt_Icerik = new System.Windows.Forms.TextBox();
            this.txt_Baslik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_StandartSablon = new System.Windows.Forms.Button();
            this.btn_OzelSablon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_isim = new System.Windows.Forms.Label();
            this.lbl_soyisim = new System.Windows.Forms.Label();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_mail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbl_soyisim);
            this.groupBox1.Controls.Add(this.lbl_isim);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_OzelMailGonder);
            this.groupBox1.Controls.Add(this.txt_Icerik);
            this.groupBox1.Controls.Add(this.txt_Baslik);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 376);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Özel Mail";
            // 
            // btn_OzelMailGonder
            // 
            this.btn_OzelMailGonder.Location = new System.Drawing.Point(104, 326);
            this.btn_OzelMailGonder.Name = "btn_OzelMailGonder";
            this.btn_OzelMailGonder.Size = new System.Drawing.Size(95, 41);
            this.btn_OzelMailGonder.TabIndex = 2;
            this.btn_OzelMailGonder.Text = "Gönder";
            this.btn_OzelMailGonder.UseVisualStyleBackColor = true;
            this.btn_OzelMailGonder.Click += new System.EventHandler(this.btn_OzelMailGonder_Click);
            // 
            // txt_Icerik
            // 
            this.txt_Icerik.Location = new System.Drawing.Point(51, 144);
            this.txt_Icerik.Multiline = true;
            this.txt_Icerik.Name = "txt_Icerik";
            this.txt_Icerik.Size = new System.Drawing.Size(210, 169);
            this.txt_Icerik.TabIndex = 1;
            // 
            // txt_Baslik
            // 
            this.txt_Baslik.Location = new System.Drawing.Point(51, 111);
            this.txt_Baslik.Name = "txt_Baslik";
            this.txt_Baslik.Size = new System.Drawing.Size(210, 20);
            this.txt_Baslik.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(11, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "İçerik";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(13, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlık";
            // 
            // btn_StandartSablon
            // 
            this.btn_StandartSablon.Location = new System.Drawing.Point(26, 12);
            this.btn_StandartSablon.Name = "btn_StandartSablon";
            this.btn_StandartSablon.Size = new System.Drawing.Size(119, 76);
            this.btn_StandartSablon.TabIndex = 5;
            this.btn_StandartSablon.Text = "Standart Şablon";
            this.btn_StandartSablon.UseVisualStyleBackColor = true;
            this.btn_StandartSablon.Click += new System.EventHandler(this.btn_StandartSablon_Click);
            // 
            // btn_OzelSablon
            // 
            this.btn_OzelSablon.Location = new System.Drawing.Point(160, 11);
            this.btn_OzelSablon.Name = "btn_OzelSablon";
            this.btn_OzelSablon.Size = new System.Drawing.Size(119, 76);
            this.btn_OzelSablon.TabIndex = 5;
            this.btn_OzelSablon.Text = "Yeni Özel Şablon";
            this.btn_OzelSablon.UseVisualStyleBackColor = true;
            this.btn_OzelSablon.Click += new System.EventHandler(this.btn_OzelSablon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(28, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Müşteri Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(8, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Müşteri Soyadı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(9, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Müşteri E-Mail:";
            // 
            // lbl_isim
            // 
            this.lbl_isim.AutoSize = true;
            this.lbl_isim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_isim.ForeColor = System.Drawing.Color.Blue;
            this.lbl_isim.Location = new System.Drawing.Point(101, 28);
            this.lbl_isim.Name = "lbl_isim";
            this.lbl_isim.Size = new System.Drawing.Size(11, 15);
            this.lbl_isim.TabIndex = 3;
            this.lbl_isim.Text = "-";
            // 
            // lbl_soyisim
            // 
            this.lbl_soyisim.AutoSize = true;
            this.lbl_soyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_soyisim.ForeColor = System.Drawing.Color.Blue;
            this.lbl_soyisim.Location = new System.Drawing.Point(101, 52);
            this.lbl_soyisim.Name = "lbl_soyisim";
            this.lbl_soyisim.Size = new System.Drawing.Size(11, 15);
            this.lbl_soyisim.TabIndex = 3;
            this.lbl_soyisim.Text = "-";
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_mail.ForeColor = System.Drawing.Color.Blue;
            this.lbl_mail.Location = new System.Drawing.Point(101, 78);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(11, 15);
            this.lbl_mail.TabIndex = 3;
            this.lbl_mail.Text = "-";
            // 
            // MailGonder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(315, 492);
            this.Controls.Add(this.btn_OzelSablon);
            this.Controls.Add(this.btn_StandartSablon);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "MailGonder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Mail Gönderme";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_StandartSablon;
        private System.Windows.Forms.Button btn_OzelSablon;
        private System.Windows.Forms.TextBox txt_Icerik;
        private System.Windows.Forms.TextBox txt_Baslik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_OzelMailGonder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbl_mail;
        public System.Windows.Forms.Label lbl_soyisim;
        public System.Windows.Forms.Label lbl_isim;
    }
}