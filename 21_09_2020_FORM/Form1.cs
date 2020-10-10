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

namespace _21_09_2020_FORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sql = new SqlConnection("Data Source=TC;Initial Catalog=OGRENCİLER;Integrated Security=True");
        private void gir()
        {
            sql.Open();
            SqlCommand komut = new SqlCommand("select *from Bilgiler",sql);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = reader["AdıSoyadı"].ToString();
                ekle.SubItems.Add(reader["Sehir"].ToString());
                listView1.Items.Add(ekle);
            }
            sql.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            gir();
        }
    }
}
