using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_09_2020_form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] dizi = new string[5];

            textBox1.Text = " "+ dizi[0];
            textBox2.Text = " "+dizi[1];
            comboBox1.Text = " " +dizi[2];
            comboBox2.Text =" "+  dizi[3];
            if (checkBox1.Checked ==true)
            {
                dizi[4] = " Bay";
            }
            if (checkBox2.Checked == true)
            {
                dizi[4] = " Bayan";
            }

            for (int i = 0; i < 5; i++)
            {
                listBox1.Items.Add(dizi[i]);
            }
            button1.Enabled = false;

        }
    }
}
