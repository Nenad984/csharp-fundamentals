using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace WorkingWithSerialization
{
    public class Person
    {
        protected decimal Salary;

        [XmlAttribute("fname")]
        public string FirstName { get; set; }

        [XmlAttribute("lname")]
        public string LastName { get; set; }
        
        [XmlAttribute("dob")]
        public DateTime DateOfBirth { get; set; }

        public HashSet<Person> Children { get; set; }
        public Person(decimal initialSalary)
        {
            this.Salary = initialSalary;
        }

        public Person()
        {

        }
    }
}