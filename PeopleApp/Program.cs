using static System.Console;
using Class_Library_Shared;
using Class_Library_Shared_Enum;
using Class_Library_Bank_Acc;

// Person dua = new Person();
// var dua = new Person();
Person dua = new();
dua.Name = "Dua Lipa";
dua.DateOfBirth = new DateTime(1995, 08, 22);
dua.LivingRegion = SevenRegions.Naryn;
dua.Children.Add(new() {Name = "Rina", DateOfBirth = new(2009, 02, 05), LivingRegion = SevenRegions.Naryn});
dua.Children.Add(new Person() { Name = "Austin", DateOfBirth = new DateTime(2015, 09, 21), LivingRegion = SevenRegions.Naryn});
WriteLine(dua.ToString());
WriteLine(format: "{0} was born in {1:dddd, d MMMM yyyy} and she lives in {2}!", dua.Name, dua.DateOfBirth, dua.LivingRegion);

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

WriteLine($"{dua.Name} has {dua.Children.Count} children:");
for (int i=0; i<dua.Children.Count;i++ )
{
    WriteLine($" {dua.Children[i].Name} --> {dua.Children[i].DateOfBirth:dd MMMM yy},{dua.Children[i].LivingRegion} ");
}


BankAccount.InterestRate = 0.012M;

BankAccount jane = new()
{
    AccountName = "Ms. Jane",
    Balance = 2000M
};

BankAccount itoko = new BankAccount();
itoko.AccountName = "Ms. Itoko";
itoko.Balance = 1789M;

WriteLine(
    $"{jane.AccountName} -> {jane.Balance * BankAccount.InterestRate}"
    );

WriteLine(
    $"{itoko.AccountName} -> {itoko.Balance * BankAccount.InterestRate}"
    );

WriteLine();

WriteLine($"{Person.Type} --> {dua.Country}");
//dua.Country = "j";


WriteLine();

Person unknown = new();

WriteLine("{0} was created in {1} at {2:hh:mm:ss}, {2:dddd}",
    unknown.Name,
    unknown.Country,
    unknown.RegistTime
    );

WriteLine(unknown.GetValues());
(string, int) values = unknown.GetValues();
(string name, int version) = unknown.GetValues();

WriteLine($"{values.Item1} {values.Item2}");

var values2 = unknown.GetNamedValue();
WriteLine($"{values2.name} {values2.age}");

var thing = ("Kim", "Yoeng");
WriteLine(thing.Item1);

(string name, int version) GetValuess = dua.GetValues();
WriteLine(GetValuess.name);
WriteLine($"Deconst {name} - {version}");