using System;
using System.Security.Cryptography;
using System.Text;

namespace Lib
{
    public class Utils
    {

        public static string getHash(string arg)
        {

            MD5 md5 = MD5.Create();

            string hash = Convert.ToBase64String(md5.ComputeHash(Encoding.UTF8.GetBytes(arg)));

            return hash;

        }

    }

}
