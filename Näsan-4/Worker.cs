public class Worker
{
    private string Name = "";
    private int Age = 30;
    private int Wage = 0;

    public void SetWage(int w)
    {
        w = Wage;
    }
    public void SetName(string x)
    {
        x = Name;
    }

    public string GetName()
    {
        return Name;
    }
    public int GetAge()
    {
        return Age;
    }
    public int GetWage()
    {
        return Wage;
    }
}
