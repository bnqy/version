using static System.Console;
using Class_Library_Shared;
using Class_Library_Shared_Enum;
using Class_Library_Bank_Acc;

// Person dua = new Person();
// var dua = new Person();

// Dua Instance
Person dua = new();
dua.Name = "Dua Lipa";
dua.DateOfBirth = new DateTime(1995, 08, 22);
dua.LivingRegion = SevenRegions.Naryn;
dua.Children.Add(new() {Name = "Rina", DateOfBirth = new(2009, 02, 05), LivingRegion = SevenRegions.Naryn});
dua.Children.Add(new Person() { Name = "Austin", DateOfBirth = new DateTime(2015, 09, 21), LivingRegion = SevenRegions.Naryn});
WriteLine(dua.ToString());
WriteLine(format: "{0} was born in {1:dddd, d MMMM yyyy} and she lives in {2}!", dua.Name, dua.DateOfBirth, dua.LivingRegion);


// Jaeden Instance
Person jaeden = new()
{
    Name = "Jaeden",
    DateOfBirth = new DateTime(2003, 01, 04),
    LivingRegion = SevenRegions.Chui,
    Areas = SevenRegions.Osh | SevenRegions.Talas
};
WriteLine(format: "{0} was born in {1:d MMM yy} and he lives in {2}!", jaeden.Name, jaeden.DateOfBirth, jaeden.LivingRegion);
WriteLine(jaeden.Areas);

WriteLine();


// Dua
WriteLine($"{dua.Name} has {dua.Children.Count} children:");
for (int i=0; i<dua.Children.Count;i++ )
{
    WriteLine($" {dua.Children[i].Name} --> {dua.Children[i].DateOfBirth:dd MMMM yy},{dua.Children[i].LivingRegion} ");
}



// Static member 
BankAccount.InterestRate = 0.012M;

// Jane
BankAccount jane = new()
{
    AccountName = "Ms. Jane",
    Balance = 2000M
};

WriteLine(
    $"{jane.AccountName} -> {jane.Balance * BankAccount.InterestRate}"
    );



// Itoko
BankAccount itoko = new BankAccount();
itoko.AccountName = "Ms. Itoko";
itoko.Balance = 1789M;

WriteLine(
    $"{itoko.AccountName} -> {itoko.Balance * BankAccount.InterestRate}"
    );

WriteLine();


// Dua
WriteLine($"{Person.Type} --> {dua.Country}");
//dua.Country = "j";


WriteLine();


// Unkown
Person unknown = new();

WriteLine("{0} was created in {1} at {2:hh:mm:ss}, {2:dddd}",
    unknown.Name,
    unknown.Country,
    unknown.RegistTime
    );

WriteLine(unknown.GetValues());
(string, int) values = unknown.GetValues();
WriteLine($"{values.Item1} {values.Item2}");

// deconst
(string name, int version) = unknown.GetValues();

var values2 = unknown.GetNamedValue();
WriteLine($"{values2.name} {values2.age}");


// Program class member
var thing = ("Kim", "Yoeng");
WriteLine(thing.Item1);

// dua init
(string name, int version) GetValuess = dua.GetValues();
WriteLine(GetValuess.name);
WriteLine($"Deconst {name} - {version}");


// Deconst

var(name1, dob1) = dua;
WriteLine($"Deconst: {name1} - {dob1}");

var (name2, dob2, la2) = dua;
WriteLine($"Deconst: {name2} - {dob2} + {la2}");

// parameters

int a = 5;
int b = 98;
int c = 0;

WriteLine($"Before: a = {a}; b = {b}; c = {c}");
dua.Paremeters(a, ref b , out c, out int alpha);
WriteLine($"After: a = {a}; b = {b}; c = {c}; alpha = {alpha}");


// partial class Person

WriteLine(dua.Greetings);
WriteLine($"Age - {dua.Age}");
WriteLine(dua.GetOrigin);