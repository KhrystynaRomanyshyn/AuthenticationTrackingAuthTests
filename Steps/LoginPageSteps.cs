using TechTalk.SpecFlow;
using TestProjectName.Pages;

namespace TestProjectName.Tests.Steps;

public class LoginPageSteps
{
    LoginPage loginPage = new LoginPage();

    #region Givens
    [Given(@"Valid user credentials are already registered")]
    public void ValidUserCredentialsAreAlreadyRegistered()
    {
        //loginPage.RegisterUser();
    }

    [Given(@"I’m on the login screen")]
    public void UserOnTheLoginScreen()
    {
        //loginPage.NavigateToLoginPage();
    }

    [When(@"I enter a valid username (.*) and password (.*) and submit")]
    public void EnterValidUsernameAndPasswordAndSubmit(string userName, string password)
    {
        loginPage.Login(userName, password);
    }

    [Then(@"I am logged in successfully")]
    public void LoggedInSuccessfully()
    {
        //loginPage.VerifyLogin();
    }
    #endregion
}
