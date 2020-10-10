using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14._09._2020.form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text=="MİX")
            {
                axWindowsMediaPlayer1.URL = "http://95.173.185.128:9316/;";
            }
            else if (comboBox1.Text=="KRAL FM")
            {
                axWindowsMediaPlayer1.URL = "https://ssldyg.radyotvonline.com/kralweb/smil:kakustik.smil/playlist.m3u8";
            }
            else if (comboBox1.Text=="TE")
            {
                axWindowsMediaPlayer1.URL = "https://n10101m.mediatriple.net/videoonlylive/mtkgeuihrlfwlive/u_stream_5c9e30cf8d28e_1/playlist.m3u8 ";
            }

        }
    }
}
