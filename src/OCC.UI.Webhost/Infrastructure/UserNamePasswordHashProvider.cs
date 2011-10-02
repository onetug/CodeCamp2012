namespace OCC.UI.Webhost.Infrastructure
{
    using System;
    using System.Security;
    using System.Security.Cryptography;
    using System.Text;

    public sealed class UserNamePasswordHashProvider
    {
        [SecurityCritical]        
        private const string EmailAddressParameterName = "emailAddress"; 
        private const string PasswordParameterName = "password"; 
        private const string HashSalt = "573B4E18-09C1-4C21-82D0-917073903C21";
        private const string HashAlgorithmName = "SHA256";

        public static string GenerateUserNamePasswordHash(string emailAddress, string password)
        {
            if (string.IsNullOrEmpty(emailAddress))
            {
                throw new ArgumentNullException(EmailAddressParameterName);
            } 
            
            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException(PasswordParameterName);
            } 
            
            string hashInput = emailAddress.Trim() + password.Trim() + HashSalt; 
            byte[] inputBytes = ASCIIEncoding.ASCII.GetBytes(hashInput); 
            byte[] outputBytes = HashAlgorithm.Create(HashAlgorithmName).ComputeHash(inputBytes); 
            
            return Convert.ToBase64String(outputBytes);
        }
    }
}