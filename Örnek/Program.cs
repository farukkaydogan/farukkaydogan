using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Programlama Lab 2 Ödevi 1.Soru");
            Console.Write("kelime giriniz:  ");
            string kelime = Console.ReadLine();
            string sonuc = kelimesifrele(kelime);
            Console.WriteLine(sonuc);
            char[] şifre = kelimesifreleme(kelime.ToString());
            Console.Write("Şifre: ");
            foreach (var item in şifre)
            {
                Console.Write(item);
            }
        }
        public static string kelimesifrele(string x)
        {
            string yenikelime = "";
            for (int i = 0; i < x.Length; i++)
            {
                yenikelime += "*" + x[i];
            }
            return yenikelime;
        }
        public static char[] kelimesifreleme(string x)
        {
            char[] şifrele = new char[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                şifrele[i] = x[i];
                şifrele[i] = (char)(şifrele[i] + 1);
            }
            return şifrele;
        }



       




        static void Main(string[] args)
        {
            Console.WriteLine("2)  birer boşluk bırakarak hesaplamasını istediğiniz alanı giriniz");
            string input = Console.ReadLine();
            string[] dizi = input.Split();
            if (dizi.Length > 3)
                Console.WriteLine("yanlış girdiniz");
            else if (dizi.Length == 3)
                küp(Convert.ToInt32(dizi[0]), Convert.ToInt32(dizi[1]), Convert.ToInt32(dizi[2]));
            else if (dizi.Length == 2)
                küp(Convert.ToInt32(dizi[0]), Convert.ToInt32(dizi[1]));
            else
                küp(Convert.ToInt32(dizi[0]));
        }
        static void küp(int r)
        {
            r = r * r * r;
            Console.WriteLine($"küpün hacmi =  {r,6}");
            Console.ReadLine();
        }
        static void küp(int r, int h)
        {
            double hacim = r * r * h * Math.PI;
            Console.WriteLine(" silindirin hacmi =  " + hacim);
            Console.ReadLine();
        }
        static void küp(int x, int y, int z)
        {
            int hacim = x * y * z;
            Console.WriteLine("dikdörtgenin hacmi =  " + hacim);
            Console.ReadLine();
        }
       






    static void Main(string[] args)
    {
        Console.WriteLine("3)  Değişken sayıda int tipinde parametre alarak bu sayılarının arasından minimum ve maksimum olanları yazdıran metodu yazınız");
        paramss(65, 98, 18, 98, 99, 15, 56, 2, 9, 45, 56, 98);
    }
    static void paramss(params int[] sayılar)
    {
        int min = 100, max = 0;
        for (int i = 0; i < sayılar.Length; i++)
        {
            if (sayılar[i] < 0 || sayılar[i] > 100)
                Console.WriteLine("yanlış bir sayı girildi");
            else
            {
                for (int j = 0; j < sayılar.Length; j++)
                {
                    if (sayılar[j] > max)
                    {
                        max = sayılar[j];
                    }
                    if (sayılar[j] < min)
                    {
                        min = sayılar[j];
                    }
                }
            }
        }
        Console.WriteLine($"en küçük = {min} en büyük = {max}");
        Console.ReadLine();
    }
  





        static void Main(string[] args)
        {
            Console.Write("4) Metni giriniz:  ");
            string metin = Console.ReadLine();
            string result = ceviri(metin);
            Console.WriteLine("Çevrilmiş Metin : "+result);
            Console.ReadLine();
        }
        static string ceviri(string metin)
        {
            string yenimetin = "";
            for (int i = metin.Length; i > 0; i--)
            {
                yenimetin += metin[i - 1];
            }
            return yenimetin;
        }

    }
}
