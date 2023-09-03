namespace Class_Library_Shared;

public class ImmutablePerson
{
    public string? FirstName { get; init; }
    public string? LastName { get; init; }

}

public record ImmutableVihicle
{
    public int Wheels { get; init; }
    public string? Color { get; init; }
    public string? Name { get; init; }
}

public record ImmutableAnimal
{
    public int Feet { get; init; }
    public string? Name { get; init; }

    public ImmutableAnimal(int feet, string? name)
    {
        Feet = feet;
        Name = name;
    }
}

public record ImmutableLife(string Name, int Age);
