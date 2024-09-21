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
        static void Main1(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.salesforce.com/in/form/signup/freetrial-sales/";

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Name("UserFirstName")).SendKeys("john"); //FIRSTNAME
            driver.FindElement(By.Name("UserLastName")).SendKeys("wick"); //LASTNAME
            driver.FindElement(By.Name("UserEmail")).SendKeys("john@gmail.com"); // EMAIL

            // Selecting Value from job Title Dropdown
            IWebElement jobTitle = driver.FindElement(By.Name("UserTitle"));

            SelectElement designation = new SelectElement(jobTitle);
            designation.SelectByText("IT Manager");

            //Selecting Employees count from dropdown

            SelectElement empcount = new SelectElement(driver.FindElement(By.Name("CompanyEmployees")));
            empcount.SelectByText("101 - 200 employees");

            //Selecting Country from dropdown using Javascript Executor
            IWebElement country = driver.FindElement(By.XPath("//select[contains (@id,'CompanyCountry')]"));
            SelectElement selectcountry = new SelectElement(country);
            selectcountry.SelectByText("United Kingdom");

            driver.FindElement(By.Name("CompanyName")).SendKeys("TR");// COMPANY NAME

       

            // Clicking on Checkbox
            driver.FindElement(By.XPath("(//div[@class='checkbox-ui'])[2]")).Click();//XPATH IS GROUPED WITH () in case of multiple elements with same attributes [2] 

            //START MY FREE TRIAL


            driver.FindElement(By.Name("start my free trial")).Click();
            Thread.Sleep(1000);
            //capture warning message of phone number field
            string actualtext = "Enter a valid phone number";
            IWebElement err=driver.FindElement(By.XPath("//span[contains(text(),\"Enter a valid phone\")]"));
            Console.WriteLine(err.Text.Equals(actualtext));

            driver.Close();


        }
    }
}
