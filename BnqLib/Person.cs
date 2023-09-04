namespace BnqLib;

public class Person
{
    public string? Name;
    public DateTime DateOfBirth;
    public List<Person> Children = new();

    public static Person BabyCreate(Person p1, Person p2)
    {
        Person baby = new()
        {
            Name = $"The baby of {p1.Name} and {p2.Name}"
        };

        p1.Children.Add(baby);
        p2.Children.Add(baby);

        return baby;
    }

    public Person BabyCreateWith(Person partner)
    {
        return BabyCreate(this, partner);
    }

    public static Person operator * (Person p1, Person p2)
    {
        return Person.BabyCreate(p1, p2);
    }
}