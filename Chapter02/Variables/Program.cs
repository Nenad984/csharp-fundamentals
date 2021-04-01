using System;
using System.Collections.Generic;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            object height = 1.88;

            object name = "Almir";
            Console.WriteLine($"{name} is {height} tall.");

            int length1 = ((string)name).Length;

            Console.WriteLine($"{name} has {length1} characters.");

            dynamic anotherName = "Nenad";

            int length = anotherName.Length;

            Console.WriteLine(length);

            var population = 66_000_000;
            var weight = 1.88;
            var price = 4.99M;
            var fruit = "Apples";
            var letter = 'Z';
            var happy = true;
          //  var xml2 = new XmlDocument();
            Console.WriteLine($"default(int) = {default(int)} ");
            Console.WriteLine($"default(bool) = {default(bool)} ");
            Console.WriteLine($"default(DateTime) = {default(DateTime)} ");
            Console.WriteLine($"default(string) = {default(string)} ");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.WriteLine(keyInfo.Key.ToString());

            List
        }
    }
}
