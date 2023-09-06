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

kylie.Shout = Kylie_Shout;
kylie.Poke();
kylie.Poke();
kylie.Poke();
kylie.Poke();