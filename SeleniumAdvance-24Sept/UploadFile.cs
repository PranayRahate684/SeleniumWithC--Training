using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAdvance_24Sept
{
    internal class UploadFile
    {
        [Test]
        public void uploadFile()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.ilovepdf.com/pdf_to_word";
            //Remove unmwanted '/ ' while pasting 
            driver.FindElement(By.XPath("//input[@type='file']")).SendKeys(@"C:\1065_B1_Federal.pdf");

            
        }
    }
}
