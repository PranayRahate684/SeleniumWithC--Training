using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_SalesforceRegisterNewUser
{
    public class country
    {
        static void Main23(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.salesforce.com/in/form/signup/freetrial-sales/";
         
          

        }
    }
}
