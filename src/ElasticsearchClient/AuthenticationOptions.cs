namespace Elasticsearch.Client
{
    /// <summary>
    /// Simple wrapper for providing authentication information for clusters which use Shield.
    /// </summary>
    public class AuthenticationOptions
    {
        /// <summary>
        /// Construct a new instance.
        /// </summary>
        /// <param name="username">The shield username.</param>
        /// <param name="password">The password for the user.</param>
        public AuthenticationOptions(string username, string password)
        {
            Username = username;
            Password = password;
        }

        internal string Username { get; private set; }

        internal string Password { get; private set; }
    }
}
