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

namespace _29_09_2020_form
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
       public SqlConnection sql = new SqlConnection("Data Source=TC;Initial Catalog=OGRENCİLER;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            sql.Open();
            SqlCommand komut = new SqlCommand("Insert into Firmalar (Sira,AdiSoyadi,Firma) Values('" + textBox3.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox1.Text.ToString() + "')", sql);
            komut.ExecuteNonQuery();
            sql.Close();
            VeriCek();
         
        }
        int id = 0;
        private void VeriCek()
        {
            sql.Open();
            SqlCommand komut = new SqlCommand("select *from Firmalar", sql);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = reader["Sira"].ToString();
                ekle.SubItems.Add(reader["AdiSoyadi"].ToString());
                ekle.SubItems.Add(reader["Firma"].ToString());
                listView1.Items.Add(ekle);
            }
            sql.Close();
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            VeriCek();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sql.Open();
            SqlCommand komut = new SqlCommand("Delete From Firmalar where id =(" + id + ")" + sql);
            komut.ExecuteNonQuery();
            sql.Close();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox3.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox1.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
    }
}
