using System;

namespace _111111
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("sayi gir: ");
            int sayi = int.Parse(Console.ReadLine());
            int yenisayi = sayi / 2;
             yenisayi *= 2;
            if(sayi==yenisayi)
                Console.WriteLine(sayi+ ": çifttir");
          else  Console.WriteLine(sayi+": tektir");
        }
        public static int ikiyebol(int x)
        {

            if (x / 2 > 2)
            {
                x /= 2;
                Console.WriteLine(x);
                x = ikiyebol(x);
            }
            return x;
        }
    }
}
