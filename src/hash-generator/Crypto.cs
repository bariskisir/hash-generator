using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
namespace hash_generator
{
    class Crypto
    {
        public static string HashMD5(string text)
        {
            if (text == null)
                return null;
            var encode = new UTF8Encoding();
            var md5Hasher = new MD5CryptoServiceProvider();
            var data = md5Hasher.ComputeHash(encode.GetBytes(text));
            return byteToHex(data);
        }
        public static string HashSHA1(string text)
        {
            if (text == null)
                return null;
            var encode = new UTF8Encoding();
            var sha1Hasher = new SHA1CryptoServiceProvider();
            var data = sha1Hasher.ComputeHash(encode.GetBytes(text));
            return byteToHex(data);
        }
        public static string HashSHA256(string text)
        {
            if (text == null)
                return null;
            var encode = new UTF8Encoding();
            var sha256Hasher = new SHA256CryptoServiceProvider();
            var data = sha256Hasher.ComputeHash(encode.GetBytes(text));
            return byteToHex(data);
        }
        public static string HashSHA384(string text)
        {
            if (text == null)
                return null;
            var encode = new UTF8Encoding();
            var sha384Hasher = new SHA384CryptoServiceProvider();
            var data = sha384Hasher.ComputeHash(encode.GetBytes(text));
            return byteToHex(data);
        }
        public static string HashSHA512(string text)
        {
            if (text == null)
                return null;
            var encode = new UTF8Encoding();
            var sha512Hasher = new SHA512CryptoServiceProvider();
            var data = sha512Hasher.ComputeHash(encode.GetBytes(text));
            return byteToHex(data);
        }
        internal static string byteToHex(byte[] input)
        {
            if (input == null)
                return null;
            var o = new StringBuilder("");
            for (var i = 0; i < input.Length; i++)
                o.Append(input[i].ToString("X2"));
            return o.ToString();
        }
    }
}
