using System;
using System.Collections.Generic;

namespace MyLibrary.Shared
{
    public class ThingOfDefaults
    {
        public int Population;
        public DateTime When;
        public string Name;
        public List<Person> People;

        public ThingOfDefaults()
        {
            // C# 7.1 and later
            Population = default;
            When = default;
            Name = default;
            People = default;
        }
    }
}
