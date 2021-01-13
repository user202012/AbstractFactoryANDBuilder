using System;
using System.Threading;
using System.Security.Cryptography;
using System.Text;
using System.IO;


public class ProductA1 : AbstractProductA
{
    public override void Hasher(string input)
    {
        SHA256 SHA256 = SHA256.Create();
        byte[] data = SHA256.ComputeHash(Encoding.Default.GetBytes(input));
        StringBuilder sBuilder = new StringBuilder();
        for (int i = 0; i < data.Length; i++)
        {
            sBuilder.Append(data[i].ToString("x2"));
        }
        Console.WriteLine(sBuilder.ToString());
    }
}

public class ProductB1 : AbstractProductB
{
    public override void Hasher(string input)
    {
        MD5 md5Hasher = MD5.Create();
        byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
        StringBuilder sBuilder = new StringBuilder();
        for (int i = 0; i < data.Length; i++)
        {
            sBuilder.Append(data[i].ToString("x2"));
        }
        Console.WriteLine(sBuilder.ToString());
    }
}

public class ProductA2 : AbstractProductA
    {
    public override void Hasher(string input)
    {
        SHA256 SHA256 = SHA256.Create();
        byte[] data = SHA256.ComputeHash(Encoding.Default.GetBytes(input));
        StringBuilder sBuilder = new StringBuilder();
        for (int i = 0; i < data.Length; i++)
        {
            sBuilder.Append(data[i].ToString("x4"));
        }
        Console.WriteLine(sBuilder.ToString());
    }
}


public class ProductB2 : AbstractProductB
{
    public override void Hasher(string input)
    {
        MD5 md5Hasher = MD5.Create();
        byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
        StringBuilder sBuilder = new StringBuilder();
        for (int i = 0; i < data.Length; i++)
        {
            sBuilder.Append(data[i].ToString("x4"));
        }
        Console.WriteLine(sBuilder.ToString());
    }
}

