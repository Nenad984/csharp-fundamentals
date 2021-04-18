using System;

namespace HelloCS
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");

            var person = new Person("Nenad", 25);

            Console.WriteLine(person.Name);
        }

        public record Person(string Name, int Age);
    }
}
