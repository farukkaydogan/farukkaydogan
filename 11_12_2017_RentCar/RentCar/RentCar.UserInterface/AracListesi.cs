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

namespace RentCar.UserInterface
{
    public partial class AracListesi : Form
    {
        public AracListesi()
        {
            InitializeComponent();
        }

        int id;
       
        RentCarDBEntities db = new RentCarDBEntities();
        
        public static Bitmap resimCevir(byte[] byt)
        {
            MemoryStream ms = new MemoryStream();
            byte[] resimData = byt;
            ms.Write(resimData, 0, Convert.ToInt32(resimData.Length));
            Bitmap bm = new Bitmap(ms, false);
            ms.Dispose();
            return bm;
        }
        
        #region DataGridView İşlemleri

        public void TumAracListesi()
        {
            var liste = db.TBL_Araclar.Select(x => new
            {
                ID = x.ID,
                Plaka = x.Plaka,
                Marka = x.Marka,
                Model = x.Model,
                Yıl = x.Yil,
                Yakıt = x.Yakit,
                Vites = x.Vites,
                Kilometre = x.SonKM,
                MotorGücü = x.MotorGucu,
                Cekiş = x.Cekis,
                Kapı = x.Kapi,
                KasaTipi = x.KasaTipi,
                Renk = x.Renk,
                Hasar = x.HasarDurumu,
                KiraDurumu = x.KiraDurumu,
                Resim = x.Resim

            }).ToList();

            DataGridTumAraclar.DataSource = liste;
            DataGridTumAraclar.Columns["ID"].Visible = false;
            DataGridTumAraclar.Columns["Resim"].Visible = false;
        }

        public void MusaitAracListesi()
        {
            var liste = db.TBL_Araclar.Select(x => new
            {
                ID = x.ID,
                Plaka = x.Plaka,
                Marka = x.Marka,
                Model = x.Model,
                Yıl = x.Yil,
                Yakıt = x.Yakit,
                Vites = x.Vites,
                Kilometre = x.SonKM,
                MotorGücü = x.MotorGucu,
                Cekiş = x.Cekis,
                Kapı = x.Kapi,
                KasaTipi = x.KasaTipi,
                Renk = x.Renk,
                Hasar = x.HasarDurumu,
                KiraDurumu = x.KiraDurumu,
                Resim = x.Resim

            }).Where(x => x.KiraDurumu == false).ToList();

            DataGridMusaitAraclar.DataSource = liste;
            DataGridMusaitAraclar.Columns["ID"].Visible = false;
            DataGridMusaitAraclar.Columns["Resim"].Visible = false;
            DataGridMusaitAraclar.Columns["Yakıt"].Visible = false;
            DataGridMusaitAraclar.Columns["Vites"].Visible = false;
            DataGridMusaitAraclar.Columns["Kilometre"].Visible = false;
            DataGridMusaitAraclar.Columns["KasaTipi"].Visible = false;
            DataGridMusaitAraclar.Columns["Renk"].Visible = false;
            DataGridMusaitAraclar.Columns["Hasar"].Visible = false;
            DataGridMusaitAraclar.Columns["KiraDurumu"].Visible = false;
            DataGridMusaitAraclar.Columns["MotorGücü"].Visible = false;
            DataGridMusaitAraclar.Columns["Cekiş"].Visible = false;
            DataGridMusaitAraclar.Columns["Kapı"].Visible = false;
        }

        public void KiradakiAracListesi()
        {
            var liste = db.TBL_Araclar.Select(x => new
            {
                ID = x.ID,
                Plaka = x.Plaka,
                Marka = x.Marka,
                Model = x.Model,
                Yıl = x.Yil,
                Yakıt = x.Yakit,
                Vites = x.Vites,
                Kilometre = x.SonKM,
                MotorGücü = x.MotorGucu,
                Cekiş = x.Cekis,
                Kapı = x.Kapi,
                KasaTipi = x.KasaTipi,
                Renk = x.Renk,
                Hasar = x.HasarDurumu,
                KiraDurumu = x.KiraDurumu,
                Resim = x.Resim

            }).Where(x => x.KiraDurumu == true).ToList();

            DataGridKiradakiAraclar.DataSource = liste;
            DataGridKiradakiAraclar.Columns["ID"].Visible = false;
            DataGridKiradakiAraclar.Columns["Resim"].Visible = false;
            DataGridKiradakiAraclar.Columns["Yakıt"].Visible = false;
            DataGridKiradakiAraclar.Columns["Vites"].Visible = false;
            DataGridKiradakiAraclar.Columns["Kilometre"].Visible = false;
            DataGridKiradakiAraclar.Columns["KasaTipi"].Visible = false;
            DataGridKiradakiAraclar.Columns["Renk"].Visible = false;
            DataGridKiradakiAraclar.Columns["Hasar"].Visible = false;
            DataGridKiradakiAraclar.Columns["KiraDurumu"].Visible = false;
            DataGridKiradakiAraclar.Columns["MotorGücü"].Visible = false;
            DataGridKiradakiAraclar.Columns["Cekiş"].Visible = false;
            DataGridKiradakiAraclar.Columns["Kapı"].Visible = false;
        }

        public void BilgiAktar()
        {
            DataGridViewRow row = DataGridTumAraclar.CurrentRow;
            YeniArac arac = new YeniArac();
            id = Convert.ToInt32(row.Cells["ID"].Value);
            arac.txtPlaka.Text = row.Cells["Plaka"].Value.ToString();
            arac.txtMarka.Text = row.Cells["Marka"].Value.ToString();
            arac.txtModel.Text = row.Cells["Model"].Value.ToString();
            arac.txtYil.Text = row.Cells["Yıl"].Value.ToString();
            arac.txtYakit.Text = row.Cells["Yakıt"].Value.ToString();
            arac.txtVites.Text = row.Cells["Vites"].Value.ToString();
            arac.txtSonKm.Text = row.Cells["Kilometre"].Value.ToString();
            arac.txtMotorGucu.Text = row.Cells["MotorGücü"].Value.ToString();
            arac.txtCekisTuru.Text = row.Cells["Cekiş"].Value.ToString();
            arac.txtKapiSayisi.Text = row.Cells["Kapı"].Value.ToString();
            arac.txtKasaTipi.Text = row.Cells["KasaTipi"].Value.ToString();
            arac.txtRenk.Text = row.Cells["Renk"].Value.ToString();

            if (row.Cells["Hasar"].Value.ToString() == "Var")
            {
                arac.rdo_HasarVar.Checked = true;
            }

            else
            {
                arac.rdo_HasarYok.Checked = true;
            }


            var resimGuncelle = db.TBL_Araclar.Where(x => x.ID == id).FirstOrDefault();

            if (row.Cells["Resim"].Value != null)
            {
                arac.pictureBox1.Image = resimCevir(resimGuncelle.Resim);
            }

            else if (row.Cells["Resim"].Value == null)
            {
                arac.pictureBox1.Image = null;
            }
            
            arac.lbl_ID.Text = row.Cells["ID"].Value.ToString();

            arac.btn_Kaydet.Text = "Düzenle";
            arac.Text = "Araç Düzenleme";

            arac.ShowDialog();
        }

        #endregion

        private void chk_AktifEt_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_AktifEt.Checked == true)
            {
                groupBoxButonlar.Enabled = true;
            }

            else
            {
                groupBoxButonlar.Enabled = false;
            }
        }

        private void AracListesi_Load(object sender, EventArgs e)
        {
            TumAracListesi();
            KiradakiAracListesi();
            MusaitAracListesi();
        }
        
        private void btn_Duzenle_Click(object sender, EventArgs e)
        {

            BilgiAktar();

        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {

            DialogResult cevap = MessageBox.Show("Silmek İstediğinden Emin Misin?", "UYARI!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            try
            {
                if (cevap == DialogResult.Yes)
                {
                    TBL_Araclar sil = db.TBL_Araclar.Where(x => x.ID == id).FirstOrDefault();
                    db.TBL_Araclar.Remove(sil);
                    int sonuc = db.SaveChanges();
                    if (sonuc == 1)
                    {
                        MessageBox.Show("Müşteri Silindi");
                        TumAracListesi();
                        KiradakiAracListesi();
                        MusaitAracListesi();
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

        private void DataGridTumAraclar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DataGridTumAraclar.CurrentRow;
            id = Convert.ToInt32(row.Cells["ID"].Value);
        }
    }
}
