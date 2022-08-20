using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PageClassLib {
    public class IndexPage {
        private IWebDriver _driver;
        private IWebElement _userName;
        private IWebElement _password;
        private IWebElement _signIn;
        public IndexPage (IWebDriver driver) {
            _driver = driver;
            _userName = _driver.FindElement (By.Id ("text"));
            _password = _driver.FindElement (By.Id ("password"));
            _signIn = _driver.FindElement (By.Id ("login-button"));
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
            _driver.Close  ();
        }
    }
}