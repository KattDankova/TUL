// zadat číslo - velikost pole - do něj ukládat čísla a pro všechny prvky v poli společný dělitel, násobek
var key = ConsoleKey.Enter;
while (key == ConsoleKey.Enter)
{
    Console.Clear();

    int n = 0;
    while (n == 0)
    {
        Console.WriteLine("Zadejte počet čísel: ");
        int.TryParse(Console.ReadLine(), out n);
    }

    int[] pole = new int[n];
    int nejvyssi_cislo = 0;
    int nejnizsi_cislo = 0;
    int soucin = 1;

    for (int i = 0; i < pole.Length; i++)
    {
        while (pole[i] == 0)
        {
            Console.WriteLine($"Zadejte {i + 1}. číslo : ");
            int.TryParse(Console.ReadLine(), out pole[i]);
        }
        if (i == 0)
        {
            nejvyssi_cislo = pole[i];
            nejnizsi_cislo = pole[i];
        }
        else if (nejvyssi_cislo < pole[i])
        {
            nejvyssi_cislo = pole[i];
        }
        else if (nejnizsi_cislo > pole[i])
        {
            nejnizsi_cislo = pole[i];
        }

        soucin *= pole[i];
    }

    //Nejmenší společný násobek
    int nsn = 0;
    //Největší společný dělitel
    int nsd = 0;

    for (int i = 1; i < pole.Length; i++)
    {
        int temp = pole[0];
        temp = Delitel(pole[i], temp);
        nsd = temp;
    }

    nsn = soucin / nsd;

    Console.WriteLine($"Největší společný dělitel je {nsd}");

    Console.WriteLine($"Nejmenší společný násobek je {nsn}");


    Console.WriteLine("\nPro opakovani stisknete ENTER");
    key = Console.ReadKey().Key;
}

int Delitel(int a, int b)
{
    if (a == 0)
        return b;
    return Delitel(b % a, a);
}
