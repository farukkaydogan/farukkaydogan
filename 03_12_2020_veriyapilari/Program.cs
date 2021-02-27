using System;

namespace _03_12_2020_veriyapilari
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Sayi gir : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( fonksiyon(sayi));
            //Faruk Tayyib Aydoğan 201913709054
        }

        static int fonksiyon(int x)
        {
            if (x == 0)
                return 0;
            else
                return (x % 2 + 10 * fonksiyon(x / 2) );
        }
    }
}
