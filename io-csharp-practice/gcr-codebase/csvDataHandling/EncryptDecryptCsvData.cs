using System;
using System.Text;

class EncryptDecryptCsvData
{
    static string Encrypt(string s) =>
        Convert.ToBase64String(Encoding.UTF8.GetBytes(s));

    static string Decrypt(string s) =>
        Encoding.UTF8.GetString(Convert.FromBase64String(s));
}
