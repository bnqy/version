namespace Class_Library_Shared
{

    public class BusinessClassPassengers
    {
        public override string ToString()
        {
            return "Business Class";
        }
    }

    public class FirstClassPassengers
    {
        public int AirMiles { get; set; }
        public override string ToString()
        {
            return $"First Class with {AirMiles} Miles";
        }
    }

    public class CoachClassPassengers
    {
        public double CarryOnKg { get; set; }
        public override string ToString()
        {
            return $"Coach Class with {CarryOnKg:N2} KG carry on";
        }
    }
}