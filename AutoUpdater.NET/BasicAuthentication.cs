using System;
using System.Net;
using System.Text;

namespace AutoUpdaterDotNET
{
    /// <summary>
    ///     Provides Basic Authentication header for web request.
    /// </summary>
    public class BasicAuthentication : IAuthentication
    {
<<<<<<< HEAD
        internal string Username { get; }

        internal string Password { get; }
=======
        private string Username { get; }

        private string Password { get; }
>>>>>>> parent of f90cc88 (Fixed an issue with WebView2 when changelog has linked files and basic authentication is enabled (#537))

        /// <summary>
        ///     Initializes credentials for Basic Authentication.
        /// </summary>
        /// <param name="username">Username to use for Basic Authentication</param>
        /// <param name="password">Password to use for Basic Authentication</param>
        public BasicAuthentication(string username, string password)
        {
            Username = username;
            Password = password;
        }

        /// <inheritdoc />
        public override string ToString()
        {
            var token = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{Username}:{Password}"));
            return $"Basic {token}";
        }
        
        /// <inheritdoc />
        public void Apply(ref MyWebClient webClient)
        {
            webClient.Headers[HttpRequestHeader.Authorization] = ToString();
        }
    }
}
