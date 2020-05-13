using System.ComponentModel;

namespace NUnit.NETCoreWebAutomation.Models
{
    public class LoginModel
    {
        public string EmailAddress { get; set; }
        public string Password { get; set; }
    }

    public static class LoginElement
    {
        public const string emailAddress = "identifierId"; // ID
        public const string password = "password"; // Name

        public const string nextButtonEmail = "identifierNext"; // ID
        public const string nextButtonPassword = "passwordNext"; // ID
    }
}
