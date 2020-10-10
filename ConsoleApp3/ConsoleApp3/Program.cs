using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int başarısız = 0, başarılı = 0, orta = 0, puan ;
            Console.WriteLine("öğrenci sayısı :   ");
            int ogr = Convert.ToInt32(Console.ReadLine());
            



            for (int i = 1; i <= ogr; )
            {
                Console.WriteLine("Puanı giriniz: ");
                puan = Convert.ToInt32(Console.ReadLine());


                if (puan > 100 || puan < 0)
                {
                    Console.WriteLine("Lütfen geçerli bi not giriniz");
                }
                else if (puan > 0 && puan < 40)
                {
                    i++;
                    başarısız++;

                }
                else if (puan > 40 && puan < 70)
                {
                    i++;
                    orta++;
                }

                else if (puan > 70 && puan < 100)
                { i++;
                    başarılı++;
                }

            }
            Console.WriteLine("{0} ADET ÖĞRENCİDEN {1 }BAŞARILI {2} BAŞARISIZ {3} ORTADIR ", ogr, başarılı, başarısız, orta);
        }
    }
}
