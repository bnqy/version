namespace BnqLib;

public class Person : IComparable<Person>
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

    // delegate n event handling

    /*
     * delegate int DelegateWithMatchingSignature(string s);
     * DelegateWithMatchingSignature d = new(p1.MethodIWantToCall);
     * 
     * public delegate void EventHandler(object? sender, EventArgs e);
     * public delegate void EventHandler<TEventArgs>(object? sender, TEventArgs e);
     * 
     */
    public event EventHandler? Shout;

    public int AngerLevel;

    public void Poke()
    {
        AngerLevel++;

        if (AngerLevel >= 3)
        {
            if (Shout != null)
            {
                Shout(this, EventArgs.Empty);
            }
        }
    }

    // IComparable method
    public int CompareTo(Person? other)
    {
        if (Name is null)
        {
            return 0;
        }

        return Name.CompareTo(other?.Name);
    }
}