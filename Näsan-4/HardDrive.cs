public class HardDrive : Hardware
{
    private int _size;
    // private string _type;

    public HardDrive (string name, int price, int size) : base(name, price)
    {
        size = _size;
    }

    // public void GetSpace (int sp)
    // {
    //     sp = _space;
    // }
    // public void GetType (string t)
    // {
    //     t = _type;
    // }
}
