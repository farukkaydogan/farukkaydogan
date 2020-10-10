using System;

namespace ProgramlamaOrnekleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //object x;
            //x = 10;
            //Console.WriteLine(x.GetType());
            //x = "B";
            //Console.WriteLine(x.GetType());
            //x = 8.78F;
            //Console.WriteLine(x.GetType());
            //x = 5.489M;
            //Console.WriteLine(x.GetType());
            //x =false ;
            //Console.WriteLine(x.GetType());
            //Console.ReadLine();

            //double x = 5.53543;
            //double a;
            //a = x;
            //Console.WriteLine(a);

            //int a;
            //float b = 32.32f;
            //double c;
            //c = b;
            //Console.WriteLine("b'nin değeri = " + b +
            //    " \nc'nin degeri = " + c);
            //BİLİNCLİ TÜR DONUSUMLERİ derleyici izin vermezse yapılır

            //bunun için operatör lullanılır
            //int a = 256;
            //byte b = (byte)a;
            //Console.WriteLine(b);


            //double d1, d2; int i; byte b; char c; uint u; short s; d1 = 5.0;
            //d2 = 4.0;//double int e dönüştü veri kaybı var viegülden sonrası atılır
            //    i = (int)(d1 / d2); Console.WriteLine("doyble integere cevrildi = " + i);
            ////int byte dönüşür veri kaybı yok
            //i = 123; b = (byte)i; Console.WriteLine("i'nin değeri = " +
            //    i + "iken b'nin değeri=" + b);
            ////veri kaybı var 
            //i = 258; b = (byte)
            //    i; Console.WriteLine("i'nin değeri " + i + "iken b' nin değeri" + b);
            //Console.WriteLine();
            ////uint'i short'a dönüşür

            //u = 32146;
            //s = (short)u; // veri kaybı yok 
            //Console.WriteLine("U'nun değeri=" + u + "iken s'nin deperi " + s);
            //u = 35000;
            //s = (short)u; // veri kaybı var

            //Console.WriteLine("U'nun değeri=" + u + "iken s'nin deperi " + s);
            //Console.WriteLine();
            ////int ' i char ' a dönüştür
            //i = 90;
            //c = (char)i;  Console.WriteLine(i + "sayısının char'a dönüştürürske =  " + c + "  olur");


            // uncheched checked işl ters çevirir;
            //int i2 = 500;
            //int i1 = 255;
            //byte b, c;
            //checked { 
            //b = }
            //int i = 10;

            //object o = i;
            //int l = (int)o;
            //Console.WriteLine(i);
            //Console.WriteLine(l);

            //object a = 120; //aya boxing uygulandı
            //object b = "bilgisayar";
            //int sayı = (int)a;
            //string str = (string)b;
            //Console.WriteLine("a integere çevrildi : " +sayı);
            //Console.WriteLine("b stringe cevrildi : " + str);

            //string s1, s2;
            //int i1, i2, t;
            //Console.WriteLine("1.sayıyı giriniz : ;");
            //    s1 = Console.ReadLine();

            //Console.WriteLine("2.sayıyı giriniz : ;");
            //    s2 = Console.ReadLine();
            //i1 = Convert.ToInt32(s1);
            //i2 = Convert.ToInt32(s2);
            //t = i1 + i2;
            //Console.WriteLine("TOPLAM :  " + t.ToString());


            byte b1 = 254;
            byte b2 = (byte)b1;
            Console.WriteLine(b2);


























            Console.ReadKey();







        }


    }
}
