using BnqLib;
using static System.Console;

Person kylie = new Person() {Name = "Kylie" };
Person travis = new() { Name = "Travis" };
Person stormi = kylie.BabyCreateWith(travis);
kylie.DateOfBirth = new DateTime(1995, 01, 12);
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
WriteLine();

// IComparer
Array.Sort(people, new PersonComparer());
foreach (Person p in people)
{
    WriteLine($" {p.Name}");
}
WriteLine();

// Structs Value Types

DisplaceVectors d1 = new(-1, 3);
DisplaceVectors d2 = new DisplaceVectors(0, -3);
DisplaceVectors d3 = d1 + d2;

WriteLine($"({d1.X}, {d1.Y}) + ({d2.X}, {d2.Y}) = ({d3.X}, {d3.Y})");
WriteLine();

// Inheritance

Employee employee = new() {Name = "Finn"};
WriteLine(employee.Name);
employee.EmployeeCode = "SW0981";
WriteLine(employee.EmployeeCode);
employee.WriteTo();
WriteLine();

// override
WriteLine(employee.ToString());
WriteLine();

// Prived in preobr

Employee adiletInEmployee = new Employee { EmployeeCode = "EE92018", Name = "Adilet" };
Person adiletInPerson = adiletInEmployee;
adiletInEmployee.WriteTo();
adiletInPerson.WriteTo();
WriteLine(adiletInPerson.ToString());
WriteLine(adiletInEmployee.ToString());
WriteLine();


// privid Exception Handling with IS
//Employee explicitAdilet = (Employee)adiletInPerson;

if (adiletInPerson is Employee)
{
    WriteLine($"{nameof(adiletInPerson)} \"is\" an Employee");
    Employee explicitAdilet = (Employee)adiletInPerson;
}

// or

if (adiletInPerson is Employee explicitAdi)
{
    WriteLine($"{nameof(adiletInPerson)} \"is\" an Employee");
}
WriteLine();

// with AS

Employee? adiASEmployee = adiletInPerson as Employee;
if (adiASEmployee is not null)
{
    WriteLine($"{nameof(adiletInEmployee)} \"as\" an Employee");
}
WriteLine();

// Exception Inhereit

try
{
    kylie.TimeTravel(new(1996, 12, 23));
    kylie.TimeTravel(new(1994, 12, 23));
}
catch(PersonException ex)
{
    WriteLine(ex.Message);
}