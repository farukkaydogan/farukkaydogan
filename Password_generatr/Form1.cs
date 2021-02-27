using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Password_generatr
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
        public string [] Pass()
        {
            Random rnd = new Random();
            string[] dizi = new string[20];
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = ((char)rnd.Next(33, 123)).ToString();
            }
            return dizi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            string [] pass= Pass();
            foreach (var item in pass)
            {
                textBox2.Text += item;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fileName = @"C:\\Users\\faruk\\OneDrive\\yeni.txt";


            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            fs.Close();
            File.AppendAllText(fileName, Environment.NewLine+ "\n"+textBox1.Text + ": " + textBox2.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("C:\\Users\\faruk\\OneDrive\\yeni.txt");
            
            listBox1.Items.Add("\n"+sr.ReadToEnd());
            sr.Close();
            textBox1.Clear();
            textBox2.Clear();
            
        }
    }
}
