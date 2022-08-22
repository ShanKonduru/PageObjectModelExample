using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;

namespace PageClassLib {
    public class HomePage : PageBase {
        [FindsBy (How = How.Id, Using = "text")]
        private IWebElement _userName;

        [FindsBy (How = How.Id, Using = "password")]
        private IWebElement _password;

        [FindsBy (How = How.Id, Using = "login-button")]
        private IWebElement _signIn;

        public HomePage (IWebDriver driver) : base (driver) {
            PageFactory.InitElements (_driver, this);
        }

        public void Maximize () {
            _driver.Manage ().Window.Maximize ();
        }

        public void Login (string username, string password) {
            _userName.SendKeys (username);
            _password.SendKeys (password);
            _signIn.Click ();
        }
    }
}