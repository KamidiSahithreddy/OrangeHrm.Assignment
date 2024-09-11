using OrangeHrm.Project.PageClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHrm.Project.TestCases
{
    public class AdminTestCase:BaseClass

    {
        public AdminPage Delete;
        [Test]
        public void DelectingData()
        {
            OrangeHrmLoginpage Hrm = new OrangeHrmLoginpage(driver);
            Hrm.login();
            Thread.Sleep(1000);
            Delete = new AdminPage(driver);
            Delete.DeleteData();
        }
       
    }
}
