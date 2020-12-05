using System;

namespace _10_21_2020
{
    class Program
    {
        static void Main(string[] args)
        {
           KUTU kutu = new KUTU(15, 30, 80,"Sandık","tahta");
            Console.WriteLine(kutu.Hacim);
            Console.WriteLine(kutu.tur);
            Console.WriteLine(kutu.isim);
            Console.WriteLine(kutu.En);
            Console.WriteLine(kutu.Boy);
            Console.WriteLine(kutu.H);
        }
    }

    class KUTU
    {
        public string isim;
        public string tur;
        public int Hacim;
        public int Boy;  public int En; public int H;
        public KUTU(int en, int boy, int h,string isim , string tur)
        {
            Hacim = en * boy * h;
            En = en;    Boy = boy;    H = h;
            this.tur = tur;  this.isim = isim;
        }
    }

}
