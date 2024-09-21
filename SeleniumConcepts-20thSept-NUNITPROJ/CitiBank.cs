using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts_20thSept_NUNITPROJ
{
    internal class CitiBank
    {
        [Test]
        public void TestCitiBank()
        {
            IWebDriver driver= new ChromeDriver();
            driver.Url = "https://online.citibank.co.in/";
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//a[@class='newclose']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//a[@class='newclose2']")).Click();
            driver.FindElement(By.Id("topMnubanking")).Click();

            Thread.Sleep(1000);
            //Click Citi Commercial Bank
            driver.FindElement(By.XPath("//b[contains(text(),'Citi Commercial Bank')]")).Click();
            //Switching to new Tab
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            //Click on ATM
            driver.FindElement(By.XPath("//a[contains(@title,'Branch/ATM')]")).Click();

            //chosing ATM
            driver.FindElement(By.XPath("//a[contains(text(),'Choose One')]")).Click();

            driver.FindElement(By.LinkText("Bengaluru")).Click();

            //Choose Branch

            driver.FindElement(By.LinkText("Bengaluru")).Click();
        }
    }
}
