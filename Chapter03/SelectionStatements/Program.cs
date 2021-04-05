using System;
using System.IO;

using static System.Console;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                WriteLine("There are no arguments");
            }
            else
            {
                // e.g dotnet run red --> one argument
                WriteLine("There is at least one argument.");
                foreach (string arg in args)
                {
                    WriteLine(arg);
                }
            }

            object o = 3;

            int j = 4;

            // pattern matching
            if (o is int i)
            {
                WriteLine($"{i} x {j} = {i * j}");
            }
            else
            {
                WriteLine("o is not an int so it cannot multiply!");
            }

        A_label:

            var number = new Random().Next(1, 7);

            WriteLine($"My random number is {number}");

            switch (number)
            {
                case 1:
                    WriteLine("one");
                    break;
                case 2:
                    WriteLine("two");
                    goto case 1;
                case 3:
                case 4:
                    WriteLine("Three or four");
                    goto case 1;
                case 5:
                    // go to sleep for half a second
                    System.Threading.Thread.Sleep(500);
                    goto A_label;
                default:
                    WriteLine("Default"); break;

            }

            string path = @"D:\projects\csharp-fundamentals\Chapter03";

            Stream s = File.Open(Path.Combine(path, "file.txt"), FileMode.OpenOrCreate);

            string message = string.Empty;

            switch (s)
            {
                case FileStream writeableFile when s.CanWrite:
                    message = "The stream is a file that I can write to.";
                    break;
                case FileStream readOnlyFile:
                    message = "The stream is a read-only file.";
                    break;
                case MemoryStream ms:
                    message = "The stream is a memory address.";
                    break;
                default: // always evaluated last despite its current position 
                    message = "The stream is some other type.";
                    break;

                case null:
                    message = "The stream is null";
                    break;
            }

            WriteLine(message);
            // Simplifying switch statements with switch expressions
            message = s switch
            {
                FileStream writeableFile when s.CanWrite
                    => "The stream is a file that I can write to.",
                FileStream readOnlyFile
                    => "The stream is a memory address.",
                null
                    => "The stream is null",
                _
                    => "The stream is some other type."
            };

            WriteLine(message);


        }
    }
}
