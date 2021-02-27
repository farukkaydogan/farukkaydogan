using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arifcanbalta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("sayi gir: ");
            int sayi = int.Parse(Console.ReadLine());
            if (ikiyebol(sayi) == 1)
                Console.WriteLine($"{sayi} tektir");
            else 
                Console.WriteLine($"{sayi} çifttir");
            Console.WriteLine(sayi);
        }
        public static int ikiyebol(int x)
        {

            if (x / 2 > 2)
            {
                x /= 2;
                ikiyebol(x);
            }
            return x;
        }
    }
}
