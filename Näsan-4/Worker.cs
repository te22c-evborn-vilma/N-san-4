public class Worker
{
    public string Name;
    public int Age;
    public int Wage = 0;

    public Worker()
    {
        Name = "";
        Age = 0;
    }

    public void SetWage(int wage)
    {
        Wage = wage;
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
