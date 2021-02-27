using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_10_2020_framework
{
    class Program
    {
        static void Main(string[] args)
        {
            KUTU kutu = new KUTU(15, 30, 80, "Sandık", "tahta");
            Console.WriteLine("Hacim : " + kutu.Hacim);
            Console.WriteLine("Tur : " + kutu.tur);
            Console.WriteLine("İsim : " + kutu.isim);
            Console.WriteLine("En : " + kutu.En);
            Console.WriteLine("Boy : " + kutu.Boy);
            Console.WriteLine("H : " + kutu.H);

        }
    }
    class KUTU
    {
        public string isim;
        public string tur;
        public int Hacim;
        public int Boy; public int En; public int H;
        public KUTU(int en, int boy, int h, string isim, string tur)
        {
            Hacim = en * boy * h;
            En = en; Boy = boy; H = h;
            this.tur = tur; this.isim = isim;
        }
    }
}
