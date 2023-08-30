using static System.Console;

static double Add(double d1, double d2)
{
    return d1 + d2;
}

double d1 = 10.0;
double d2 = 3.14;
double result = Add(d1, d2);
WriteLine($"The sum result is {result}");
WriteLine(result);
WriteLine("Press ENTER to end the app.");
ReadLine();