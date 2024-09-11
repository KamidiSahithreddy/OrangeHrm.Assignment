using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHrm.Project.PageClasses
{
    public class OrangeHrmLoginpage

    {
        IWebDriver dr;
        public OrangeHrmLoginpage(IWebDriver dr)
        {
            this.dr = dr;
        }
        public IWebElement Username => dr.FindElement(By.XPath("//input[@placeholder='Username']"));
        public IWebElement Password => dr.FindElement(By.XPath("//input[@placeholder='Password']"));
        public IWebElement loginbutton => dr.FindElement(By.XPath("//button[@type='submit']"));

        //public IWebElement aaa => dr.FindElement(By.XPath("(//div[text()='Username'])[1]//following-sibling::div"));
        public void login()
        {
            Username.SendKeys("Admin");
            Password.SendKeys("admin123");
            dr.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);
            loginbutton.Click();
           


        }
    }
}