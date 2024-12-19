public class GraphicsCard : Hardware
{
    private int _memory;

    public GraphicsCard (string name, int price, int memory) : base(name, price)
    {
        _memory = memory;
    }
}
