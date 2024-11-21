// Punkt 1
Book firstBook = new()
{
    name = "Harry Potter",
    pages = 360
};
Book secondBook = new()
{
    name = "The Death Marks",
    pages = 500
};
Book thirdBook = new()
{
    name = "Animal Farm",
    pages = 440
};

// Punkt 2
Console.WriteLine(firstBook.currentPage);
firstBook.TurnPage();
Console.WriteLine(firstBook.currentPage);



Console.ReadLine();