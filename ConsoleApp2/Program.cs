using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] Args)
        {
            int[] dizi1 = new int[10], dizi2 = new int[10];
            Random rnd = new Random();
            Console.WriteLine("Rastgele üretilen  1. dizi : ");
            for (int i = 0; i < dizi1.Length; i++)
            {
                dizi1[i] = rnd.Next(21);
                Console.Write(dizi1[i] + "    ");
            }
            Console.WriteLine("\n\nRastgele üretilen  2. dizi : ");

            for (int i = 0; i < dizi2.Length; i++)
            {
                dizi2[i] = rnd.Next(21);
                Console.Write(dizi2[i] + "    ");
            }
            Console.WriteLine("\n\nToplam dizi : ");

            Dizi a = new Dizi() { Dizi1 = dizi1 };
            Dizi b = new Dizi() { Dizi2 = dizi2 };
            Dizi c = a + b;

            for (int i = 0; i < c.Dizi1.Length; i++)
            {
                Console.Write(c.Dizi1[i] + "    ");
            }
            int rastgele = rnd.Next(11);

            Console.WriteLine($"\n\nRastgele üretilen sayı = {rastgele}");
            Dizi d = c * rastgele;
            for (int i = 0; i < c.Dizi1.Length; i++)
            {
                Console.Write(d.Dizi1[i] + "   ");

            }

        }
    }
    class Dizi

    {
        int[] dizi1 = new int[10];
        int[] dizi2 = new int[10];
        public int[] Dizi1
        {
            get { return dizi1; }
            set { dizi1 = value; }
        }
        public int[] Dizi2
        {
            get { return dizi2; }
            set { dizi2 = value; }
        }
        public static Dizi operator +(Dizi a, Dizi b)

        {
            Dizi c = new Dizi();
            for (int i = 0; i < a.Dizi1.Length; i++)
            {
                c.Dizi1[i] = a.Dizi1[i] + b.Dizi2[i];
            }
            return c;
        }
        public static Dizi operator *(Dizi a, int x)

        {
            Dizi c = new Dizi();
            for (int i = 0; i < a.Dizi1.Length; i++)
            {
                c.Dizi1[i] = a.Dizi1[i] * x;
            }
            return c;
        }

    }
}
