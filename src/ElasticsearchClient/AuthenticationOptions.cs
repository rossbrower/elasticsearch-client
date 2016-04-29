namespace Elasticsearch.Client
{
    public class AuthenticationOptions
    {
        public AuthenticationOptions(string username, string password)
        {
            Username = username;
            Password = password;
        }

        internal string Username { get; private set; }

        internal string Password { get; private set; }
    }
}
