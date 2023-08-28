using static System.Console;
using static System.Convert;

WriteLine("Before parsing");
Write("What is your age? ");
string? input = ReadLine();
try
{
    int age = int.Parse(input);
    WriteLine($"You are {age} years old.");
}
catch(Exception ex )
{
    WriteLine($"{ex.GetType()} says {ex.Message}");
}
WriteLine("After parsing");


try
{
    checked
    {
        int x = int.MaxValue - 1;
        WriteLine($"int.MaxValue - 1 = {x}");
        x++;
        WriteLine($"int.MaxValue = {x}");
        x++;
        WriteLine($"int.MaxValue++ = {x}");
        x++;
        WriteLine($"int.MaxValue++ ++ = {x}");
    }
}
catch (OverflowException)
{
    Write("Over Flow Exception");
}