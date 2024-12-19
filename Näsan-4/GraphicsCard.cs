public class GraphicsCard : Hardware
{
    private int _memory;
    // private int _resolution;

    public GraphicsCard (string name, int price, int memory) : base(name, price)
    {
        _memory = memory;
    }

    // public void GetMemory (int m)
    // {
    //     m = _memory;
    // }
    // public void GetResolution (int r)
    // {
    //     r = _resolution;
    // }
}
