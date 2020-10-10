using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınav_defteri
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int sayi, yüzler, onlar, birler; 
            Console.Write("3 BASAMAKLI SAYI GİRİNİZ : ");
            sayi = Convert.ToInt32 (Console.ReadLine());

            yüzler = sayi / 100;
            sayi = sayi - (yüzler * 100);
            onlar = sayi / 10;
            sayi = sayi - (onlar * 10);
            birler = sayi  ;
            Console.Write("yüzler basamağı = {0} onlar = {1} birler {2}  " , yüzler , onlar , birler);*/
            
            double toplam = 0, komisyonmiktarı = 0;
            for (int i = 1; i <= 5; i++)

            {

                Console.WriteLine("miktar ");

                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi == 50)
                {
                    komisyonmiktarı = (0.03 * sayi); Console.WriteLine("{0}.KOMİSYON TUTAR {1}", i, komisyonmiktarı)
                          ; toplam += komisyonmiktarı;
                }
                else if (sayi > 50)
                {
                    komisyonmiktarı = (0.02 * sayi);
                    Console.WriteLine("{0}. KOMİSYON MİKTARİ {1}", i, sayi * (2 / 100)); toplam += komisyonmiktarı;
                }
                else { Console.WriteLine("YANLIŞ GİRDİNİZ."); i--; }

            }

            //Console.WriteLine("TOPLAM KOMİSYON = {0} "); 

            //double malFiyati = 0, komisyonMiktari = 0, toplamKomisyon = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("{0}. Malın Fiyatını Giriniz : ", i + 1);
            //    malFiyati = Convert.ToDouble(Console.ReadLine());
            //    if (malFiyati > 50) komisyonMiktari = malFiyati * 0.02;
            //    else komisyonMiktari = malFiyati * 0.03;
            //    Console.WriteLine("{0}. Mal İçin Komisyon Miktarı : {1}", i + 1, komisyonMiktari);
            //    toplamKomisyon += komisyonMiktari;
            //}
            //Console.WriteLine("Toplam Komisyon Miktarı : {0}", toplamKomisyon);


        }
    }
}

