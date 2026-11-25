/*List<string> beacons = new List<string>();

bool running = true;

while (running)
{
    Console.WriteLine();
    Console.WriteLine("1 - Add beacon");
    Console.WriteLine("2 - Remove beacon");
    Console.WriteLine("3 - List beacons");
    Console.WriteLine("4 - Quit");
    Console.Write("Choice: ");

    string? choice = Console.ReadLine();

    if (choice == "1")
    {
        Console.Write("Beacon name: ");
        string? name = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(name))
        {
            beacons.Add(name);
            Console.WriteLine("Beacon added.");
        }
    }
    else if (choice == "2")
    {
        Console.Write("Beacon name: ");
        string? name = Console.ReadLine();
        if (name is not null && beacons.Remove(name))
        {
            Console.WriteLine("Beacon removed.");
        }
        else
        {
            Console.WriteLine("Beacon not found.");
        }
    }
    else if (choice == "3")
    {
        if (beacons.Count == 0)
        {
            Console.WriteLine("No beacons registered.");
        }
        else
        {
            foreach (string beacon in beacons)
            {
                Console.WriteLine($"- {beacon}");
            }
        }
    }
    else if (choice == "4")
    {
        break;
    }
    else
    {
        Console.WriteLine("Unknown choice.");
    }
}*/

// TODO: Refaktorer den fungerende koden over til flere metoder.
List<string> beacons = new List<string>();

bool running = true;

while (running)
{
    PrintMenu();

    string choice = Console.ReadLine();

    if (choice == "1")
    {
        AddBeacon(beacons);
    }

    else if (choice == "2")
    {
        RemoveBeacon(beacons);
    }

    else if (choice == "3")
    {
        PrintBeacons(beacons);
    }

    else if (choice == "4")
    {
        Console.WriteLine($"Number of beacons: {beacons.Count()}");
    }

    else if (choice == "5")
    {
        running = false;
        Console.WriteLine("Quiting program");
    }

    else
    {
        Console.WriteLine("Choice is not valid");
    }
}

static void PrintMenu()
{
    Console.WriteLine();
    Console.WriteLine("1 - Add beacon");
    Console.WriteLine("2 - Remove beacon");
    Console.WriteLine("3 - List beacons");
    Console.WriteLine("4 - Quit");
    Console.Write("Choice: ");
}

static void AddBeacon(List<string> beacons)
{
    Console.Write("Beacon name: ");
    string? name = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(name))
    {
        beacons.Add(name);
        Console.WriteLine("Beacon added.");
    }
}

static void RemoveBeacon(List<string> beacons)
{
    Console.Write("Beacon name: ");
    string? name = Console.ReadLine();
    if (name is not null && beacons.Remove(name))
    {
        Console.WriteLine("Beacon removed.");
    }
    else
    {
        Console.WriteLine("Beacon not found.");
    }
}

static void PrintBeacons(List<string> beacons)
{
    if (beacons.Count == 0)
    {
        Console.WriteLine("No beacons registered.");
    }
    else
    {
        foreach (string beacon in beacons)
        {
            Console.WriteLine($"- {beacon}");
        }
    }
}