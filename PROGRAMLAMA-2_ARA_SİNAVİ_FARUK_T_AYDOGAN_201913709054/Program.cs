using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMLAMA_2_ARA_SİNAVİ_FARUK_T_AYDOGAN_201913709054
{
    class Program
    {
        static void Main(string[] args)
        {
            Cevap cv = new Cevap();
            //a.main_hesapla();
            string islem;
            Console.Write("Toplama:t, Ortalama:o, Çift sayıların adedi: ç\nyapmak istediğiniz işlemi seçiniz : ");
            islem = Console.ReadLine();
            while ((islem != "o") && islem != "ç" && islem != "t")
            {
                Console.Write("Yanlış bir seçim yaptınız. Tekrar seçim yapınız : ");
                islem = Console.ReadLine();

            }
            cv.Hesapla(islem, 5, 6, 7, 11, 13);


        }

    }
    class Cevap
    {
        public  void  Hesapla(string x, params int[] sayılar)
        {
            double sayac = 0;
            if (x == "ç")
            {
                for (int i = 0; i < sayılar.Length; i++)
                {
                    if (sayılar[i] % 2 == 0)
                    {
                        sayac++;
                    }
                }
                Console.WriteLine("Çift sayılar adedi = {0}",sayac);
            }
            else if (x == "o")
            {
                for (int i = 0; i < sayılar.Length; i++)
                {
                    sayac += sayılar[i];
                }
                sayac = sayac / sayılar.Length;
                Console.WriteLine("ortalama sonucu = {0}", sayac);
            }
            else
            {
                for (int i = 0; i < sayılar.Length; i++)
                {
                    sayac += sayılar[i];
                }
                Console.WriteLine("Toplama sonucu = {0}", sayac);
            }
            Console.ReadLine();
        } 
       public  void main_hesapla()
        {
            Console.WriteLine("bir işlem  seçiniz \n Kök alma(s)\nÜs alma(p) ");

            string y = Console.ReadLine();
            double[] dizi = new double[100];
            Random rnd = new Random();
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(1, 100);


            }
            Console.WriteLine("kaçıncı dizi elamanını  görmek istersiniz");
            int x = Convert.ToInt32(Console.ReadLine());
            x++;

            double gonderilen = hesapla(dizi[x], y);
            Console.WriteLine($"Orjinal dizi elemanı = {dizi[x]}  \n İşlemden sonraki dizi elemanı {gonderilen}");
        }
       static double hesapla(double x, string y)
        {

            if (y == "p" || y == "P")
            {
                x = Math.Pow(x, 2);

            }
            else if (y == "s" || y == "S")
            {
                x = Math.Sqrt(x);
            }
            else
            {
                Console.WriteLine("yanlış bir tuşa bastınız");
            }

            return x;
        }
   }
}
