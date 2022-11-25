using System.Security.Cryptography;
using System.Text;

namespace StockSystem.Utility
{
    public static class Security
    {
        public static string GenerateSalt(int size = 32)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(size);
            return Convert.ToBase64String(salt);
        }

        public static string HashPassword(string password, string salt, int iterations = 10000, int size = 32)
        {
            using (var rfc = new Rfc2898DeriveBytes(Encoding.ASCII.GetBytes(password), Convert.FromBase64String(salt), iterations))
            {
                return Convert.ToBase64String(rfc.GetBytes(size));
            }
        }
    }
}
