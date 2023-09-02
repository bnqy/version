using System;
namespace Class_Library_Shared
{
    public partial class Person
    {
        public string GetOrigin
        {
            get 
            { 
                return $"{Name} lives in {LivingRegion}";
            }
        }

        public string Greetings => $"Greetings from {Name}";
        public int Age => DateTime.Today.Year - DateOfBirth.Year;
    }
}
