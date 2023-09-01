using static System.Console;
using Class_Library_Shared;
using Class_Library_Shared_Enum;

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