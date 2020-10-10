using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar.UserInterface
{
    public partial class MailGonder : Form
    {
        MusteriIslemleri musteri = new MusteriIslemleri();

        public MailGonder()
        {
            InitializeComponent();
        }

        private void btn_OzelSablon_Click(object sender, EventArgs e)
        {
            Size = new Size(314, 530);
           
        }

        private void btn_StandartSablon_Click(object sender, EventArgs e)
        {
            
            musteri.MailGonder(lbl_isim.Text, lbl_soyisim.Text, lbl_mail.Text, "Suphizade Rent A Car ~~ Hoşgeldiniz","Suphizade.com Sitemize Üyeliğiniz Başarıyla Gerçekleşmiştir. 7/24 Bizlere Ulaşabilirsiniz. Tel: +90 541 899 60 05");
        }

        private void btn_OzelMailGonder_Click(object sender, EventArgs e)
        {
            musteri.MailGonder(lbl_isim.Text, lbl_soyisim.Text, lbl_mail.Text, txt_Baslik.Text, txt_Icerik.Text);
        }
    }
}
