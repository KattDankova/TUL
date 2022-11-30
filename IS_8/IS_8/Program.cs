var key = ConsoleKey.Enter;
while (key == ConsoleKey.Enter)
{
    Console.Clear();
    int pocetCisel = 0;
    while (pocetCisel == 0)
    {
        Console.Write("Zadejte pozadovany pocet cisel: ");
        int.TryParse(Console.ReadLine(), out pocetCisel);
    }

    int[] pole = new int[pocetCisel];
    int soucet = 0;
    int max = 0;
    int prumer = 0;
    Random random = new Random();

    Console.WriteLine("\nNáhodná čísla:");

    for (int i = 0; i < pocetCisel; i++)
    {
        pole[i] = random.Next(0, 10);
        soucet += pole[i];
        if (max < pole[i])
        {
            max = pole[i];
        }
        Console.Write($"{pole[i]} ");
    }

    prumer = soucet / pocetCisel;
    Console.WriteLine($"\n\nMaximum: {max}");
    Console.WriteLine($"Průměr: {prumer}\n");

    for (int i = 0; i < max; i++)
    {
        for (int j = 0; j < prumer; j++)
        {
            Console.Write("*");
        }
        Console.Write("\n");
    }

    Console.WriteLine("\nPro opakovani stisknete ENTER");
    key = Console.ReadKey().Key;
}