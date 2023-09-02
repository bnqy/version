using System;
using static System.Console;
using Class_Library_Shared_Enum;
using System.Collections.Generic;


namespace Class_Library_Shared
{
    public class Person : object
    {
        public string Name;
        public DateTime DateOfBirth;
        public SevenRegions LivingRegion;
        public SevenRegions Areas;
        public List<Person> Children = new List<Person>();
        public const string Type = "Human";
        public readonly string Country = "KG";
        public readonly DateTime RegistTime;

        public Person()
        {
            Name = "Unknown";
            RegistTime = DateTime.Now;
        }

        // TUPLES

        public (string, int) GetValues()
        {
            return ("C#", 10);
        }

        public (string name, int age) GetNamedValue()
        {
            return (name: "Sia", age: 51);
        }
    }
}
