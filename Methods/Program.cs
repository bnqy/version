using static System.Console;

Table(9);
WriteLine();
Write(CardinalToOrdinal(123));
WriteLine();
AllCardToOrd(50);
WriteLine();
WriteLine($"Factorial of 7 is {Factorial(7)}");
WriteLine();
RunFactorials();

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

static void AllCardToOrd(int quant)
{
    for(int i = 1; i <= quant; i++)
    {
        Write($"{CardinalToOrdinal(i)} ");
    }
    WriteLine();
}

static int Factorial(int n)
{
    if (n == 0 | n == 1)
    {
        return 1;
    }
    else
    {
        checked
        {
            return n * Factorial(n - 1);
        }
    }
}

static void RunFactorials()
{
        for (int i = 1; i <= 15; i++)
        {
            try
            {
                WriteLine($"{i}! = {Factorial(i):N0}");
            }
            catch(Exception ex)
            {
                WriteLine($"{i}! --> {ex.GetType().Name}");
            }

        }
}