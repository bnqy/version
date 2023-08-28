int max = 500;
try
{
    checked
    {
        for (byte i = 0; i < max; i++)
        {
            Console.WriteLine(i);
        }
    }
}
catch (Exception ex)
{
    Console.Write($"Type: {ex.GetType()} - {ex.Message}");
}