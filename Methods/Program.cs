using static System.Console;

Table(7);

static void Table(byte b)
{
    WriteLine($"{b}'s time table:");

    for(byte b2 = 1; b2 <= 10; b2++)
    {
        WriteLine($"{b} x {b2} = {b * b2}");
    }
}