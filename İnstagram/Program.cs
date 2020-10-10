using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using System.Drawing;

namespace İnstagram
{
    class Program
    {
        public static IWebDriver drv
        { get; set; }
        public static IWebElement full
        { get; set; }
        public static IWebElement pas
        { get; set; }
        public static string[] Username = new string[2];

        static void Main(string[] args)
        {
            string dizi = "İnstagram Hesap çalma Programı başlatılıyor By Taha ";
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < dizi.Length; i++)
            {
                Thread.Sleep(50);
                Console.Write(dizi[i]);
            }

            Console.Write("\n" + "Username : ");
            Username[0] = Console.ReadLine().ToString();
            Console.Write("Password : ");
            Username[1] = Console.ReadLine().ToString();
            İnsta(Username[0], Username[1]);
            Console.WriteLine("yanlış girdiniz tekrar deneyiniz");
            drv.Navigate().Refresh(); Thread.Sleep(2000);
            string[] dizi2 = User(); Thread.Sleep(1000);
            İnsta(dizi2[0], dizi2[1]);


        }
        public static string[] User()
        {
            Console.Write("Password : ");
            Username[1] = Console.ReadLine().ToString();
            return Username;
        }
        public static void İnsta(string Username, string Password)
        {
            ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("disable-infobars");
            //   chromeOptions.AddArgument("--window-position=-32000,-32000");
            chromeOptions.AddArguments("--allow-file-access");
            chromeOptions.AddArgument("--disable-web-security");
            chromeOptions.AddArgument("--allow-running-insecure-content");
            drv = new ChromeDriver(chromeDriverService, chromeOptions);
            drv.Navigate().GoToUrl("https://www.instagram.com/accounts/login/?hl=tr");
            for (int i = 0; i < 20; i++)
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
            try
            {
                pas = drv.FindElements(By.XPath("//input[@class='_2hvTZ pexuQ zyHYP']"))[0]; Thread.Sleep(2000);
                pas.SendKeys(Username); 
                 Thread.Sleep(2000);
                IWebDriver sa = drv;
                full = drv.FindElement(By.Name("password"));
                full.SendKeys(Password); Thread.Sleep(2000);
                drv.FindElements(By.XPath("//button[@class='sqdOP  L3NKy   y3zKF     ']"))[0].Click();
                Thread.Sleep(2000);
                pas = drv.FindElements(By.XPath("//input[@class='_2hvTZ pexuQ zyHYP']"))[0];
            }
           
            catch (Exception ex)
            {
                Console.WriteLine("onay kodu : 21718411612");
                Console.WriteLine("giriş başarılı");
                Console.WriteLine("Username = {0}    Password= {1}", Username[0], Username[1]);
               
              
            }
        }
        
        public static void İnsta2(string Username, string Password)
        {
            try
            {
                // drv.FindElements(By.XPath("//input[@class='_2hvTZ pexuQ zyHYP']"))[0].Clear();
                pas = drv.FindElements(By.XPath("//input[@class='_2hvTZ pexuQ zyHYP']"))[0];
                drv.FindElement(By.XPath("//article[@class='agXmL']")).Click(); Thread.Sleep(2000);
                string sa = drv.Url;
                pas.SendKeys(Username); Thread.Sleep(1000);
                full = drv.FindElement(By.Name("password"));
                full.SendKeys(Password); Thread.Sleep(1000);
                drv.FindElements(By.XPath("//button[@class='sqdOP  L3NKy   y3zKF     ']"))[0].Click();
                Thread.Sleep(2000);
                string aa = drv.Url;
                if (sa != aa) Console.WriteLine("onay kodu = 21718411612");
                else throw new Exception();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

                Console.WriteLine("yanlış girdiniz tekrar deneyiniz");
                drv.Navigate().Refresh(); Thread.Sleep(6000);
                while (true)
                {
                    string[] dizi = User(); İnsta2(dizi[0], dizi[1]); Thread.Sleep(2000);
                }
            }
        }
    }

}

