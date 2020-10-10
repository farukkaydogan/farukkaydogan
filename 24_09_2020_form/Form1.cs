using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _24_09_2020_form
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
        private void gir()
        {
            listView1.Items.Clear();
            sql.Open();
            SqlCommand komut = new SqlCommand("select *from Table_1", sql);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = reader["İD"].ToString();
                ekle.SubItems.Add(reader["KİTAPAD"].ToString());
                ekle.SubItems.Add(reader["YAZAR"].ToString());
                ekle.SubItems.Add(reader["YAYINEVİ"].ToString());
                ekle.SubItems.Add(reader["SAYFA"].ToString());
                listView1.Items.Add(ekle);
            }
            sql.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql.Open();
            SqlCommand komut = new SqlCommand("Insert into Table_1 (İD,KİTAPAD,YAZAR,YAYINEVİ,SAYFA) Values('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "')", sql);
            komut.ExecuteNonQuery();
            sql.Close();
            gir();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gir();
        }
        int id = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            sql.Open();
            SqlCommand komut = new SqlCommand("Delete from Table_1 where id = ("+id+")",sql);
            komut.ExecuteNonQuery();
            sql.Close();
            gir();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[4].Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            sql.Open();

            SqlCommand komut = new SqlCommand("update Table_1 set id='" + textBox1.Text.ToString() + "',KİTAPAD='"+textBox2.Text.ToString()+ "',YAZAR='" + textBox3.Text.ToString()+ "',YAYINEVİ='" + textBox4.Text.ToString()+ "',SAYFA='" + textBox5.Text.ToString()+"'where id=" +id+ "", sql);
            komut.ExecuteNonQuery();
            sql.Close();
            gir();
        }
    }
}
