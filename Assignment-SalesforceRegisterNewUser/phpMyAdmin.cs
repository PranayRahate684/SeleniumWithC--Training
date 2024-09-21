using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_SalesforceRegisterNewUser
{
    internal class phpMyAdmin
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.db4free.net/phpMyAdmin/index.php?route=/";
            driver.FindElement(By.Id("input_username")).SendKeys("Admin");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("input_password")).SendKeys("admin123");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("input_go")).Click();
            Thread.Sleep(1000);
       
           IWebElement error= driver.FindElement(By.Id("pma_errors")); 
         
            Console.WriteLine( "Error Message========================"+error.Text);

            driver.Quit();
        }
    }
}
