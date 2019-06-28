using System.Security.Cryptography;
using System.Text;

namespace dotNet_ApiRobusta.Domain.Extensions
{
    public static class StringExtension
    {
        public static string ConvertToMD5(this string password)
        {
            if (string.IsNullOrEmpty(password)) return "";

            string pass = password += "|2d331cca-f6c0-bb43-Ge32989c2881";
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] data = md5.ComputeHash(Encoding.Default.GetBytes(pass));
            var sbString = new StringBuilder();

            foreach (var item in data)
                sbString.Append(item.ToString("x2"));

            return sbString.ToString();
        }
    }
}
