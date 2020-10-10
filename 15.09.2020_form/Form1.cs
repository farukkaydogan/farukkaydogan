using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15._09._2020_form
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

        private void button1_Click(object sender, EventArgs e)
        {
            double sayı1, sayı2;
            sayı1 = Convert.ToDouble(textBox1.Text);
            sayı2 = Convert.ToDouble(textBox2.Text);
            double toplam = sayı1 + sayı2;
            double fark = sayı1 - sayı2;
            double carpım = sayı1 * sayı2;
            double bolme = sayı1 / sayı2;
            label10.Text= toplam.ToString();
            label9.Text = fark.ToString();
            label8.Text = carpım.ToString();
            label7.Text = bolme.ToString();

            
        }
    }
}
