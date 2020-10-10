using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar.UserInterface
{
    public partial class QrCode : Form
    {
        public QrCode()
        {
            InitializeComponent();
        }

        private void btn_QrCodeResimKaydet_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "QRCode_Müşteri";
            saveFileDialog1.Filter = "JPEG Dosyası (*.jpeg) |*.jpg";
            saveFileDialog1.ShowDialog();
            pictureBox1.Image.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
        }

        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
