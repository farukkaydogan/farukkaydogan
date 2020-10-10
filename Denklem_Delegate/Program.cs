using System;


namespace Denklem_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            islem a = new islem(denklem);
            a += kup;
            a += kare;
            a += daire;
            a(10);
            temsilci nesne = null;
            nesne += new temsilci(Metot1);
            nesne += new temsilci(Metot2);
            Delegate[] dizi = nesne.GetInvocationList();
            Delegate nesne2 = Delegate.Combine(dizi); nesne2.DynamicInvoke();
        }
        delegate void islem(int y);
        static void denklem(int x)
        {
            x = x * x * 4 + 5 * x + 10;
            Console.WriteLine(x);
        }
        static void kup(int x)
        {
            x = x * x * x;
            Console.WriteLine(x);
        }
        static void kare(int x)
        {
            x = x * x;
            Console.WriteLine(x);
        }
        static void daire(int x)
        {
            double y;
            y = Math.PI * x * x;
            Console.WriteLine(y);
        }

        delegate void temsilci();
        static void Metot1() { Console.WriteLine("Burası Metot1()"); }
        static void Metot2() { Console.WriteLine("Burası Metot2()"); }
        
    }

}

