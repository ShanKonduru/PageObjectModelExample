using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;

namespace PageClassLib {
    public class PageBase {
        public IWebDriver _driver;

        public PageBase (IWebDriver driver) {
            _driver = driver;
        }
        public void Quit () {
            _driver.Quit ();
        }

        public void Close () {
            _driver.Close ();
        }

        public void AlertAccept () {
            IAlert alert = _driver.SwitchTo ().Alert ();
            alert.Accept ();
        }

        public void AlertDismiss () {
            IAlert alert = _driver.SwitchTo ().Alert ();
            alert.Dismiss ();
        }
    }
}