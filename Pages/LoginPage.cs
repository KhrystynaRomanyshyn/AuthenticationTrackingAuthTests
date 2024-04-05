using OpenQA.Selenium;

namespace TestProjectName.Pages
{
    public class LoginPage
    {
        //[FindsBy(How = How.Id, Using ="")]
        //IWebElement LoginTextField;

        //[FindsBy(How = How.CssSelector, Using = "input[type='password']")]
        //IWebElement PasswordTextField;

        //[FindsBy(How = How.ClassName, Using = "LoginButton")]
        //IWebElement LoginButton; 

        public void Login(string login, string password)
        {
           // WaitForPageLoad();
            //LoginTextField.SendKeys(login);
            //PasswordTextField.SendKeys(password);
            //LoginButton.Click();
        }
    }
}
