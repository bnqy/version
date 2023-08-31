using static System.Console;
namespace StackExceptionHandlingLib;

public class Calculator
{
    public static void Gamma()
    {
        WriteLine("In Gamma");
        Delta();
    }
    private static void Delta()
    {
        WriteLine("In Delta");
        File.OpenText("bad file path");
    }
}