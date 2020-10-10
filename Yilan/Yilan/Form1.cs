using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Yilan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        yilan yilanimiz;
        Yon  yonumuz;
        PictureBox[] pb_yilanparcalari;
        bool yem_varmi = false;
        Random rastg = new Random();
        PictureBox pb_yem;
        int skor = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            yeni_oyun();
        }
        private void yeni_oyun()
        {
            yem_varmi = false;
            skor = 0;
            yilanimiz = new yilan();
            yonumuz = new Yon(-10, 0);
            pb_yilanparcalari = new PictureBox[0];
            for (int i = 0; i < 3; i++)
            {
                Array.Resize(ref pb_yilanparcalari, pb_yilanparcalari.Length + 1);
                pb_yilanparcalari[i] = Pb_ekle();
            }
            timer1.Start();
            button1.Enabled = false;
        }
        private PictureBox Pb_ekle()
        {
            
            PictureBox pb = new PictureBox();
            pb.Size = new Size(10, 10);
            pb.BackColor = Color.White;
            pb.Location = yilanimiz.GetPos(pb_yilanparcalari.Length - 1);
            panel1.Controls.Add(pb);
            return pb;
        }
        private void Pb_guncelle()
        {
            for (int i = 0; i < pb_yilanparcalari.Length; i++)
            {
                pb_yilanparcalari[i].Location = yilanimiz.GetPos(i);
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                if (yonumuz._y != 10)
                {
                    yonumuz = new Yon(0, -10);
                }
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                if (yonumuz._y != -10)
                {
                    yonumuz = new Yon(0, 10);
                }
            }
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                if (yonumuz._x != 10)
                {
                    yonumuz = new Yon(-10, 0);
                }
            }
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                if (yonumuz._x != -10)
                {
                    yonumuz = new Yon(10, -0);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Skor: " + skor.ToString();
            yilanimiz.İlerle(yonumuz);
            Pb_guncelle();
            Yem_olustur();
            Yem_yedi_mi();
            Yilan_kendine_Carpti();
            Duvarlara_Carpti();
        }
        public void Yem_olustur()
        {
            if (!yem_varmi)
            {
                PictureBox pb = new PictureBox();
                pb.BackColor = Color.Red;
                pb.Size = new Size(10, 10);
                pb.Location = new Point(rastg.Next(panel1.Width / 10) * 10, rastg.Next(panel1.Height / 10) * 10);
                pb_yem = pb;
                yem_varmi = true;
                panel1.Controls.Add(pb);

            }
        }
        public void Yem_yedi_mi()
        {
            if (yilanimiz.GetPos(0) == pb_yem.Location)
            {
                skor += 10;
                yilanimiz.Buyu();
                Array.Resize(ref pb_yilanparcalari, pb_yilanparcalari.Length + 1);
                pb_yilanparcalari[pb_yilanparcalari.Length - 1] = Pb_ekle();
                yem_varmi = false;
                panel1.Controls.Remove(pb_yem);
            }
        }
        public void Yilan_kendine_Carpti()
        { 
            for (int i = 1; i < yilanimiz.Yilan_buyuklugu; i++)
			{
                if (yilanimiz.GetPos(0) == yilanimiz.GetPos(i))
                {
                    Yenildi();
                }
			}
        

        }
        public void Duvarlara_Carpti()
        {
            Point p = yilanimiz.GetPos(0);
            if (p.X < 0 || p.X > panel1.Width - 10 || p.Y < 0 || p.Y > panel1.Height - 10)
            {
                Yenildi();
            }
        }
        private void Yenildi()
        {
            timer1.Stop();
            MessageBox.Show("Oyun Bitti.Yenildin");
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            yeni_oyun();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
