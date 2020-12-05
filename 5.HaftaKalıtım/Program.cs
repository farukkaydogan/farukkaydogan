using System;
using System.Collections;

namespace _5.HaftaKalıtım
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Sekil yuvarlak = new Sekil(2,"yuvarlak");
            Triangle ucgen = new Triangle(3, "üçgen",4);
            Right dikucgen = new Right(3, "dik üçgen",2);
            Scalene çeşitkenar = new Scalene(7, "yedigen",35);
            Isosceles ikizkenar = new Isosceles(3, "ikizkenar");
            Equilateral eşkenar = new Equilateral(3,"eşkenar",3);
        }
    }
    class Kutu 
    {
       public int kose;
      public  string isim;
        public Kutu(int sayi , string ism)
        {
            this.isim = ism;
            this.kose = sayi;
        }
    }
    class Sekil : Kutu
    {
        public Sekil(int yaricap, string ism) : base(yaricap, ism)
        {
            Console.WriteLine($"{ism}'nin alanı= "+ Math.Pow(yaricap,2)*Math.PI);
        }        
    }
    class Triangle : Kutu
    {
        public Triangle(int a, string ism, int b) : base(a, ism)
        {
            Console.WriteLine($"{ism}'nin alanı= " + (a*b)/2);
        }
    }
    class Right : Kutu
    {
        public Right(int a, string ism, int b) : base(a, ism)
        {
            Console.WriteLine($"{ism}'nin alanı= " + (a * b) / 2);
        }
    }
    class Scalene : Kutu
    {
        public Scalene(int a, string ism, int b) : base(a, ism)
        {
            Console.WriteLine($"{ism}'nin alanı= " + (a * b) / 2);
        }
    }
    class Isosceles : Kutu
    {
        public Isosceles(int a, string ism) : base(a, ism)
        {
            Console.WriteLine($"{ism}'nin alanı= " + (a * a) / 2);
        }
    }
    class Equilateral : Kutu
    {
        public Equilateral(int a, string ism, int b) : base(a, ism)
        {
            Console.WriteLine($"{ism}'nin alanı= " + (a * b) / 2);
        }
    }

}
