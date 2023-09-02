using System;
using static System.Console;
using Class_Library_Shared_Enum;
using System.Collections.Generic;


namespace Class_Library_Shared
{
    public partial class Person : object
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

        // Deconstruct

        public void Deconstruct(out string name, out DateTime dob)
        {
            name = Name;
            dob = DateOfBirth;
        }

        public void Deconstruct(out string name, out DateTime dob, out SevenRegions la)
        {
            name = Name;
            dob = DateOfBirth;
            la = LivingRegion;
        }


        // parameters ref in out
        public void Paremeters(int x, ref int y, out int z, out int alpha)
        {
            z = 999;
            alpha = 0;

            x++;
            y++;
            z++;
            alpha++;
        }
    }
}
