using System;


namespace ConsoleApp1
{
    class Program
    {

        enum film : int { Yüzüklerin_efendisi , Esareti_Bedeli , Kara_Sovalye , Dovus_Kulubu , Yesil_Yol  }

        static void Main(string[] Args)
        {
            film b;
            int secim;
            
            for (int i = 0; i < 5; i++)
            {
                b = (film)i;
                Console.WriteLine($"{i+1}. "+b);
               

                
                
            }
            Console.WriteLine("imdb puanını gösrmek istediğiniz diziyi seçin    ");
            secim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"seçtiğin filmin imdb puanı= {dizi[secim - 1]}");

        }
       public static double[] dizi= {6.4,4.3,7.4,9.4,6.8 ,9.9};
       

       

    }

   
}
