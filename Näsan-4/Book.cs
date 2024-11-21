public class Book
{
    public string name;
    public int pages;
    public int currentPage = 0;

    public void TurnPage()
    {
        currentPage++;
    }

}
