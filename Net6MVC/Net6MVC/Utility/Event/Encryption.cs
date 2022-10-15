using System.Security.Cryptography;
using System.Text;

namespace Net6MVC.Utility
{
    public class Encryption
    {
        /// <summary>
        /// Sha256 Hash
        /// </summary>
        public static string Get_SHA256_Hash(string value)
        {
            using var hash = SHA256.Create();
            var byteArray = hash.ComputeHash(Encoding.UTF8.GetBytes(value));
            return Convert.ToHexString(byteArray).ToLower();
        }
    }
}
