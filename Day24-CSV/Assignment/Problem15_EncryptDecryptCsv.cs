using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

class Problem15_EncryptDecryptCsv
{
    private static readonly byte[] Key =
        Encoding.UTF8.GetBytes("12345678901234567890123456789012");
    private static readonly byte[] IV =
        Encoding.UTF8.GetBytes("1234567890123456");

    public static void Run()
    {
        string inputFile = "employees.csv";
        string encryptedFile = "encrypted_employees.csv";

        string[] lines = File.ReadAllLines(inputFile);
        using Aes aes = Aes.Create();
        aes.Key = Key;
        aes.IV = IV;

        List<string> encryptedLines = new List<string>();

        encryptedLines.Add(lines[0]);
        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');
            // encrypt Email and Salary
            data[3] = Encrypt(data[3]);
            encryptedLines.Add(string.Join(",", data));
        }
        File.WriteAllLines(encryptedFile, encryptedLines);
        Console.WriteLine("CSV data encrypted.");
        // decrypt

        string[] encryptedData =
            File.ReadAllLines(encryptedFile);

        Console.WriteLine("\nDecrypted Data:");
        for (int i = 1; i < encryptedData.Length; i++)
        {
            string[] data = encryptedData[i].Split(',');
            data[3] = Decrypt(data[3]);
            Console.WriteLine(string.Join(",", data));
        }
    }
    static string Encrypt(string text)
    {
        using Aes aes = Aes.Create();
        aes.Key = Key;
        aes.IV = IV;
        ICryptoTransform encryptor =aes.CreateEncryptor();

        byte[] inputBytes =Encoding.UTF8.GetBytes(text);
        byte[] encryptedBytes =encryptor.TransformFinalBlock(inputBytes,0,inputBytes.Length );
        return Convert.ToBase64String(encryptedBytes);
    }
    static string Decrypt(string encryptedText)
    {
        using Aes aes = Aes.Create();
        aes.Key = Key;
        aes.IV = IV;
        ICryptoTransform decryptor =aes.CreateDecryptor();
        byte[] encryptedBytes = Convert.FromBase64String(encryptedText);

        byte[] decryptedBytes =
            decryptor.TransformFinalBlock(encryptedBytes,0,encryptedBytes.Length);
        return Encoding.UTF8.GetString(decryptedBytes);
    }
}