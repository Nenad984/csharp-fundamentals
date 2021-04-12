using System;
using CryptographyLib;

using static System.Console;

namespace EncryptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter a message that you want to encrypt: ");

            string message = ReadLine();

            Write("Enter a password: ");

            string password = ReadLine();

            string cryptoText = Protector.Encrypt(message, password);

            WriteLine($"Encrypted text: {cryptoText}");

            Write("Enter the password: ");

            try
            {
                string clearText = Protector.Decrypt(cryptoText, password);
                WriteLine($"Decrypted text: {clearText}");
            }        
            catch (Exception ex)
            {
                WriteLine("Non-cryptographic exception: {0}, {1}",
                arg0: ex.GetType().Name,
                arg1: ex.Message);
            }
        }
    }
}
