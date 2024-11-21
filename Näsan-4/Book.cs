public class Book
{
    public string name;
    public int pages;
    private int currentPage = 0;

    public void TurnPage()
    {
        GetCurrentPage();
        currentPage++;
    }

    // steg 3
    public int GetCurrentPage()
    {
        return currentPage;
    }

}
