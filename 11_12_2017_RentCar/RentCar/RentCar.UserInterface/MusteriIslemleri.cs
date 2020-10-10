using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentCar.UserInterface.Model;
using System.IO;
using System.Net.Mail;
using System.Net;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using MessagingToolkit.QRCode.Codec;

namespace RentCar.UserInterface
{
    public partial class MusteriIslemleri : Form
    {
        public void ExcelAktar()
        {

            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dataGridView1.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {

                    Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                    myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                    myRange.Select();
                    
                }
            }
        }

        RentCarDBEntities db = new RentCarDBEntities();

        string resimYolu;

        int id;

        public void MailGonder(string isim, string soyisim, string mailAdresi, string baslik, string icerik)
        {
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            //Gönderilen Mail Kim Adına Gönderilecek
            message.From = new MailAddress("sezgin5892@gmail.com");

            // Mail hangi adrese gönderilecek
            message.To.Add(new MailAddress(mailAdresi));

            //Mail Başlığı
            message.Subject = baslik;


            //Mail Mesaj İçeriği
            message.Body = icerik;

            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;

            //Kendi mail adresimizin şifre ve kullanıcı adını yazıyoruz ki, bizim hesaba bağlanıp kullanıcıya mail atabilsin.
            smtp.Credentials = new NetworkCredential("sezgin5892@gmail.com", "123456aq");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(message);
        }

        public void MusteriListesiGetir()
        {
            var liste = db.TBL_Musteriler.Select(x => new
            {
                ID = x.ID,
                TC = x.TcNo,
                Isim = x.Isim,
                Soyisim = x.Soyisim,
                DogumTarihi = x.DogumTarihi,
                Meslek = x.DogumYeri,
                CepTelefonu = x.CepTel,
                EvTelefonu = x.EvTel,
                Email = x.Email,
                Adres = x.Adres,
                EhliyetNo = x.EhliyetNo,
                EhliyetTuru = x.EhliyetTuru,
                Notlar = x.Notlar,
                Resim = x.Resim

            }).ToList();

            dataGridView1.DataSource = liste;

            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["DogumTarihi"].Visible = false;
            dataGridView1.Columns["Meslek"].Visible = false;
            dataGridView1.Columns["Adres"].Visible = false;
            dataGridView1.Columns["Resim"].Visible = false;
            dataGridView1.Columns["Notlar"].Visible = false;
            dataGridView1.Columns["EhliyetNo"].Visible = false;
            dataGridView1.Columns["EhliyetTuru"].Visible = false;
        }

        public byte[] loadImage(string dosyayolu)
        {
            byte[] byteResim = null;

            FileInfo dosyadetay = new FileInfo(dosyayolu);

            long dosyaboyut = dosyadetay.Length;

            FileStream fStrem = new FileStream(dosyayolu, FileMode.Open, FileAccess.Read);

            BinaryReader bReader = new BinaryReader(fStrem);

            byteResim = bReader.ReadBytes((int)dosyaboyut);

            return byteResim;
        }

        public static Bitmap resimCevir(byte[] byt)
        {
            MemoryStream ms = new MemoryStream();
            byte[] resimData = byt;
            ms.Write(resimData, 0, Convert.ToInt32(resimData.Length));
            Bitmap bm = new Bitmap(ms, false);
            ms.Dispose();
            return bm;
        }

        public void YeniMusteriEkle()
        {
            TBL_Musteriler yeniMusteri = new TBL_Musteriler();
            yeniMusteri.TcNo = txtTcNo.Text;
            yeniMusteri.Isim = txtIsim.Text;
            yeniMusteri.Soyisim = txtSoyisim.Text;
            yeniMusteri.DogumTarihi = dtDogumTarihi.Value;
            yeniMusteri.DogumYeri = txtMeslek.Text;
            yeniMusteri.CepTel = txtCepTel.Text;
            yeniMusteri.EvTel = txtEvTel.Text;
            yeniMusteri.Email = txtMail.Text;
            yeniMusteri.Adres = txtAdres.Text;
            yeniMusteri.EhliyetNo = txtEhliyetNo.Text;
            yeniMusteri.EhliyetTuru = txtEhliyetTuru.Text;
            yeniMusteri.Notlar = txtNotlar.Text;

            if (!string.IsNullOrEmpty(resimYolu))
            {
                yeniMusteri.Resim = loadImage(resimYolu);
            }

            db.TBL_Musteriler.Add(yeniMusteri);
            int sonuc = db.SaveChanges();
            if (sonuc == 1)
            {
                MessageBox.Show("Müşteri Sisteme Kayıt Edildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Müşteri Kayıt Edilemedi");
            }
        }

        public Image QRCodeOlustur(string veriAl, int QrCodeDuzey)
        {
            string veri = veriAl;
            QRCodeEncoder Kodlayici = new QRCodeEncoder();
            Kodlayici.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            Kodlayici.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L;
            Kodlayici.QRCodeVersion = QrCodeDuzey;
            Bitmap bitmap = Kodlayici.Encode(veri);
            return bitmap;
        }

        string adSoyad;

        public void MusteriGuncelle()
        {
            try
            {
                TBL_Musteriler musteriGuncelle = db.TBL_Musteriler.Where(x => x.ID == id).FirstOrDefault();
                musteriGuncelle.TcNo = txtTcNo.Text;
                musteriGuncelle.Isim = txtIsim.Text;
                musteriGuncelle.Soyisim = txtSoyisim.Text;
                musteriGuncelle.DogumTarihi = dtDogumTarihi.Value;
                musteriGuncelle.DogumYeri = txtMeslek.Text;
                musteriGuncelle.CepTel = txtCepTel.Text;
                musteriGuncelle.EvTel = txtEvTel.Text;
                musteriGuncelle.Email = txtMail.Text;
                musteriGuncelle.Adres = txtAdres.Text;
                musteriGuncelle.EhliyetNo = txtEhliyetNo.Text;
                musteriGuncelle.EhliyetTuru = txtEhliyetTuru.Text;
                musteriGuncelle.Notlar = txtNotlar.Text;
                if (!string.IsNullOrEmpty(resimYolu))
                {
                    musteriGuncelle.Resim = loadImage(resimYolu);
                }

                int sonuc = db.SaveChanges();
                if (sonuc == 1)
                {
                    MessageBox.Show("Güncelleme Başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Müşteri Güncellenemedi !!!  - HATA !");
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
            }
        }

        public MusteriIslemleri()
        {
            InitializeComponent();
        }

        private void chk_AktifEt_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_AktifEt.Checked == true)
            {
                groupBox5.Enabled = true;
            }

            else
            {
                groupBox5.Enabled = false;
            }
        }

        private void btn_ResimSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Lütfen Hasta Resmini Seçiniz";
            openFileDialog1.Filter = "Resim Seç | *.jpg*";
            openFileDialog1.FileName = null;
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != "")
            {
                resimYolu = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(resimYolu);
            }
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTcNo.Text) && !string.IsNullOrEmpty(txtMail.Text))
            {
                YeniMusteriEkle();
                MusteriListesiGetir();

                DialogResult cevap = MessageBox.Show("Yeni Müşterinize Hoşgeldin Maili Gönderilsin Mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (cevap == DialogResult.Yes)
                {
                    MailGonder mail = new MailGonder();
                    mail.Size = new Size(314, 137);
                    mail.lbl_isim.Text = txtIsim.Text;
                    mail.lbl_soyisim.Text = txtSoyisim.Text;
                    mail.lbl_mail.Text = txtMail.Text;
                    mail.ShowDialog();
                }


            }
            else
            {
                MessageBox.Show("TC Numarası ve Mail Zorunlu Alandır");
            }
        }

        private void MusteriIslemleri_Load(object sender, EventArgs e)
        {
            MusteriListesiGetir();
        }

        private void btn_Duzenle_Click(object sender, EventArgs e)
        {
            MusteriGuncelle();
            MusteriListesiGetir();

        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {

            DialogResult cevap = MessageBox.Show("Silmek İstediğinden Emin Misin?", "UYARI!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            try
            {
                if (cevap == DialogResult.Yes)
                {
                    TBL_Musteriler MusteriSil = db.TBL_Musteriler.Where(x => x.ID == id).FirstOrDefault();
                    db.TBL_Musteriler.Remove(MusteriSil);
                    int sonuc = db.SaveChanges();
                    if (sonuc == 1)
                    {
                        MessageBox.Show("Müşteri Silindi");
                        MusteriListesiGetir();
                    }

                    else
                    {
                        MessageBox.Show("Bir Hata Oluştu - Tekrar Deneyin");
                    }
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            id = Convert.ToInt32(row.Cells["ID"].Value);
            txtTcNo.Text = row.Cells["TC"].Value.ToString();
            txtIsim.Text = row.Cells["Isim"].Value.ToString();
            txtSoyisim.Text = row.Cells["Soyisim"].Value.ToString();
            dtDogumTarihi.Value = Convert.ToDateTime(row.Cells["DogumTarihi"].Value);
            txtMeslek.Text = row.Cells["Meslek"].Value.ToString();
            txtCepTel.Text = row.Cells["CepTelefonu"].Value.ToString();
            txtEvTel.Text = row.Cells["EvTelefonu"].Value.ToString();
            txtMail.Text = row.Cells["Email"].Value.ToString();
            txtAdres.Text = row.Cells["Adres"].Value.ToString();
            txtEhliyetNo.Text = row.Cells["EhliyetNo"].Value.ToString();
            txtEhliyetTuru.Text = row.Cells["EhliyetTuru"].Value.ToString();
            txtNotlar.Text = row.Cells["Notlar"].Value.ToString();

            var resimGuncelle = db.TBL_Musteriler.Where(x => x.ID == id).FirstOrDefault();

            if (row.Cells["Resim"].Value != null)
            {
                pictureBox1.Image = resimCevir(resimGuncelle.Resim);
            }

            else if (row.Cells["Resim"].Value == null)
            {
                pictureBox1.Image = null;
            }
        }

        private void btn_ExcelAktar_Click(object sender, EventArgs e)
        {
            //ExcelAktar();
        }

        private void btn_QRCodeOlustur_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            string basla = "BEGIN:VCARD" + "\n";
            string versiyon = "VERSION:2.1" + "\n";
            string ad = row.Cells["Isim"].Value.ToString() + " ";
            string soy = row.Cells["Soyisim"].Value.ToString() + " ";
            string adi = "N;LANGUAGE=tr-TR;CHARSET=UTF-8:" + ad + ";" + soy + " \n";
            string tamad = ad + " " + soy;
            adSoyad = tamad;
            string ad_soy = "FN;LANGUAGE=tr-TR;CHARSET=UTF-8:" + tamad + "\n";
            string is_unvani = "TITLE:" + row.Cells["Meslek"].Value.ToString() + "\n";
            string is_tel = "TEL;TYPE=work,voice;VALUE=uri:" + row.Cells["CepTelefonu"].Value.ToString().ToString() + "\n";
            string ev_tel = "TEL;TYPE=home,voice;VALUE=uri:" + row.Cells["EvTelefonu"].Value.ToString().ToString() + "\n";
            string mail = "EMAIL;PREF;INTERNET:" + row.Cells["Email"].Value.ToString().ToString() + "\n";
            string bitir = "END:VCARD";
            string kodMetin;
            string toplam = basla + mail + versiyon + adi + ad_soy + is_unvani + is_tel + ev_tel + bitir;

            TR_Character karakterCevir = new TR_Character();
            kodMetin = karakterCevir.karakterCevir(toplam);

            QrCode frm = new QrCode();
            frm.pictureBox1.Image = QRCodeOlustur((kodMetin), 10);
            frm.ShowDialog();

        }
    }
}
