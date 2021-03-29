using System;

namespace HelloCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int z;
            var person = new Person("Nenad", 25);


            Console.WriteLine(person.Name);


        }

        public record Person(string Name, int Age);
    }
}
