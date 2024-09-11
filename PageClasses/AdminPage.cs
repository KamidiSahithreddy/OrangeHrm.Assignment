using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHrm.Project.PageClasses
{
    public class AdminPage
        
    {
        public IWebDriver dr;
        public AdminPage(IWebDriver dr) 

        { 
           this.dr = dr;
        }
        public IWebElement AdminButton => dr.FindElement(By.XPath("(//li[@class='oxd-main-menu-item-wrapper'])[1]"));
        public IWebElement ClickOnSecondDeleteButton => dr.FindElement(By.XPath("(//i[@class='oxd-icon bi-trash'])[2]"));
        public IWebElement ConfirmDelete => dr.FindElement(By.XPath("//button[text()=' Yes, Delete ']"));
        public IWebElement SecondRow => dr.FindElement(By.XPath("(//div[@class='oxd-table-body']//following-sibling::div)[14]"));
        public void DeleteData()
        {
            dr.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            AdminButton.Click();
            dr.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            ClickOnSecondDeleteButton.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            ConfirmDelete.Click();
            Thread.Sleep(3000);
            //Assert.IsTrue(SecondRow.Displayed, "The 2nd record  is not displayed as expected");
            Console.WriteLine("The 2nd record  is not displayed as expected :" +SecondRow.Displayed);
        }
    }
}
