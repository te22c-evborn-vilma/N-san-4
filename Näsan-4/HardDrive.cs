public class HardDrive : Hardware
{
    private int _size;

    public HardDrive (string name, int price, int size) : base(name, price)
    {
        _size = size;
    }
}
