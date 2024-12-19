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

    if (choice == "1")
    {
        Console.WriteLine("Name the Hard Drive");
        string name = Console.ReadLine();

        Console.WriteLine("Set the price of the Hard Drive");
        int price;
        while (!int.TryParse(Console.ReadLine(),out price))
        {
            Console.WriteLine("Try again");
            Console.WriteLine("Set the price: ");
        }
        
        Console.WriteLine("Decide the size of the Hard Drive (GB)");
        int size;
        while (!int.TryParse(Console.ReadLine(), out size))
        {
            Console.WriteLine("Try again");
            Console.WriteLine("Decide the size: ");
        }

        Hardware hardDrive = new HardDrive(name, price, size);
        hardwares.Add(hardDrive);
    }
    else if (choice == "2")
    {
        Console.WriteLine("Name the Processor");
        string name = Console.ReadLine();
            
        Console.WriteLine("Set the price of the Processor");
        int price;
        while (!int.TryParse(Console.ReadLine(),out price))
        {
            Console.WriteLine("Try again");
            Console.WriteLine("Set the price: ");
        }

        Console.WriteLine("Decide the number of Cores");
        int cores;
        while (!int.TryParse(Console.ReadLine(), out cores))
        {
            Console.WriteLine("Try again");
            Console.WriteLine("Decide the number of cores: ");
        }

        Console.WriteLine("Decide the Processor's clock speed");
        int clockSpeed;
        while (!int.TryParse(Console.ReadLine(), out clockSpeed))
        {
            Console.WriteLine("Try again");
            Console.WriteLine("Decide the clock speed: ");
        }
        
        Hardware processor = new Processor(name, price, cores, clockSpeed);
        hardwares.Add(processor);
    }
    else if (choice == "3")
    {
        Console.WriteLine("Name the Graphics Card");
        string name = Console.ReadLine();

        Console.WriteLine("Set the price of the Graphics Card");
        int price;
        while (!int.TryParse(Console.ReadLine(),out price))
        {
            Console.WriteLine("Try again");
            Console.WriteLine("Set the price: ");
        }
        
        Console.WriteLine("Decide the memory size of the Graphics Card (GB)");
        int memory;
        while (!int.TryParse(Console.ReadLine(),out memory))
        {
            Console.WriteLine("Try again");
            Console.WriteLine("Decide the memory size: ");
        }

        Hardware graphicsCard = new GraphicsCard(name, price, memory);
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