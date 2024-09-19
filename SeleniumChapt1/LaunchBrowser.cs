using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumChapt1
{
    internal class LaunchBrowser
    {
        static void Main(string[] args)
        {
           IWebDriver Driver = new ChromeDriver();
            Driver.Url = "https://www.google.com/";
            string title = Driver.Title;
            Console.WriteLine(title);
            Driver.Quit();
        }
    }
}
