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
            //Thread.Sleep(2000);
            //Open Emr Product Registration
            //   driver.FindElement(By.XPath("//button[@class='btn btn-secondary nothanks']")).Click();

            Console.WriteLine(driver.Title);
            //ENtering User Name
            driver.FindElement(By.Id("authUser")).SendKeys("admin");
            //Entering Password
            driver.FindElement(By.Id("clearPass")).SendKeys("pass");

            //Selecting Language
            SelectElement Lang=new (driver.FindElement(By.TagName("select")));
            Lang.SelectByText("English (Indian)");

            //Clicking on Login button

            driver.FindElement(By.Id("login-button")).Click();

            //Clicking on the Patient tab from header; Used Grouping concept in XPATH
            driver.FindElement(By.XPath("(//div[contains (text(),'Patient')])[1]")).Click();

            //Clicking on New Search
            driver.FindElement(By.XPath("(//div[contains (text(),'New/Search')])[1]")).Click();

            //Switching To Frame
           // IWebElement frame = driver.FindElement(By.Name("pat"));
            driver.SwitchTo().Frame(driver.FindElement(By.Name("pat")));


            //Entering First Name
            driver.FindElement(By.Name("form_fname")).SendKeys("POC4");

            //Entering Last Name
            driver.FindElement(By.Name("form_lname")).SendKeys("Subject4");

            //Entering DOB
            IWebElement DOB =driver.FindElement(By.Id("form_DOB"));
            DOB.SendKeys("2024-09-17");

            //Selecting Geneder
            SelectElement gender = new(driver.FindElement(By.Id("form_sex")));
            gender.SelectByText("Male");

            //Selecting Gender identification
            SelectElement genderIdent = new(driver.FindElement(By.Id("form_gender_identity")));
            genderIdent.SelectByText("Identifies as Male");

            //Clicking on Create New Patient
            driver.FindElement(By.XPath("//*[@value='Create New Patient']")).Click();

            driver.SwitchTo().DefaultContent();

            Console.WriteLine( "After switching to Parent Window : "+driver.Title);

            Thread.Sleep(5000);
            
            //Switching to Confirm New Patient frame
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//div/iframe[@id='modalframe']")));

            driver.FindElement(By.XPath("//button[contains(text(),'Confirm Create New Patient')]")).Click();
            //Explicit wait for alert to appear
            //driver.SwitchTo().DefaultContent();

            WebDriverWait wait = new(driver,TimeSpan.FromSeconds(10));
             

            //Get text of Alert Box and Accept 
           //string alert= driver.SwitchTo().Alert().Text;
           // Console.WriteLine("Alert Text : " + alert);
            driver.SwitchTo().Alert().Accept();

            //Close Happy Birthday popup

            // driver.FindElement(By.XPath("//div[@class='closeDlgIframe']")).Click();

            // Getting User Name of Current User
            Thread.Sleep(2000);
            IWebElement UsrName = driver.FindElement(By.XPath("//*[@data-bind='text: pname()']"));

            Console.WriteLine(" User Name : " + UsrName.Text);

            //clicking on the user profile icon

            SelectElement usrprofile = new SelectElement(driver.FindElement(By.XPath("//div[@title='Current user']")));
            usrprofile.SelectByText(" Logout");

            driver.Quit();
        }
    }
}
