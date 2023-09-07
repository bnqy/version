namespace BnqLib;
using static System.Console;


public class Employee : Person
{
    public string? EmployeeCode { get; set; }
    public int HireDate { get; set; }

    public new void WriteTo()
    {
        WriteLine($"{Name} was hired with {EmployeeCode}");
    }

    /*public override string ToString()
    {
        return $"{EmployeeCode} is a {base.ToString()}";
    }*/
}
