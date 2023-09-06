using BnqLib;
using static System.Console;

Person kylie = new Person() {Name = "Kylie" };
Person travis = new() { Name = "Travis" };
Person stormi = kylie.BabyCreateWith(travis);
//WriteLine(strormi.Name);
stormi.Name = "Stormi";
Person air = Person.BabyCreate(kylie, travis);
air.Name = "Air";

Person den = kylie * travis;
den.Name = "Den";

WriteLine($"Kylie has {kylie.Children.Count} children");
WriteLine($"Travis has \"{travis.Children.Count}\" children");
WriteLine("Their children:");
foreach (var children in kylie.Children)
{
    WriteLine($" {children.Name}");
}
WriteLine();

//delegate

static void Kylie_Shout(object? sender, EventArgs e)
{
    if (sender is null)
    {
        return;
    }

    Person person = (Person)sender;
    WriteLine($"{person.Name} is this angry: {person.AngerLevel}");
}

// ===>

kylie.Shout += Kylie_Shout;
kylie.Poke();
kylie.Poke();
kylie.Poke();
kylie.Poke();
WriteLine();

// Non generics
//System.Collections.Hashtable lookupObject = new();
System.Collections.Hashtable lookupObject = new System.Collections.Hashtable();
lookupObject.Add(1, "One");
lookupObject.Add(2, "Two");
lookupObject.Add(3, "Three");
lookupObject.Add(kylie, "FourK");

int key = 2;
WriteLine($"Key {key} has value: {lookupObject[key]}");
WriteLine($"Key {kylie} has value: {lookupObject[kylie]}");
WriteLine();

// Generics
Dictionary<int, string> lookupIntString = new();
lookupIntString.Add(1, "One");
lookupIntString.Add(2, "Two");
lookupIntString.Add(3, "Three");
lookupIntString.Add(4, "Four");
int key1 = 4;
WriteLine($"Key {key1} has value: {lookupIntString[key1]}");
WriteLine();

// Interfaces

Person[] people =
{
    new Person() {Name = "Kris"},
    new Person() {Name = "Khloe" },
    new() {Name = "Kim"},
    new() {Name = "Kendall"}
};

foreach (Person p in people)
{
    WriteLine($" {p.Name}");
}

Array.Sort(people);
WriteLine("=> sorted");
foreach (Person p in people)
{
    WriteLine($" {p.Name}");
}