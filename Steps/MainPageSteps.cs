using AuthenticationTrackingAuthTests.Helpers;
using AuthenticationTrackingAuthTests.Models;
using AuthenticationTrackingAuthTests.Pages;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace AuthenticationTrackingAuthTests.Steps
{
    [Binding]
    public class MainPageSteps
    {
        private readonly MainPage _mainPage = new MainPage();

        [Given(@"I’m on the login screen")]
        public void UserOnTheLoginScreen()
        {
            _mainPage.NavigateToLoginPage();
        }

        [Given(@"I’m not logged in with a genuine user")]
        public void GivenIMNotLoggedInWithAGenuineUser()
        {
            // Do nothing
        }

        [When(@"I navigate to any page on the tracking site")]
        public void WhenINavigateToAnyPageOnTheTrackingSite()
        {
            _mainPage.NavigateToPaymentPage();
        }

        [Then(@"I am logged in successfully")]
        public void LoggedInSuccessfully()
        {
            var user = (User)Context.Get("user");
            _mainPage.GetAccountTitle().Should().Be(user.Name, "Account title should match logged user name");
        }
    }
}
