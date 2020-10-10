using RentCar.UserInterface.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar.UserInterface
{
    public partial class YeniArac : Form
    {
        public YeniArac()
        {
            InitializeComponent();
        }

        RentCarDBEntities db = new RentCarDBEntities();
               
        #region Resim İşlemleri

        string resimYolu;

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

        public void ResimSec()
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

        #endregion

        #region Araç İşlemleri

        public void YeniAracEkle()
        {
            try
            {
                TBL_Araclar yeniArac = new TBL_Araclar();
                yeniArac.Plaka = txtPlaka.Text;
                yeniArac.Marka = txtMarka.Text;
                yeniArac.Model = txtModel.Text;
                yeniArac.Yil = txtYil.Text;
                yeniArac.Yakit = txtYakit.Text;
                yeniArac.SonKM = txtSonKm.Text;
                yeniArac.Vites = txtVites.Text;
                yeniArac.MotorGucu = txtMotorGucu.Text;
                yeniArac.Cekis = txtCekisTuru.Text;
                yeniArac.Kapi = txtKapiSayisi.Text;
                yeniArac.KasaTipi = txtKasaTipi.Text;
                yeniArac.Renk = txtRenk.Text;
                yeniArac.KiraDurumu = false;
                yeniArac.EklenmeTarihi = DateTime.Now;

                if (rdo_HasarVar.Checked == true)
                {
                    yeniArac.HasarDurumu = rdo_HasarVar.Text;
                }

                else
                {
                    yeniArac.HasarDurumu = rdo_HasarYok.Text;
                }


                if (!string.IsNullOrEmpty(resimYolu))
                {
                    yeniArac.Resim = loadImage(resimYolu);
                }

                db.TBL_Araclar.Add(yeniArac);
                int sonuc = db.SaveChanges();
                if (sonuc == 1)
                {
                    MessageBox.Show("Araç Başarıyla Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Araç Kayıtta Hata Oluştu!");
                }
            }

            catch (Exception)
            {

                MessageBox.Show("Beklenmeyen Bir Hata Oluştu");

            }
        }

        public void AracDuzenle()
        {
            int id = Convert.ToInt32(lbl_ID.Text);
            TBL_Araclar guncelle = db.TBL_Araclar.Where(x => x.ID == id).FirstOrDefault();
            guncelle.Plaka = txtPlaka.Text;
            guncelle.Marka = txtMarka.Text;
            guncelle.Model = txtModel.Text;
            guncelle.Yil = txtYil.Text;
            guncelle.Yakit = txtYakit.Text;
            guncelle.SonKM = txtSonKm.Text;
            guncelle.Vites = txtVites.Text;
            guncelle.MotorGucu = txtMotorGucu.Text;
            guncelle.Cekis = txtCekisTuru.Text;
            guncelle.Kapi = txtKapiSayisi.Text;
            guncelle.KasaTipi = txtKasaTipi.Text;
            guncelle.Renk = txtRenk.Text;
            if (rdo_HasarVar.Checked == true)
            {
                guncelle.HasarDurumu = "Var";
            }
            else
            {
                guncelle.HasarDurumu = "Yok";
            }
            if (!string.IsNullOrEmpty(resimYolu))
            {
                guncelle.Resim = loadImage(resimYolu);
            }

            int sonuc = db.SaveChanges();
            if (sonuc == 1)
            {
                MessageBox.Show("Güncelleme Başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ARAÇ Güncellenemedi !!!  - HATA !");
            }

        }

        #endregion

        private void btn_ResimSec_Click(object sender, EventArgs e)
        {
            ResimSec();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (btn_Kaydet.Text == "Kaydet")
            {
                if (!string.IsNullOrEmpty(txtPlaka.Text))
                {
                    YeniAracEkle();
                }

                else
                {
                    MessageBox.Show("PLAKA ZORUNLU ALANDIR!");
                }
            }

            else if (btn_Kaydet.Text == "Düzenle")
            {
                AracDuzenle();
            }
        }

        private void YeniArac_Load(object sender, EventArgs e)
        {
            label14.Visible = false;
            lbl_ID.Visible = false;
        }
    }
}
