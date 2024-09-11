using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OrangeHrm.Project.PageClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHrm.Project.TestCases
{
    public class BaseClass
    {
         public IWebDriver driver;
       

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            Thread.Sleep(3000);
            driver.Manage().Window.Maximize();
            
        }
    }
}
