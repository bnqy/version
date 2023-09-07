using static System.Console;
//#nullable disable

Address address = new Address();
address.Region = "Zhal";
address.City = "Bishkek";
address.Building = null;
address.Street = "Manas";

string s = null;
int? y = s?.Length;

int thisCanNotBeNull = 9;
//thisCanNotBeNull = null;
WriteLine(thisCanNotBeNull);

int? thisCanBeNull = null;
WriteLine(thisCanBeNull);
WriteLine(thisCanBeNull.GetValueOrDefault());
thisCanBeNull = 7;
WriteLine(thisCanBeNull);
WriteLine(thisCanBeNull.GetValueOrDefault());

// Ref Types nullable

class Address
{
    public string? Building;
    public string Street = string.Empty;
    public string City = string.Empty;
    public string Region = string.Empty;
}
