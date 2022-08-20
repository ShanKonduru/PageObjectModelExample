using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;

namespace PageClassLib {
    public class HomePage {
        private IWebDriver _driver;

        [FindsBy (How = How.Id, Using = "text")]
        private IWebElement _userName;

        [FindsBy (How = How.Id, Using = "password")]
        private IWebElement _password;

        [FindsBy (How = How.Id, Using = "login-button")]
        private IWebElement _signIn;

        public HomePage (IWebDriver driver) {
            _driver = driver;
            _driver.Manage().Window.Maximize();
            PageFactory.InitElements (_driver , this);
        }

        public void Login (string username, string password) {
            _userName.SendKeys (username);
            _password.SendKeys (password);
            _signIn.Click ();
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