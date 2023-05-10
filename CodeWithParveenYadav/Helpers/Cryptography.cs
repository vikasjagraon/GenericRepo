using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CodeWithParveenYadav.Helpers
{
    public static class Cryptography
    {
        #region encryption
        public static string Encrypt(string clearText, string encryptionKey)
        {
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(encryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

        public static string Decrypt(string cipherText, string encryptionKey)
        {
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(encryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }
        #endregion

        #region Hashing

        public static string HashPassword(string password)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(password);

            SHA256Managed sHA256ManagedString = new SHA256Managed();

            byte[] hash = sHA256ManagedString.ComputeHash(bytes);

            return Convert.ToBase64String(hash);
        }

        #endregion

        #region Hah with Salt
        public static string HashPasswordWithSalt(string password)
        {
            
            byte[] bytes = Encoding.UTF8.GetBytes(password);

            SHA256Managed sHA256ManagedString = new SHA256Managed();

            byte[] hash = sHA256ManagedString.ComputeHash(bytes);

            var salt = Guid.NewGuid();
            return (salt + ":" + Convert.ToBase64String(hash));
        }

        #endregion

    }
}
