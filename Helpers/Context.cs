using TechTalk.SpecFlow;

namespace AuthenticationTrackingAuthTests.Helpers
{
    public static class Context
    {
        public static object Get(string key)
        {
            if (ScenarioContext.Current.ContainsKey(key))
                return ScenarioContext.Current[key];
                
            return null;
        }

        public static void Set<T>(string key, T value)
        {
            if (!ScenarioContext.Current.ContainsKey(key))
                ScenarioContext.Current.Add(key, value);
            else
                ScenarioContext.Current[key] = value;
        }
    }
}