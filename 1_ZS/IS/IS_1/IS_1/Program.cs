var key = ConsoleKey.Enter;
while (key == ConsoleKey.Enter)
{
    Console.Clear();
    int a = 0;
    int b = 0;
    while (a == 0)
    {
        Console.WriteLine("Zadejte pozadovany pocet radku: ");
        int.TryParse(Console.ReadLine(), out a);
    }
    while (b == 0)
    {
        Console.WriteLine("Zadejte pozadovany pocet sloupcu: ");
        int.TryParse(Console.ReadLine(), out b);
    }

    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            Console.Write("*");
        }
        Console.Write("\n");
    }

    Console.WriteLine("\nPro opakovani stisknete ENTER");
    key = Console.ReadKey().Key;
}