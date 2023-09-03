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

        public string favPrimeColor;
        public string FavPrimeColor
        {
            get
            {
                return favPrimeColor;
            }

            set
            {
                switch (value.ToLower())
                {
                    case "red":
                    case "green":
                    case "blue":
                        favPrimeColor = value;
                        break;
                    default:
                        throw new System.ArgumentException(
                        $"{value} is not a primary color. " +
                        "Choose from: red, green, blue.");
                }
            }
        }

    }
}
