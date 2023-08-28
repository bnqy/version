using static System.Console;

Write("Input a number between 0 and 255: ");
string? firstStr = ReadLine();

Write("Input a number between 0 and 255: ");
string? secondStr = ReadLine();

try
{
    byte a = byte.Parse(firstStr);
    byte b = byte.Parse(secondStr);

    int answer = a / b;

    WriteLine($"{a} divided by {b} is {answer}");
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType().Name}: {ex.Message}");
}