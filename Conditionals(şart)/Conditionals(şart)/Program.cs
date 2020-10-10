using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals_sart_
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 12;
            //if (number == 10) //eger number 10 ise  komutu basar
            //{
            //    Console.WriteLine("Number is 10");

            //}

            //else if (number == 20)
            //{ Console.WriteLine("Number is 20"); }
            //else //10 veya 2 değil ise değil ise
            //{
            //    Console.WriteLine("Number is not 10 or 20");

            //}
            //switch (number)
            //{
            //    case 10:
            //        Console.WriteLine("Number is 10");
            //        break;
            //    case 20:
            //        Console.WriteLine("Number is 20");
            //        break;
            //    default:
            //        Console.WriteLine("Number is not 10 or 20");
            //        break;

            //        //ctrl k + ctrl d indentleme okunaklama



            //}

            if (number >= 0 && number <= 100)
            {
                Console.WriteLine("Number is between 1-100");
            }




            else if (number >= 101 && number <= 200)
            {
                Console.WriteLine("Number is Between 101-200");

            }

            else if (number > 200 || number < 0)
            {
                Console.WriteLine("Number isnt Between 0-200");

            
            
            }









                Console.Read();

        }
    }
}
