string opakovani = "a";

while (opakovani == "a")
{
    Console.Clear(); // vymaže obrazovku
    Console.WriteLine("*********************************");
    Console.WriteLine("********* Generátor *********");
    Console.WriteLine("**********Tomáš Žižka ************");
    Console.WriteLine("*********************************");


    Console.Write("Zadejte počet generovaných čísel (n): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n))
        Console.Write("Nebylo zadáno celé  číslo. Zadejte znovu počet čísel: ");

    Console.Write("Zadejte dolní mez intervalu (dm): ");
    int dm;
    while (!int.TryParse(Console.ReadLine(), out dm))
        Console.Write("Nebylo zadáno celé  číslo. Zadejte znovu dolní mez: ");

    Console.Write("Zadejte horní mez intervalu (hm): ");
    int hm;
    while (!int.TryParse(Console.ReadLine(), out hm))
        Console.Write("Nebylo zadáno celé  číslo. Zadejte znovu horní mez: ");

    Console.WriteLine("\n\n============================================");
    Console.WriteLine("počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
    Console.WriteLine("=============================================");

    Random nahodne = new Random();
    int[] pole = new int[n];    //deklarace pole
    int max = 0;
    int min = 0;
    int pocetMax = 0;
    int pocetMin = 0;
    int[] poziceMax = new int[0];
    int[] poziceMin = new int[0];

    Console.WriteLine("\nNáhodná čísla: ");
    for (int i = 0; i < n; i++)
    {
        pole[i] = nahodne.Next(dm, hm + 1);
        Console.Write("{0}; ", pole[i]);

        if (i == 0)
        {
            max = pole[i];
            min = pole[i];
        }
        else if (max < pole[i])
        {
            max = pole[i];
        }
        else if (min > pole[i])
        {
            min = pole[i];
        }
    }

    for (int i = 0; i < pole.Length; i++)
    {
        if (pole[i] == max)
        {
            pocetMax++;
            poziceMax = poziceMax.Append(i).ToArray();
        }
        if (pole[i] == min)
        {
            pocetMin++;
            poziceMin = poziceMin.Append(i).ToArray();
        }
    }

    Console.WriteLine($"\n\nMaximum: {max}; počet výskytů: {pocetMax}; jeho výskyty jsou na pozicích: ");
    for (int i = 0; i < poziceMax.Length; i++)
    {
        Console.Write($"{poziceMax[i]}; ");
    }

    Console.WriteLine($"\n\nMinimum: {min}; počet výskytů: {pocetMin}; jeho výskyty jsou na pozicích: ");
    for (int i = 0; i < poziceMin.Length; i++)
    {
        Console.Write($"{poziceMin[i]}; ");
    }

    Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a.");
    Console.WriteLine("Stiskem jiné klávesy program ukončíte.");
    opakovani = Console.ReadLine();
}