using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FBLA {
    class Password {
        public static string HashPassword(string str) {
            SHA256Managed sha = new SHA256Managed();
            string hash = String.Empty;

            byte[] crypto = sha.ComputeHash(Encoding.ASCII.GetBytes(str), 0, Encoding.ASCII.GetByteCount(str));
            foreach (byte b in crypto) {
                hash += b.ToString("x2");
            }

            return hash;
        }

      
    }
}
