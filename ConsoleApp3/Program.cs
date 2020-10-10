using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver Wb = new OperaDriver();
            Wb.Navigate().GoToUrl("https://www.instagram.com");
        }
    }
}
