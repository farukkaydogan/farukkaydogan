using System;

namespace icAcı
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir boşluk arayla 2 üçgen açısı girin");
            string t = Console.ReadLine();
            string[] x = t.Split(" ");
            int[] a = new int[2];

            for (int i = 0; i < 2; i++)
            {
                a[i] = Convert.ToInt32(x[i]);
            }

            while (a[0] + a[1]! <= 0 || a[1] + a[0] >= 180)
            {
                Console.WriteLine("girilen değerler yanlıştır tekrar giriniz ");
                Console.WriteLine("bir boşluk arayla 2 üçgen açısı girin");
                t = Console.ReadLine();
                x = t.Split(" ");
                for (int i = 0; i < 2; i++)
                {
                    a[i] = Convert.ToInt32(x[i]);
                }
            }
            int ucgen = 180;
            int yazdır = ucgen - a[0] - a[1];
            Console.WriteLine(yazdır);
        }
    }
}
