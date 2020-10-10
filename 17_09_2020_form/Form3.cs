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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] dizi = new string[5];

            listBox1.Items.Add(textBox1.Text);
            listBox1.Items.Add(textBox2.Text);
            listBox1.Items.Add(comboBox1.Text);
            listBox1.Items.Add(comboBox2.Text);

            if (checkBox1.Checked == true)
            {
                listBox1.Items.Add(" Bay");
            }
            if (checkBox2.Checked == true)
            {
                listBox1.Items.Add(" Bayan");

            }

            
            button1.Enabled = false;
        }
    }
}
