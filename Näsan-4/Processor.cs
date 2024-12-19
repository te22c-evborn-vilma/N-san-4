public class Processor : Hardware
{
    private int _cores;
    private int _clockSpeed;

    public void GetCores (int c)
    {
        c = _cores;
    }
    public void GetClockSpeed (int s)
    {
        s = _clockSpeed;
    }
}
