using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace İnsta_denem
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  string dizi = "İnstagram Hesap çalma Programı başlatılıyor By Taha ";
              Console.ForegroundColor = ConsoleColor.Red;

              for (int i = 0; i < dizi.Length; i++)
              {
                  Thread.Sleep(50);
                  Console.Write(dizi[i]);
              }
              Console.Write("\n"+"Username : ");
              string Username = Console.ReadLine().ToString();
              Console.Write("Password : ");
              string Password = Console.ReadLine().ToString();
              */

            IWebDriver Selenium = new ChromeDriver();
            Selenium.Navigate().GoToUrl("https://www.yandex.com.tr/");

           // Selenium.Navigate().GoToUrl("https://www.instagram.com/accounts/login/?hl=tr");

         /*   try
            {
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(50);
                    Console.Write(".");
                    for (int h = 0; h < 1; h++)
                    {
                        Thread.Sleep(50);
                        Console.Write(".");
                        for (int a = 0; a < 1; a++)
                        {
                            Thread.Sleep(50);
                            Console.Write(".");
                        }
                    }
                    Console.Clear();
                }

            }

            catch (Exception)
            {
                Console.WriteLine("giriş başarısız");
                throw;
            }
            finally { Console.WriteLine("giriş başarılı"); }



    */

        }
    }
}
