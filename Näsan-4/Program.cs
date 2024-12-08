﻿// Punkt 1
using System.Reflection.Metadata.Ecma335;

Book firstBook = new("Harry Potter", 360);
// {
//     name = "Harry Potter",
//     pages = 360
// };
Book secondBook = new("The Death Marks", 500);
// {
//     name = "The Death Marks",
//     pages = 500
// };
Book thirdBook = new("Animal Farm", 440);
// {
//     name = "Animal Farm",
//     pages = 440
// };

// Punkt 2
Console.WriteLine(firstBook.GetCurrentPage());
for (int k = 0; k < 42; k++)
{
    firstBook.TurnPage();
}
Console.WriteLine(firstBook.GetCurrentPage());

string answer = "";

bool success = false;
List<Rock> rocks = new();
while (success != true)
{
    Console.WriteLine("How many rocks do you want to create?");
    answer = Console.ReadLine();
    int number;
    success = int.TryParse(answer, out number);
    for (int i = 0; i < number; i++)
    {
        bool great = false;
        while (great != true)
        {
            Console.WriteLine(i + 1 + ") How much weight do you want the rock to have?");
            string choice = Console.ReadLine();
            int heaviness;
            great = int.TryParse(choice, out heaviness);
            Rock myRock = new(heaviness);
            rocks.Add(myRock);
        }
    }
}

// foreach (var rock in rocks)
// {
//     Console.WriteLine(rock.GetWeight);
// }

Console.ReadLine();