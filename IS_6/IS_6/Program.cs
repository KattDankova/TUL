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
    int n = 0;
    int starCounter = 1;
    for (int i = 0; i < vyska; i++)
    {
        int k = 0;
        int counter = vyska - i;
        while (counter > 1)
        {
            Console.Write(" ");
            counter--;
        }
        for (int j = 0; j < starCounter; j++)
        {
            //     n!
            // ----------
            //  k!(n-k)!
            int citatel = Factorial(n);
            int jmenovatel = Factorial(k) * Factorial(n - k);
            if (jmenovatel == 0)
            {
                Console.Write("1");
            }
            else
            {
                Console.Write($"{(citatel / jmenovatel)}");
            }
            k++;
            Console.Write(" ");
        }
        starCounter += 1;
        Console.Write("\n");
        n++;
    }

    Console.WriteLine("\nPro opakovani stisknete ENTER");
    key = Console.ReadKey().Key;
}

int Factorial(int n)
{
    int fact = 1;
    if (n != 0)
    {
        for (int i = 1; i <= n; i++)
        {
            fact *= i;
        }
    }

    return fact;
}