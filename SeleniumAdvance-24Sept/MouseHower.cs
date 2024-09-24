using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAdvance_24Sept
{
    internal class MouseHower
    {
        [Test]
        public void mousehower()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--disable-notifications");
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.futureskillsprime.in/";
            driver.Manage().Window.Maximize();
            Actions a = new Actions(driver);
            a.MoveToElement(driver.FindElement(By.XPath("//span[contains (text(),'Explore')]"))).Perform();
            a.MoveToElement(driver.FindElement(By.XPath("//a[contains (text(),'FutureSkills Prime')]"))).Perform();
            driver.FindElement(By.XPath("//a[text()='About Us']")).Click();


        
        }
    }
}
