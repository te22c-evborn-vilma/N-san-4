public class Processor : Hardware
{
    private int _cores;
    private int _clockSpeed;

    public Processor (string name, int price, int cores, int clockSpeed) : base(name, price)
    {
        _cores = cores;
        _clockSpeed = clockSpeed;
    }
}
