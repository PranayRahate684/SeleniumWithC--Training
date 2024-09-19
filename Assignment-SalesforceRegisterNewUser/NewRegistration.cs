using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Office.CustomUI;
using OpenQA.Selenium.Support.UI;


namespace Assignment_SalesforceRegisterNewUser
{
    public class NewRegistration
    {
        static void Main2(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.salesforce.com/in/form/signup/freetrial-sales/";

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Name("UserFirstName")).SendKeys("john"); //FIRSTNAME
            driver.FindElement(By.Name("UserLastName")).SendKeys("wick"); //LASTNAME
            driver.FindElement(By.Name("UserEmail")).SendKeys("john@gmail.com"); // EMAIL

            IWebElement jobTitle = driver.FindElement(By.Name("UserTitle"));

            SelectElement designation = new SelectElement(jobTitle); // Selecting Value from job Title Dropdown
            designation.SelectByText("IT Manager");

            //Selecting Employees count from dropdown
            IWebElement employees = driver.FindElement(By.Name("CompanyEmployees"));
            SelectElement empcount = new SelectElement(employees);
            empcount.SelectByText("101 - 200 employees");

            //Selecting Country from dropdown using Javascript Executor
            /*   IWebElement country = driver.FindElement(By.Name("CompanyCountry"));
               SelectElement selectcountry = new SelectElement(country);
               empcount.SelectByText("Iceland");
   */
            driver.FindElement(By.Name("CompanyName")).SendKeys("TR");// COMPANY NAME

            Thread.Sleep(1000);
           
            driver.FindElement(By.XPath("(//div[@class='checkbox-ui'])[2]")).Click();// Clicking on Checkbox

            //START MY FREE TRIAL

            Thread.Sleep(2000);
            driver.FindElement(By.Name("start my free trial")).Click();

            //capture warning message of phone number field
                  


            driver.Close();


        }
    }
}
