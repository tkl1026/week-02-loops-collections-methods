List<string> specimens = new List<string>();

while (true)
{
    Console.Write("Command (ADD/REMOVE/LIST/COUNT/QUIT): ");
    string? command = Console.ReadLine();

    // TODO: Implementer kommandoene.
    // Tips: specimens må IKKE opprettes på nytt inne i løkken.


    if (command == "QUIT")
    {
        break;
    }

    else if (command == "ADD")
    {
        Console.WriteLine("Enter specimen name: ");
        string name = Console.ReadLine();
        specimens.Add(name);
    }

    else if (command == "REMOVE")
    {
        Console.WriteLine("Enter specimen name: ");
        string name = Console.ReadLine();

        foreach (string specimen in specimens)
        {
            if (name == specimen)
            {
                specimens.Remove(specimen);
            }
            else
            {
                Console.WriteLine("Specimen not found");
            }
        }
    }

    else if (command == "LIST")
    {
        foreach (string specimen in specimens)
        {
            Console.WriteLine(specimen);
        }
    }

    else if (command == "COUNT")
    {
        Console.WriteLine($"Number of specimens {specimens.Count()}");
    }

    else
    {
        Console.WriteLine("Command not valid");
    }
}
