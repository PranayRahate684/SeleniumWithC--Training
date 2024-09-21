using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace Assignment3_Day5_20thSept
{
    public class OpenEMRTEST
    {
        [Test]
        public void Day5Ass()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            //Navigating to URL
            driver.Url = "http://demo.openemr.io/b/openemr/";
            //ENtering User Name
            driver.FindElement(By.Id("authUser")).SendKeys("admin");
            //Entering Password
            driver.FindElement(By.Id("clearPass")).SendKeys("pass");

            //Selecting Language

           /* SelectElement lang = new SelectElement(driver.FindElement(By.Name("languageChoice")));
            lang.SelectByText("Hindi");*/
            //Clicking on Login button

            driver.FindElement(By.Id("login-button")).Click();

            //Clicking on the Patient tab from header; Used Grouping concept in XPATH
            driver.FindElement(By.XPath("(//div[contains (text(),'Patient')])[1]")).Click();

            //Clicking on New Search
            driver.FindElement(By.XPath("(//div[contains (text(),'New/Search')])[1]")).Click();


            
            
            
            driver.Quit();
        }
    }
}
