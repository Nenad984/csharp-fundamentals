using System;

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

        }
    }
}
