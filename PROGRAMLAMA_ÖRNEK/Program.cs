using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMLAMA_ÖRNEK
{
    /*  class Program
      {
          static void Main(string[] args)
          {
              Cevap cv = new Cevap();
              string islem;
              Console.Write("Toplama:t, Ortalama:o, Çift sayıların adedi: ç\nyapmak istediğiniz işlemi seçiniz : ");
              islem = Console.ReadLine();
              while ((islem != "o") && islem =="Ç"&& islem == "O" && islem == "T" && islem != "ç" && islem != "t")
              {
                  Console.Write("Yanlış bir seçim yaptınız. Tekrar seçim yapınız : ");
                  islem = Console.ReadLine();
              }
              cv.Hesapla(islem, 5, 6, 7, 11, 13);
          }
      }
      class Cevap
      {
          public void Hesapla(string x, params int[] sayılar)
          {
              double sayac = 0;
              if (x == "ç" || x=="Ç")
              {
                  for (int i = 0; i < sayılar.Length; i++)
                  {
                      if (sayılar[i] % 2 == 0)
                      {
                          sayac++;
                      }
                  }
                  Console.WriteLine("Çift sayılar adedi = {0}", sayac);
              }
              else if (x == "o" ||x=="O")
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


      }*/

    
        class Program
        {
            static void Main(string[] args)
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
    

    
class Program
{
    static void Main(string[] args)
    {
        Console.Write("İlk borcu giriniz : ");
        int ilk = Convert.ToInt32(Console.ReadLine());
        Console.Write("Son borcu giriniz : ");
        int Son = Convert.ToInt32(Console.ReadLine());
        Console.Write("Aylık faizi girini : ");
        int faiz = Convert.ToInt32(Console.ReadLine());
        Hesap hesap = new Hesap();
        double gelen = hesap.Hesapla(ilk, Son, faiz);
        hesap.Yazdır(ilk, Son, faiz, gelen);
    }
}
}
class Hesap
{
int sayac; 
void AyHesapla()
{
    sayac++;
}
public double Hesapla(double x, double y, int faiz)
{
    for (int i = 0; x < y; i++)
    {
        Console.WriteLine(x);
        x = x + ((x / 100) * (faiz));
        AyHesapla();
    }
    return x;
}
public void Yazdır(int x, int y, int faiz, double son)
{
 Console.WriteLine($"{x} TL olan borcunuz aylık yüzde { faiz} faizle {sayac} ay sonra {y} TL yi geçerek {son}  TL olur. ");
    Console.ReadLine();
}


    class Program
    {
        static void Main(string[] args)
        {
            alanhacim sınıf = new alanhacim();
            int result = sınıf.alangir();
            double alan; double hacim; int r;
            if (result < 0)
            {
                r = 0; alan = sınıf.Alan(0); hacim = sınıf.Hacim(0);
            }
            else
            {
                r = result; alan = sınıf.Alan(result); hacim = sınıf.Hacim(result);
            }
            sınıf.yaz(alan, hacim, r);
        }
    }
    class alanhacim
    {
        public void yaz(double alan, double hacim, int r)
        {
            Console.WriteLine($"*****************\nYarıçap        :{r}\nDairenin alanı :{alan}\nKürenin hacmi  :{hacim}\n******************");
            Console.ReadLine();
        }
        public double Alan(int x)
        {
            double Alan = Math.PI * x * x;
            return Alan;
        }
        public double Hacim(int x)
        {
            double Hacim = (4 * Math.PI * x * x * x) / 3;
            return Hacim;
        }
        public int alangir()
        {
            Console.WriteLine("Yarıçapı giriniz        :");
            int cap = Convert.ToInt32(Console.ReadLine());
            return cap;
        }
    }
}
