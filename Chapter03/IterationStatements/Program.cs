using System;

using static System.Console;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            while (x < 10)
            {
                WriteLine(x);
                x++;
            }

            string password;
            int attempts = 5;
            do
            {
                WriteLine("Enter your password");
                attempts--;
                password = ReadLine();

            } while (password != "Pa$$w0rd" && attempts != 0);

            if (attempts == 0)
            {
                WriteLine("Wrong password");
            }
            else
            {
                WriteLine("Correct!");
            }



        }
    }
}
