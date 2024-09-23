using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts_20thSept_NUNITPROJ
{
    internal class Frames
    {
        [Test]
        public void TestFrame()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://netbanking.hdfcbank.com/netbanking/";
            //

            IWebElement frame = driver.FindElement(By.Name("login_page"));
            driver.SwitchTo().Frame(frame);
            //enter userid as john123
            driver.FindElement(By.Name("fldLoginUserId")).SendKeys("john123");
            //Click Continue

            driver.FindElement(By.XPath("//a[@onclick='return fLogon();']")).Click();

            IWebElement pwd =driver.FindElement(By.XPath("//input[@id='keyboard']"));
            

            driver.SwitchTo().DefaultContent();

            driver.Close();
        }
    }
}
