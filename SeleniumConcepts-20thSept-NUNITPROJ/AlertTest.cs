using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts_20thSept_NUNITPROJ
{
    internal class AlertTest
    {
        [Test]
        public void alerts()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
      driver.Url= " https://netbanking.hdfcbank.com/netbanking/IpinResetUsingOTP.htm";

            driver.FindElement(By.XPath("//img[contains(@src,'go.gif')]")).Click();


         string alerttext=  driver.SwitchTo().Alert().Text;//Saving alert text msg in alerttext varx
            Console.WriteLine( "Alert Text : "+alerttext);
            driver.SwitchTo().Alert().Accept();

            driver.Close();
        }
    }
}
