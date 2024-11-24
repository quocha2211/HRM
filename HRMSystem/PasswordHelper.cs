using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem
{
    public static class PasswordHelper
    {

        public static string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Convert the password to a byte array and compute the hash
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convert the byte array to a string
                StringBuilder builder = new StringBuilder();
                foreach (byte t in bytes)
                {
                    builder.Append(t.ToString("x2"));
                }

                return builder.ToString(); // Return the hashed password
            }
        }

        public static bool VerifyPassword(string password, string hashedPassword)
        {
            // Hash the input password and compare with stored hashed password
            string hashedInputPassword = HashPassword(password);
            return hashedInputPassword.Equals(hashedPassword, StringComparison.OrdinalIgnoreCase);
        }

    }

    public enum UserRole
    {
        Admin,
        User
    }

    public static class UserSession
    {
        public static UserRole CurrentUserRole { get; set; }
        public static int LoginId { get; set; }
    }

 
}

