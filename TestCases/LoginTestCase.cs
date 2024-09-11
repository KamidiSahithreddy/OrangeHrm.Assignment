using OpenQA.Selenium;
using OrangeHrm.Project.PageClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHrm.Project.TestCases
{
    public class LoginTestCase:BaseClass
    {
        public OrangeHrmLoginpage Hrm;

        [Test]
        public void LoginPage()
        {
            Hrm = new OrangeHrmLoginpage(driver);
            Thread.Sleep(3000);
            Hrm.login();
            
           

        }

    }
}
