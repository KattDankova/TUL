var key = ConsoleKey.Enter;
while (key == ConsoleKey.Enter)
{
    Console.Clear();
    int vyska = 0;
    while (vyska == 0)
    {
        Console.WriteLine("Zadejte vysku trojuhelniku: ");
        int.TryParse(Console.ReadLine(), out vyska);
    }

    int starCounter = 1;
    for (int i = 0; i < vyska; i++)
    {
        int counter = vyska - i;
        while (counter > 1)
        {
            Console.Write(" ");
            counter--;
        }
        for (int j = 0; j < starCounter; j++)
        {
            Console.Write("*");
        }
        starCounter += 2;
        Console.Write("\n");
    }

    Console.WriteLine("\nPro opakovani stisknete ENTER");
    key = Console.ReadKey().Key;
}

