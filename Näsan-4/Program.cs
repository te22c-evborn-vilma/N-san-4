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

// Punkt 6
List<Rock> rockList = new();
Console.WriteLine("How many rocks do you want to create?");
int number;

while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
{
    Console.WriteLine("Please write a possible number of stones.");
}

for (int i = 0; i < number; i++)
{
    int Weight;
    Console.WriteLine($"How much weight do you want rock {i + 1}) to have?"); 

    while (!int.TryParse(Console.ReadLine(), out Weight) || Weight <= 0)
    {
        Console.WriteLine("Please write a positive number for the rock's weight.");
    }

    Rock rock = new Rock(Weight);
    rockList.Add(rock);
}

foreach (Rock rock in rockList)
{
    Console.WriteLine($"Rock: {rock.GetWeight()}");
}

// Punkt 7
Worker worker = new Worker();
BlueCollar blueCollar = new BlueCollar();
WhiteCollar whiteCollar = new WhiteCollar();

Console.WriteLine("Pick a name for Worker.");
worker.Name = Console.ReadLine();

Console.WriteLine("Write Worker's age.");
while (!int.TryParse(Console.ReadLine(), out worker.Age) || worker.Age <= 0)
{
    Console.WriteLine("Please write a possible age.");
}

Console.WriteLine("Write Worker's wage.");
while (!int.TryParse(Console.ReadLine(), out int wage) || wage <= 0)
{
    Console.WriteLine("Please write a possible wage.");
}
// worker.SetWage(wage);
Console.WriteLine($"\nWorker - {worker.GetName()} | Age: {worker.GetAge()} | Wage: {worker.GetWage()}");


// Blue Collar Worker
Console.WriteLine("Pick a name for Blue Collar Worker.");
blueCollar.Name = Console.ReadLine();

Console.WriteLine("Write Blue Collar Worker's age.");
while (!int.TryParse(Console.ReadLine(), out blueCollar.Age) || blueCollar.Age <= 0)
{
    Console.WriteLine("Please write a possible age.");
}

Console.WriteLine("Write Blue Collar Worker's wage.");
while (!int.TryParse(Console.ReadLine(), out int wage) || wage <= 0)
{
    Console.WriteLine("Please write a possible wage.");
}
// blueCollar.SetWage(wage);
Console.WriteLine($"\nWorker - {blueCollar.GetName()} | Age: {blueCollar.GetAge()} | Wage: {blueCollar.GetWage()}");

// White Collar Worker
Console.WriteLine("Pick a name for White Collar Worker.");
whiteCollar.Name = Console.ReadLine();

Console.WriteLine("Write White Collar Worker's age.");
while (!int.TryParse(Console.ReadLine(), out whiteCollar.Age) || whiteCollar.Age <= 0)
{
    Console.WriteLine("Please write a possible age.");
}

Console.WriteLine("Write White Collar Worker's wage.");
while (!int.TryParse(Console.ReadLine(), out int wage) || wage <= 0)
{
    Console.WriteLine("Please write a possible wage.");
}
// whiteCollar.SetWage(wage);
Console.WriteLine($"\nWorker - {whiteCollar.GetName()} | Age: {whiteCollar.GetAge()} | Wage: {whiteCollar.GetWage()}");

whiteCollar.DrinkCoffee();



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