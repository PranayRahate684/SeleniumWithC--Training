using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcept2
{
    internal class FBLogin
    {
        static void Maind(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/";
            driver.FindElement (By.Id("email")).SendKeys("TEST");
            driver.FindElement(By.Id("pass")).SendKeys("PASSWORD");
            driver.FindElement(By.Id("loginbutton")).Click();
           
            driver.Quit();

        }
    }
}
