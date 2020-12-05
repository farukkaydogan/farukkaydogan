using System;
using System.Reflection.Metadata.Ecma335;

namespace _29_10_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            string metin = "29 Ekim 1923";
            bool[] bol = sayimi(metin);
            for (int i = 0; i < metin.Length; i++)
            {
                if (bol[i]==true)
                {
                    Console.WriteLine(metin[i] +" sayıdır");
                }
                else
                    Console.WriteLine(metin[i] + " sayı değildir");
            }
        }

        static public bool [] sayimi(string metin)
        {
            bool[] trueorfalse = new bool[metin.Length] ;
            char[] ifadeler = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            for (int i = 0; i < metin.Length; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (metin[i]==ifadeler[j])
                    {
                        trueorfalse[i] = true;
                        break;
                    }
                    else
                    {
                        trueorfalse[i] = false;
                    }
                }
            }
            return trueorfalse;
        }
    }
}



