using System;

namespace Lab
{

    /*
    //4.soru
 class Program
 {
     enum html : int { Siyah = 1,Kırmızı , Mavi, Yeşil ,Beyaz }
     static void Main(string[] Args)
     {
         html b;
         for (b = html.Siyah; b <=html.Beyaz ; b++)
         {
             Console.WriteLine($"{(int)b}. {b}");
         }
         Console.Write("Görüntülemek istediğiniz rengi seçiniz: ");
         int secim = Convert.ToInt32(Console.ReadLine());
         string yiğen = "";
         if (secim == 1)
             Console.WriteLine($"Seçtiğiniz rengin html kodu : #000000");
         else if (secim == 2)
             Console.WriteLine($"Seçtiğiniz rengin html kodu : #FF0000");

         else if (secim == 3)
             Console.WriteLine($"Seçtiğiniz rengin html kodu : #0000FF");
         else if (secim == 4)
             Console.WriteLine($"Seçtiğiniz rengin html kodu : #000800");
         else if (secim == 5)
             Console.WriteLine($"Seçtiğiniz rengin html kodu : #FFFFFF");
     }
 }
*/
    //2.soru
    /* class ArabaTest
     {
         static void Main(string[] args)
         {
             Araba Wv = new Araba(90000, 2019, "Ford", "Focus", "Mavi");
             Wv.Yaz();
             Console.ReadLine();
         }
     }
     class Araba
     {
         int Ücreti;  int Yıl; string Marka; string Model;string Renk;
         public  Araba(int ücret, int yıl, string marka, string model, string renk)
         {
             Ücreti = ücret; Yıl = yıl; Marka = marka; Model = model; Renk = renk;
         }
         public void Yaz()
         {
             Console.WriteLine($"{Marka} marka {Ücreti} ücretli {Yıl} yıl üretimli olup {Renk} renginde olup {Model} modelidir");
         }
     }
     */
    //1. soru 
    /* class Program
     {
         static void Main(string[] args)
         {
             Öğrenci ogr = new Öğrenci();     
             ogr.İsim = "Ender bey";
             ogr.Numara = 201913709000;
             ogr.Not = 97;
             Console.WriteLine($"{ogr.İsim} isminde {ogr.Numara} numarasında {ogr.Not} final notuna sahiptir ");
         }
     }
     class Öğrenci
     {
         byte not; ulong numara; string isim;
         public byte Not { get { return not; } set { if (value < 100 && value > 0) not = value; else not = 0; } }
         public ulong Numara { get { return numara; } set { if (value < 999999999999 && value > 100000000000) numara = value; else numara = 0; } }
         public string İsim { get { return isim; } set { isim = value; } ;
     }
     */
    //3.soru
    class Program
    {
        static void Main(string[] args)
        {
            Car mercedes = new Car();
            Car Honda = new Car();
            Car opel = new Car();
            opel.arac = 80000;
            Honda.arac = 80000;
            mercedes.arac = 120000;
           int a= Honda + mercedes;
            Console.WriteLine("Fiyatların toplamı : "+a +" TL");
            string b = Honda % mercedes;
            string c = Honda % opel;
            if (b=="<")
               Console.WriteLine("mercedes daha pahalı");
            else if (b == ">")
                Console.WriteLine("bmw daha pahalı");
           else if (b == "=")
                Console.WriteLine("opel ve honda'nın fıyatları aynı");
            if (c == "<")
                Console.WriteLine("opel daha pahalı");
            else if (c == ">")
                Console.WriteLine("honda daha pahalı");
            else if (c == "=")
                Console.WriteLine("honda ve opel'in fıyatları aynı");
        }
    }
    class Car
    {
        public int arac;
        public static int operator +(Car x, Car y)
        {
            return x.arac + y.arac;
        }
        public static string operator %(Car x, Car y)
        {
            string a = "";
            if (x.arac / y.arac < 1)
                a = "<";
            else if (x.arac / y.arac >1)
                a = ">";
            else if (x.arac / y.arac == 1)
                a = "=";
                return a;
        }
    }
}
   
   
