using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUpPortalNunit.pages;
using TurnUpPortalNunit.Utilities;

namespace TurnUpPortalNunit.Test
{
    [TestFixture]
    [Parallelizable]
    public class Employees_Tests : CommonDriver
    {
        LoginPage loginObj = new LoginPage();
        HomePage homeObj = new HomePage();
        EmployeePage employeeObj = new EmployeePage();

        [SetUp]

        public void EmployeeSetUp()
        {
            driver = new ChromeDriver();

            loginObj.LoginSteps(driver);

            homeObj.GoToEmployeePage();

        }
        [Test]
       
        public void CreateEmployeeTest()
        {
            employeeObj.CreateEmployeeTest();

        }

        [Test]
        public void EditEmployeeTest()
        {
            employeeObj.EditEmployeeTest();


        }

        [Test]
       public void DeleteEmployeeTest()
        {
            employeeObj.DeleteEmployeeTest();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

    }
}
