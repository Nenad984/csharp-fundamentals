using System;

namespace NullHandling
{
    
    class Program
    {
       

        class Address
        {
            public string? Building;
            public string Street = string.Empty;
            public string City = string.Empty;
            public string Region = string.Empty;
        }

        static void Main(string[] args)
        {
            int thisCannotBeNull = 4;
            // thisCannotBeNull = null; compile error!
            int? thisCouldBeNull = null;

            Console.WriteLine(thisCouldBeNull);

            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

            thisCouldBeNull = 7;

            Console.WriteLine(thisCouldBeNull);

            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

            var address = new Address();

            address.Building = null;
            address.City = "London";
            address.Street = null;
            address.Region = null;

             // check that the variable is not null before using it
            /* if(thisCouldBeNull != null)
            {
               // int length = thisCouldBeNull.Length; // could throw exception
            } */

            string authorName = null;

            // the following throws a NullReferenceException
            // int? y = authorName.Length;

            var result = authorName?.Length ?? 3;

            Console.WriteLine(result);



        }
    }
}
