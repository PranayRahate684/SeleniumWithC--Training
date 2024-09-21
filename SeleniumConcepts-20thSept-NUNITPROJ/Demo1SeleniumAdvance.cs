using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts_20thSept_NUNITPROJ
{
    internal class Demo1SeleniumAdvance
    {
        [Test]
        public void MultipleTabsTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.db4free.net/";

            //click on phpMyAdmin »}
            driver.FindElement(By.PartialLinkText("phpMyAdmin")).Click();

            // Switching TO New Tab
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            //

            driver.FindElement(By.Id("input_username")).SendKeys("Admin");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("input_password")).SendKeys("admin123");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("input_go")).Click();
            Thread.Sleep(1000);

            IWebElement error = driver.FindElement(By.Id("pma_errors"));

            Console.WriteLine("Error Message========================" + error.Text);

            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);

            Console.WriteLine(  driver.Title);
            driver.Close();
        }
    }
}
