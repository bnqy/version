using static System.Console;

WriteLine("Input a number between 0 and 255: ");
string? firstStr = ReadLine();

WriteLine("Input a number between 0 and 255: ");
string? secondStr = ReadLine();

if (Int32.TryParse(firstStr, out int i) & Int32.TryParse(secondStr, out int j))
{
    WriteLine($"{i}/{j} is {i/j}");
}