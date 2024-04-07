using AuthenticationTrackingAuthTests.Models;
using System.Collections.Generic;

namespace AuthenticationTrackingAuthTests.Configurations
{
    public static class Credentials
    {
        private static List<User> Users = new List<User>
        {
            new User("ValidUser", "userLogin", "userPassword"),
            new User("NotValidUser", "123userLogin", "123userPassword"),
        };

        public static User GetUser(string userName)
        {
            return Users.Find(u => u.Name == userName);
        }
    }
}
