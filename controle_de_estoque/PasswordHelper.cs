using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace controle_de_estoque
{
    internal class PasswordHelper
    {
        public static string GenerateSalt()
        {
            byte[] saltbytes = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltbytes);
            }
            return Convert.ToBase64String(saltbytes);
        }

        public static string HashPassword(string password, string salt)
        {

            using (SHA256 sha256 = SHA256.Create())
            {
                string saltedPassword = password + salt;
                byte[] bytes = Encoding.UTF8.GetBytes(saltedPassword);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

    }
}
