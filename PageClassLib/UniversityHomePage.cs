using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;

namespace PageClassLib {
    public class UniversityHomePage : PageBase {
        [FindsBy (How = How.Id, Using = "text")]
        private IWebElement _home;

        [FindsBy (How = How.Id, Using = "password")]
        private IWebElement _ourProducts;

        [FindsBy (How = How.Id, Using = "login-button")]
        private IWebElement _contactUs;

        public UniversityHomePage (IWebDriver driver) : base (driver) {
            _driver = driver;
            PageFactory.InitElements (_driver, this);
        }

        public void Maximize () {
            _driver.Manage ().Window.Maximize ();
        }

        public void Quit () {
            _driver.Quit ();
        }

        public void Close () {
            _driver.Close ();
        }

        //Accepting an Alert
        public void AlertAccept () {
            IAlert alert = _driver.SwitchTo ().Alert ();
            alert.Accept ();
        }

        //Closing an Alert
        public void AlertDismiss () {
            IAlert alert = _driver.SwitchTo ().Alert ();
            alert.Dismiss ();
        }
    }
}