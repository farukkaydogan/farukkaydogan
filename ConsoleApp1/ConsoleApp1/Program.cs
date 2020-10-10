using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("birinici sayıyı gir lan:  ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("ikinci  sayıyı gir lan:  ");
            //int b = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine("yapılacak olan işlemi seç toplama için + çıkarma için - bölme için / çarpma için * ");

            //string c = Console.ReadLine();

            //if (c == "+")
            //{
            //    Console.WriteLine("toplam:  " + a + b);

            //}


            //else if (c == "-")
            //{
            //    Console.WriteLine("çıkarma sonucu = {0} ", a - b);

            //}



            //else if (c == "/")
            //{
            //    Console.WriteLine("BÖLME SONUCU = {0 }", a / b);
            //}


            //else if (c == "*")
            //{
            //    Console.WriteLine("ÇARPMA SONUCU {0}", a * b);
            //}


            int yedek, sayi1 , sayi2 ;
            int toplam = 0, adet = 0;
            Console.Write("SAYILARI GİRİN:  ");
             sayi1 = Convert.ToInt32(Console.ReadLine());
            sayi2 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 > sayi2)
            {
                yedek = sayi1;
                sayi2 = yedek;
                sayi1 = sayi2;
                    
            }

            for (int i = sayi1; i <= sayi2; i++)
            { if((i % 2 ==0 )&& (i % 3 !=0))
                        {
                    adet++;
                    toplam= i + toplam;
                
                }
               
            }

            Console.WriteLine("{0}sayı bulundu", adet);
            Console.WriteLine("TOPLAMLARI =  {0} ", toplam);
            Console.WriteLine("ortalamaları = {0}", toplam / adet);

        }
    }
    
}
