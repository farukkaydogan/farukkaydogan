using System;

namespace _23_09_2020
{
    class Program
    {
        unsafe static void Main()
        {
            int i = 80;
            int* ig = &i; uint adres = (uint)ig; Console.WriteLine("{0:X}", adres);
        }
    }
}
