using AuthenticationTrackingAuthTests.Helpers;
using OpenQA.Selenium;

namespace AuthenticationTrackingAuthTests.Pages
{
    public class LoginPage
    {
        private IWebDriver _driver;

        private By LoginTextFieldLocator => By.Id("login");

        private By PasswordTextFieldLocator => By.Id("password");

        private By SubmitButtonLocator => By.CssSelector("button[type='submit']");

        private By PopupBodyLabel => By.ClassName("popup-body");

        public LoginPage()
        {
            _driver = Driver.GetDriver();
        }

        public void EnterLogin(string login)
        {
            Wait.WaitForElementVisible(_driver, LoginTextFieldLocator, 10);
            _driver.FindElement(LoginTextFieldLocator).SendKeys(login);
        }

        public void EnterPassword(string password)
        {
            _driver.FindElement(PasswordTextFieldLocator).SendKeys(password);
        }

        public void ClickSubmitButton()
        {
            Wait.WaitForElementClickable(_driver, SubmitButtonLocator, 10);
            _driver.FindElement(SubmitButtonLocator).Click();
        }

        public void Login(string login, string password)
        {
            EnterLogin(login);
            EnterPassword(password);
            ClickSubmitButton();
        }

        public bool IsPopupOpen()
        {
            Wait.WaitForPageLoadComplete(_driver);
            return _driver.FindElement(PopupBodyLabel).Displayed;
        }
    }
}
