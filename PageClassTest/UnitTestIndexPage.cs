using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using PageClassLib;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace PageClassTest {
    [TestClass]
    public class UnitTestIndexPage {
        [TestMethod]
        public void TestMethod1 () {
            IWebDriver driver = new ChromeDriver (@"C:\SeleniumWebdrivers");
            driver.Navigate ().GoToUrl ("http://webdriveruniversity.com/Login-Portal/index.html?");
            IndexPage indexPage = new IndexPage (driver);
            indexPage.Login ("username", "passwprd");
            Thread.Sleep (5000);
            indexPage.Quit ();
        }

        [TestMethod]
        public void TestMethod2 () {
            IWebDriver driver = new ChromeDriver (@"C:\SeleniumWebdrivers");
            driver.Navigate ().GoToUrl ("http://webdriveruniversity.com/Login-Portal/index.html?");
            HomePage homePage = new HomePage (driver);
            homePage.Login ("username", "passwprd");
            homePage.AlertAccept();
            Thread.Sleep (5000);
            homePage.Quit ();
        }

    }
}