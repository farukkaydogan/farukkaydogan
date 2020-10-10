using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yılan_oyunu
{
    public partial class Form1 : Form
    {
        Class1 yilanımız;
        Yon yonumuz;

        public Form1()
        {
            InitializeComponent();
        }

        Class1 yilan = new Class1();
        PictureBox[] Pb_yilan;

        private void Form1_Load(object sender, EventArgs e)
        {
            yilanımız = new Class1();
            yonumuz = new Yon(10,20);
            Pb_yilan = new PictureBox[0];
            for (int i = 0; i < 3; i++)
            {
                Array.Resize(ref Pb_yilan, Pb_yilan.Length + 1);
                Pb_yilan[i] = Pb_oluştur();
            }
           
        }
        public PictureBox Pb_oluştur()
        {
            PictureBox pb_yilan = new PictureBox();
            pb_yilan.BackColor =Color.White;
            pb_yilan.Size = new Size(10, 10);
            pb_yilan.Location = yilanımız.GetPos(Pb_yilan.Length - 1);
            return pb_yilan;

        }
private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
    }
}
