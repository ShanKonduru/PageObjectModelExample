using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageClassLib;

namespace PageClassTest {
    [TestClass]
    public class UnitTestIndexPage {
        [TestMethod]
        [Ignore]
        public void TestMethod1 () {
            IWebDriver driver = new ChromeDriver (@"C:\SeleniumWebdrivers");
            driver.Navigate ().GoToUrl ("http://webdriveruniversity.com/Login-Portal/index.html?");
            HomePage homePage = new HomePage (driver);
            homePage.Maximize ();
            homePage.Login ("username", "passwprd");
            homePage.AlertAccept ();
            Thread.Sleep (5000);
            homePage.Quit ();
        }
        /*
        [DataSource ("Microsoft.VisualStudio.TestTools.DataSource.CSV", ".\\TestsData.csv", "TestsData#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void DataDrivenTest () {
            double operandOne = Convert.ToDouble (TestContext.DataRow["OperandOne"]);
            double operandTwo = Convert.ToDouble (TestContext.DataRow["OperandTwo"]);
            double expected = Convert.ToDouble (TestContext.DataRow["ExpectedResult"]);
            Assert.AreEqual (expected, operandOne + operandTwo);
        }
        */
        [TestMethod]
        [Ignore]
        public void TestMethod2 () {
            IWebDriver driver = new ChromeDriver (@"C:\SeleniumWebdrivers");
            driver.Navigate ().GoToUrl ("http://www.webdriveruniversity.com/Page-Object-Model/products.html");
            UniversityHomePage homePage = new UniversityHomePage (driver);
            homePage.Maximize ();
            Thread.Sleep (5000);
            homePage.Quit ();
        }
        [TestMethod]
        public void TestHomePageLoginMethod() {
            IWebDriver driver = new ChromeDriver (@"C:\SeleniumWebdrivers");
            driver.Navigate ().GoToUrl ("http://www.webdriveruniversity.com/Page-Object-Model/products.html");
            HomePage homePage = new HomePage(driver);
            homePage.Maximize ();
            Thread.Sleep (5000);
            homePage.Quit ();
        }
    }
}