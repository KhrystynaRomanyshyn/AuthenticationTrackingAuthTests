using OpenQA.Selenium;

namespace AuthenticationTrackingAuthTests.Pages
{
    public class MainPage
    {
        private IWebDriver _driver;

        private By LoginMenuItemLocator => By.Id("login");

        private By PaymentMenuItemLocator => By.Id("PaymentMenu");

        private By AccountTitleLocator => By.ClassName("AccountTitle");

        public MainPage()
        {
            _driver = Driver.GetDriver();
        }

        public void NavigateToLoginPage()
        {
            _driver.FindElement(LoginMenuItemLocator).Click();
        }

        public string GetAccountTitle()
        {
            return _driver.FindElement(AccountTitleLocator).Text;
        }

        public void NavigateToPaymentPage()
        {
            _driver.FindElement(PaymentMenuItemLocator).Click();
        }
    }
}
