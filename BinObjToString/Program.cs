using static System.Console;
using static System.Convert;

byte[] byteObject = new byte[128];

(new Random()).NextBytes(byteObject);

WriteLine("Binary objects as bytes: ");

for(int i = 0; i < byteObject.Length; i++)
{
   Write($"{byteObject[i]:X} ");
}

WriteLine();
WriteLine();

string encoded = ToBase64String(byteObject);

Write("Binary obj as string "+encoded);

WriteLine(); WriteLine();

int age = int.Parse("19");
DateTime bday = DateTime.Parse("28 June 2003");
WriteLine($"my age is {age}");
WriteLine($"I was born in {bday}");
WriteLine($"I was born in {bday:D}");

WriteLine(); WriteLine();

Write("How old are you? ");
string? s = ReadLine();

if(int.TryParse(s, out int _age))
{
    Write($"Your age is {_age}");
}
else
{
    Write("Input only digits!");
}