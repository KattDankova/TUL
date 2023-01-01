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

    for (int i = 0; i < pole.Length; i++)
    {
        while (pole[i] == 0)
        {
            Console.WriteLine($"Zadejte {i + 1}. číslo : ");
            int.TryParse(Console.ReadLine(), out pole[i]);
        }
    }

    int nsd = pole[0];
    for (int i = 1; i < pole.Length; i++)
    {
        nsd = Delitel(pole[i], nsd);
    }

    int nsn = Nasobek(pole, 0);

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

int Nasobek(int[] arr, int idx)
{
    if (idx == arr.Length - 1)
    {
        return arr[idx];
    }
    int a = arr[idx];
    int b = Nasobek(arr, idx + 1);
    return (a * b / Delitel(a, b));
}