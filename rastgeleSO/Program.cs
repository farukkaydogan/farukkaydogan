using System;

namespace rastgeleSO
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] SO = new string[15,15];
            string[] harf = { "S", "O" };
            Random Rnd = new Random();

            for (int i = 0; i <= 14; i++)
            {
                for (int j = 0; j <= 14; j++)
                {
                    SO[j, i] = harf[Rnd.Next(2)];
                    Console.Write(SO[j, i]);
                }
                Console.WriteLine();
            }

        }
    }
}
