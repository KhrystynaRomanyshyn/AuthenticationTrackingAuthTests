using AuthenticationTrackingAuthTests.Configurations;
using AuthenticationTrackingAuthTests.Helpers;
using AuthenticationTrackingAuthTests.Models;
using AuthenticationTrackingAuthTests.Pages;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace AuthenticationTrackingAuthTests.Steps
{
    [Binding]
    public class LoginPageSteps
    {
        private readonly LoginPage _loginPage = new LoginPage();
        private User _user;

        [Given(@"(ValidUser|NotValidUser) credentials are already registered")]
        public void ValidUserCredentialsAreAlreadyRegistered(string userName)
        {
            _user = Credentials.GetUser(userName);
            Context.Set("user", _user);
        }

        [When(@"I enter a valid username and password and submit")]
        public void EnterValidUsernameAndPasswordAndSubmit()
        {
            _loginPage.Login(_user.Login, _user.Password);
        }

        [Then(@"I am presented with a login screen")]
        public void ThenIAmPresentedWithALoginScreen()
        {
            _loginPage.IsPopupOpen().Should().BeTrue("Login screen should be displayed");
        }
    }
}