string[] planetCodes = { "ORION-4", "KAPPA-9", "LYRA-2", "NOVA-7", "VEGA-3" };
bool found = false;

// TODO: Skriv Length, første og siste element.
// TODO: Finn KAPPA-9 med en løkke.

Console.WriteLine($"Amount: {planetCodes.Length}");

Console.WriteLine($"First code: {planetCodes[0]}");

Console.WriteLine($"Last code: {planetCodes[planetCodes.Length - 1]}");

for (int i = 0; i < planetCodes.Length; i++)
{
    if (planetCodes[i] == "KAPPA-9")
    {
        found = true;
        break;
    }
}

Console.WriteLine($"Found KAPPA-9: {found}");
