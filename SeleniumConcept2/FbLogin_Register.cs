using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SeleniumConcept2
{
    internal class FbLogin_Register
    {
        static void Main(string[] args)

        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/";
        //    driver.FindElement(By.XPath("//a[@rel=\"nofollow\"]")).Click();
            driver.FindElement(By.PartialLinkText("Sign up")).Click();

           driver.FindElement(By.Name("firstname")).SendKeys("TEST");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.FindElement(By.Name("lastname")).SendKeys("wick");

            driver.FindElement(By.Id("password_step_input")).SendKeys("welcome123");

            //Select Year from dropdown
            SelectElement Selectyear = new SelectElement(driver.FindElement(By.Id("year")));
            Selectyear.SelectByText("1992");

            //Selecting Gender
            driver.FindElement(By.XPath("//input[@value=\"-1\"]")).Click();
        }   
    }
}
