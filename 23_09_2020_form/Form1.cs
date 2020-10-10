using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace _23_09_2020_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sql = new SqlConnection("Data Source=TC;Initial Catalog=OGRENCİLER;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void Gir()
        {

            sql.Open();
            SqlCommand komut = new SqlCommand("select *from Firma", sql);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = reader["AdiSoyadi"].ToString();
                ekle.SubItems.Add(reader["Firmaa"].ToString());
                ekle.SubItems.Add(reader["Sira"].ToString());
                listView1.Items.Add(ekle);
            }
            sql.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql.Open();
            SqlCommand komut = new SqlCommand("Insert into Firma (AdiSoyadi,Firmaa,Sira) Values('"+textBox1.Text.ToString()+"','" +textBox2.Text.ToString()+"','"+textBox3.Text.ToString()+"')",sql);
            komut.ExecuteNonQuery();
            sql.Close();
            Gir();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        int id = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            sql.Open();
            SqlCommand komut = new SqlCommand("Delete From Firma where id =(" + id + ")" + sql);
            komut.ExecuteNonQuery();
            sql.Close();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        private void listView1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
