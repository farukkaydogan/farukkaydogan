using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar.UserInterface
{
    public partial class MDI_Menu : Form
    {
        public MDI_Menu()
        {
            InitializeComponent();
        }

        private void MDI_Menu_Load(object sender, EventArgs e)
        {

        }

        private void müşteriİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Butona Tıklandığında Açılacak Olan Formu Tanımladım
            MusteriIslemleri musteri = new MusteriIslemleri();

            // Müşteri Formunu, MDI Formun altında göstermek için.
            musteri.MdiParent = this;

            // Müşteri Formunun Çerçevesini Kaldırdık
            musteri.FormBorderStyle = FormBorderStyle.None;

            // Müşteri Formunun MDI_MENÜ içinde tam olarak yayılması için
            musteri.Dock = DockStyle.Fill;

            // Müşteri Formunu Açtık
            musteri.Show();
        }

        private void yeniAraçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniArac yeniArac = new YeniArac();
            yeniArac.ShowDialog();
        }

        private void araçListesiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AracListesi aracListesi = new AracListesi();
            aracListesi.MdiParent = this;
            aracListesi.FormBorderStyle = FormBorderStyle.None;
            aracListesi.Dock = DockStyle.Fill;
            aracListesi.Show();
        }

        private void araçKiralaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AracKirala aracKirala = new AracKirala();
            aracKirala.MdiParent = this;
            aracKirala.FormBorderStyle = FormBorderStyle.None;
            aracKirala.Dock = DockStyle.Fill;
            aracKirala.Show();
        }
    }
}
