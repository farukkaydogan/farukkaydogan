using System;

namespace Hafta6
{
    
     
    class Program 
   {
        static void Main()
        {
            Console.WriteLine(" sayı ve üs giriniz");
            string a = Console.ReadLine();
            string[] dizi = a.Split();
            double sonuc = 0;
            if (dizi[1] =="0")
            {
                 sonuc = 1;
            }
            else
            {
                sonuc = Convert.ToDouble(dizi[0]);
                if (Convert.ToDouble(dizi[1]) < 0)
                {
                    for (int i = 0; i < Math.Abs(Convert.ToDouble(dizi[1])) + 1; i++)
                    {
                        sonuc /= Convert.ToDouble(dizi[0]);

                    }
                }
                else
                {
                    for (int i = 0; i < Math.Abs(Convert.ToDouble(dizi[1])) - 1; i++)
                    {

                        sonuc *= Convert.ToDouble(dizi[0]);

                    }
                }      
                
            }
           
            Console.WriteLine(dizi[0]+ " ^ "+ dizi[1] + "  = "+ sonuc);
        }
   }

}
