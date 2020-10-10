using System;

namespace Word
{
    class Program
    {
       static void Main(string[] args)
        {
            Random Rnd = new Random();
            string[] x = new string[10];
            int sayı = 0;
            Console.ForegroundColor = ConsoleColor.Green;
            while (true)
            {


                for (int i = 0; i < 10; i++)
                {
                    sayı = Rnd.Next(3);
                    if (sayı == 1)
                    {
                        char y;
                        y = Convert.ToChar(Rnd.Next(65, 91));
                        x[i] = y.ToString();
                    }

                    else x[i] = Rnd.Next(10).ToString();
                }
                foreach (var item in x)
                {
                    Console.Write(item);
                }
            }       
        }
    }
}