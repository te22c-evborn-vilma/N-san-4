// Punkt 1
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

// Punkt 7
Worker firstWorker = new();
BlueCollar firstBC = new();
WhiteCollar firstWC = new();

firstWorker.SetName("Me");
firstWorker.SetWage(12);
Console.WriteLine(firstWorker.GetName() + " | " + firstWorker.GetAge() + " | " + firstWorker.GetWage());

firstBC.SetName("You");
firstBC.SetWage(13);
Console.WriteLine(firstBC.GetName() + " | " + firstBC.GetAge() + " | " + firstBC.GetWage());

firstWC.SetName("They");
firstWC.SetWage(14);
Console.WriteLine(firstWC.GetName() + " | " + firstWC.GetAge() + " | " + firstWC.GetWage());

foreach (var rock in rocks)
{
    Console.WriteLine($"Rock: {rock.GetWeight()}");
}

// Punkt 8
List<Hardware> hardwares = new();

while (true)
{
    Console.WriteLine("Choose type of hardware to create");
    Console.WriteLine("1. Hard Drive | 2. Processor | 3. Graphics Card | 4. End");

    string choice = Console.ReadLine();
    bool successfull = false;

    if (choice == "1")
    {
        Console.WriteLine("Name the Hard Drive");
        string name = Console.ReadLine();

        while (successfull == false)
        {
            Console.WriteLine("Set the price of the Hard Drive");
            string priceAnswer = Console.ReadLine();
            int price;
            successfull = int.TryParse(priceAnswer, out price);
        }
        successfull = false;
        
        while (successfull == false)
        {
            Console.WriteLine("Decide the size of the Hard Drive (GB)");
            string sizeAnswer = Console.ReadLine();
            int size;
            successfull = int.TryParse(sizeAnswer, out size);
        }
        
        
        Console.WriteLine("Choose a type of Hard Drive (SSD/HDD)");
        string type = Console.ReadLine();


        Hardware hardDrive = new HardDrive();
        hardwares.Add(hardDrive);
    }
    else if (choice == "2")
    {
        Console.WriteLine("Name the Processor");
        string name = Console.ReadLine();

        while (successfull == false)
        {
            Console.WriteLine("Set the price of the Processor");
            string priceAnswer = Console.ReadLine();
            int price;
            successfull = int.TryParse(priceAnswer, out price);
        }
        successfull = false;
        
        while (successfull == false)
        {
            Console.WriteLine("Decide the number of Cores");
            string coresAnswer = Console.ReadLine();
            int cores;
            successfull = int.TryParse(coresAnswer, out cores);
        }
        successfull = false;
        
        while (successfull == false)
        {
            Console.WriteLine("Decide the Processors Clock Speed");
            string speedAnswer = Console.ReadLine();
            int speed;
            successfull = int.TryParse(speedAnswer, out speed);
        }

        Hardware processor = new Processor();
        hardwares.Add(processor);
    }
    else if (choice == "3")
    {
        Console.WriteLine("Name the Graphics Card");
        string name = Console.ReadLine();

        while (successfull == false)
        {
            Console.WriteLine("Set the price of the Graphics Card");
            string priceAnswer = Console.ReadLine();
            int price;
            successfull = int.TryParse(priceAnswer, out price);
        }
        successfull = false;
        
        while (successfull == false)
        {
            Console.WriteLine("Decide the memory size of the Graphics Card (GB)");
            string memoryAnswer = Console.ReadLine();
            int memory;
            successfull = int.TryParse(memoryAnswer, out memory);
        }
        successfull = false;
        
        while (successfull == false)
        {
            Console.WriteLine("Set the Graphics Card's resolution");
            string resolutionAnswer = Console.ReadLine();
            int resolution;
            successfull = int.TryParse(resolutionAnswer, out resolution);
        }

        Hardware graphicsCard = new GraphicsCard();
        hardwares.Add(graphicsCard);
    }
    else if (choice == "4")
    {
        break;
    }
    else 
    {
        Console.WriteLine("Try again");
    }
}


Console.ReadLine();