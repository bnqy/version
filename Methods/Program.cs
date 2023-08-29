using static System.Console;

Table(9);
WriteLine();
Write(CardinalToOrdinal(123));

static void Table(byte b)
{
    WriteLine($"{b}'s time table:");

    for(byte b2 = 1; b2 <= 10; b2++)
    {
        WriteLine($"{b} x {b2} = {b * b2}");
    }
}

static string CardinalToOrdinal(int number)
{
    int lastTwoDigit = number % 100;

    switch (lastTwoDigit)
    {
        case 11:
        case 12:
        case 13:
            return $"{number}th";
        default:
            int lastDigit = lastTwoDigit % 10;
            string last = lastDigit switch
            {
                1 => "st",
                2 => "nd",
                3 => "rd",
                _ => "th"

            };
            return $"{number}{last}";
    }
}