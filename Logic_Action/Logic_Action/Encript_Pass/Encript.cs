using System;
using System.Security.Cryptography;

namespace Logic_Action.Encript_Pass
{
    public static class Encript
    {

        private const int SaltSize = 16;
        private const int HashSize = 20;
        private const int Iterations = 10000;

        public static (string, byte[]) HashPassword(string password)
        {
            // Generate a random salt
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[SaltSize]);

            // Hash the password with PBKDF2
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations);
            byte[] hash = pbkdf2.GetBytes(HashSize);

            // Combine salt and hash
            byte[] hashBytes = new byte[SaltSize + HashSize];
            Array.Copy(salt, 0, hashBytes, 0, SaltSize);
            Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);

            // Convert to base64 and return as a string
            return (Convert.ToBase64String(hashBytes), salt);
        }


        public static bool VerifyPassword(string password, string storedHashedPassword, byte[] Salt)
        {
            // Convert the stored hash from base64 to bytes
            byte[] hashBytes = Convert.FromBase64String(storedHashedPassword);

            // Extract the salt and hash from the stored hash
            byte[] salt = Salt;
            Array.Copy(hashBytes, 0, salt, 0, SaltSize);

            // Compute the hash of the entered password with the same salt
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations);
            byte[] hash = pbkdf2.GetBytes(HashSize);

            // Compare the computed hash with the stored hash
            for (int i = 0; i < HashSize; i++)
            {
                if (hashBytes[i + SaltSize] != hash[i])
                    return false;
            }

            return true;
        }
    }
}

