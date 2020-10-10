using System;

namespace _19_09_2020
{
    class Program
    {
        unsafe static void Main(string[] args)
        {
            #region isimalanı
            Console.WriteLine(" ");
            #endregion
            fixed (char* ptr = "Sefer Algan")
                for (int i = 0; ptr[i] != '\0'; i++)
                {
                    Console.Write(ptr[i]);
                }

        }
    }
}
