
using System;

namespace _06_11_2020
{
   
    class Kisi 
    {
        public string Ad;
        public Kisi(string x)
        {
            Ad = x;
        }


        ~Kisi()
        {
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kişi kısı1 = new Kişi();
            kısı1.Ad = "efe";

            Kişi kısı2 = new Kişi();
            kısı2.Ad = "faruk";

            Kişi kısı3 = new Kişi();
            kısı3.Ad = "elif";

            Kişi kısı4 = new Kişi();
            kısı4.Ad = "elif";

            Kişi kısı5 = new Kişi();
            kısı5.Ad = "";

            Kişi kısı6 = new Kişi();
            kısı6.Ad = "eymen";

            Kişi kısı7 = new Kişi();
            kısı7.Ad = "eymen";
            string[] dizi = { kısı1.Ad, kısı2.Ad, kısı3.Ad, kısı4.Ad, kısı5.Ad, kısı6.Ad, kısı7.Ad };
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    for (int k = 1+i; k < dizi.Length; k++)
            //    {
            //        if (dizi[i] == dizi[k])
            //            Kişi.SayıcıArttır();
            //        else
            //            Kişi.SayıcıAzalt();
            //    }

            //}

            int sayac = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
               sayac+=  Kişi.degilmi(dizi,dizi[i],0);
            }
            Console.WriteLine(sayac);


        }
    }
    class Kişi
    {
        public string Ad;
        public static int sayıcı = 0;
        //public static int Sayıcı => sayıcı;     
        public static int SayıcıArttır()
        { return sayıcı++; }
        public static int SayıcıAzalt()
        { return sayıcı--; }

        public static int degilmi(string[] dizi, string elenan,int sayac)
        {
            for (int k = 0 ; k < dizi.Length; k++)
            {
                if (elenan == dizi[k])
                {
                    sayac++;
                    break;
                }
                else
                    continue;
            }
            return sayac;
        }
    }
    
}
