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
    }
}
