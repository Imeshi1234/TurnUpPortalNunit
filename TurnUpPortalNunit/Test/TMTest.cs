using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUpPortalNunit.pages;
using NUnit.Framework;
using TurnUpPortalNunit.Utilities;


namespace TurnUpPortalNunit.Test
{

    [TestFixture]
    [Parallelizable]
    public class TMTest:CommonDriver
    {
        [SetUp]
        public void SetUpTM()
        {
            //Open chrome browser
            driver = new ChromeDriver();

            //LoginPage page object initialization and definition
            LoginPage loginObj = new LoginPage();
            loginObj.LoginActions(driver);

            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            //HomePage page object initialization and definition
            HomePage homepageObj = new HomePage();
            homepageObj.VerifySucessLogin(driver);
            homepageObj.GoToTMPage(driver);

        }
        [Test,Order(1),Description("This test create new Time Record with valid data")]
        public void TestCreateTimeRecord()
        {
            TMPage tmpageObj = new TMPage();
            tmpageObj.CreateTimeRecord(driver);
        }
        [Test, Order(2), Description("This test update an existing Time Record with valid data")]
        public void TestEditTimeRecord()
        {
            TMPage tmpageObj = new TMPage();
            tmpageObj.EditTimeRecord(driver);
        }
        [Test, Order(3), Description("This test delete an existing Time Record ")]
        public void TestDeleteTimeRecord()
        {
            TMPage tmpageObj = new TMPage();
            tmpageObj.DeleteTimeRecord(driver);
        }


        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();

        }
    }
}

  


        