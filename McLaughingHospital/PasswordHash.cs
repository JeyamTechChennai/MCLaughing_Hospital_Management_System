using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace McLaughingHospital
{
    class PasswordHash
    {
        public string Passhash(string data)
        {
            SHA1 sha = SHA1.Create();
            byte[] bytes = sha.ComputeHash(Encoding.Default.GetBytes(data));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i]);
            }
            return sb.ToString();

        }


    }
}
