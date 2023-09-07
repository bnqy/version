namespace BnqLib;

public interface IPlayable
{
    void Play();
    void Pause();

    void Stop()
    {
        Console.WriteLine("Default impl of method");
    }
}
