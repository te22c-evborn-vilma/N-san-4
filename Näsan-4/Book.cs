public class Book
{
    private string Name;
    private int Pages;
    private int CurrentPage = 0;

    public void TurnPage()
    {
        GetCurrentPage();
        CurrentPage++;
    }

    // steg 3
    public int GetCurrentPage()
    {
        return CurrentPage;
    }

    // Steg 4
    public Book(string n, int p)
    {
        n = Name;
        p = Pages;
    }

    // Steg 5
    public string GetName()
    {
        return Name;
    }
    public int GetPages()
    {
        return Pages;
    }
}
