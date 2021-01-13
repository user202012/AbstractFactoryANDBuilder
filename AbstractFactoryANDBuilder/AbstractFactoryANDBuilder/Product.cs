using System;
using System.Collections.Generic;
using System.Threading;
using System.Security.Cryptography;
using System.Text;
using System.IO;

class Product
{
    public string input = "";

    public string HasherSHA256()
    {
        SHA256 SHA256 = SHA256.Create();
        byte[] data = SHA256.ComputeHash(Encoding.Default.GetBytes(input));
        StringBuilder sBuilder = new StringBuilder();
        for (int i = 0; i < data.Length; i++)
        {
            sBuilder.Append(data[i].ToString("x2"));
        }
        input = sBuilder.ToString();
        return input;
    }

    public string HasherMD5()
    {
        MD5 md5Hasher = MD5.Create();
        byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
        StringBuilder sBuilder = new StringBuilder();
        for (int i = 0; i < data.Length; i++)
        {
            sBuilder.Append(data[i].ToString("x2"));
        }
        input = sBuilder.ToString();
        return input;
    }

    public string XOR()
    {
        static char Crypter(char character, ushort secretKey)
        {
            character = (char)(character ^ secretKey);
            return character;
        }
        string NewStr = "";
        foreach (var c in input)
            NewStr += Crypter(c, 0x0088);
        input = NewStr;
        return input;
    }

    public void Show()
    {
        Console.WriteLine(input);
    }
}