namespace AuthenticationTrackingAuthTests.Models
{
    public class User
    {
        public string Name { get; }
        public string Login { get; }
        public string Password { get; }


        public User(string name, string login, string password)
        {
            Name = name;
            Login = login;
            Password = password;
        }
    }
}