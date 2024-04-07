using AuthenticationTrackingAuthTests;
using TechTalk.SpecFlow;

namespace AuthenticationTrackingAuth.SpecFlow
{
    [Binding]
    public static class Hooks
    {
        [BeforeScenario]
        public static void BeforeScenario()
        { 
            Driver.InitializeDriver();
            Driver.GoToUrl("https://example.com/main.html");
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            Driver.QuitDriver();
        }
    }
}
