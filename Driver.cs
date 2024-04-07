using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace AuthenticationTrackingAuthTests
{
    public static class Driver
    {
        private static IWebDriver _driver;

        public static void InitializeDriver()
        {
           _driver = new ChromeDriver();
           _driver.Manage().Window.Maximize();
           SetImplicitWait(TimeSpan.FromSeconds(10));
        }

        public static void SetImplicitWait(TimeSpan elementTimeout)
            => _driver.Manage().Timeouts().ImplicitWait = elementTimeout;

        public static void GoToUrl(string url)
            => _driver.Navigate().GoToUrl(url);

        public static void QuitDriver()
        {
            _driver.Quit();
            _driver = null;
        }

        public static IWebDriver GetDriver()
        {
            if (_driver == null)
            {
                InitializeDriver();
            }

            return _driver;
        }
    }
}
