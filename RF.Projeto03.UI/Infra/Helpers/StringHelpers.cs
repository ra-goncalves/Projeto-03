using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace RF.Projeto03.UI.Infra.Helpers
{
    public class StringHelpers
    {
        public string Encrypt(string senha)
        {
            var salt = "4B527F8124FB46D7AD69202D5E920064BD67F08";

            var arrayBytes = Encoding.UTF8.GetBytes(senha + salt);

            byte[] hashBytes;

            using (var sha = SHA512.Create())
            {
                hashBytes = sha.ComputeHash(arrayBytes);
            }

            return Convert.ToBase64String(hashBytes);
        }
    }
}