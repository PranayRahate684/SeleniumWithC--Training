using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignMent2_19thSept24
{
    internal class mediaBuddy
    {
        static void Main(string[]args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.medibuddy.in/";
            //Clicking on Login button
            driver.FindElement(By.XPath("//a[@ng-if='!OneClickFlowLogin' ]")).Click();

            //clicking on I have a corporate Account

            driver.FindElement(By.XPath("//div[@class='coperate']")).Click();


        }
    }
}
