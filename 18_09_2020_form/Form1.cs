using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_09_2020_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          int m= rnd.Next(0, 15);
            pictureBox1.Left += m;
            MEHMETISIK.Left += m;
            int muzo = rnd.Next(0, 15);
            pictureBox2.Left += muzo;
            label4.Left += muzo;

            int amet= rnd.Next(0, 15);
            pictureBox3.Left += amet;
            label1.Left += amet;
            if (pictureBox1.Left+pictureBox1.Width>=700)
            {
                timer1.Stop();
                MessageBox.Show("MEMET IŞIK KAZANDI");
            }
            else if (pictureBox2.Left+pictureBox2.Width >= 700)
            {
                timer1.Stop();
                MessageBox.Show("AMET KAZANDI");
            }
            else if (pictureBox3.Left+pictureBox3.Width >= 700)
            {
                timer1.Stop();
                MessageBox.Show("MUZO KAZANDI");
            }

        }
    }
}
