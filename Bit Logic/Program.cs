using static System.Console;
using static System.Convert;

static string ToBinString(int i)
{
    return Convert.ToString(i, toBase: 2).PadLeft(8, '0');
}

WriteLine(ToBinString(3));


WriteLine(int.MaxValue);

double d = 9.8;
int i = (int)d;

WriteLine(i);

i = ToInt32(d);
WriteLine(i);
