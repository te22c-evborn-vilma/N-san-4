public class BlueCollar : Worker
{
    public void Build()
    {
        Console.WriteLine($"{Name} is building something.");
    }
    public void Repair()
    {
        Console.WriteLine($"{Name} is fixing something.");
    }
    public void Destroy()
    {
        Console.WriteLine($"{Name} is destroying something.");
    }
}
