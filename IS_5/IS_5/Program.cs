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

    Console.WriteLine("\nSeřazené pole: ");
    for (int i = 0; i < n; i++)
    {
        pole[i] = nahodne.Next(dm, hm + 1);
        Console.Write("{0}; ", pole[i]);
    }

    int delka = pole.Length;
    int pocetPorovnani = 0;
    int pocetVymen = 0;

    for (int i = 0; i < delka - 1; i++)
    {
        int min = i;
        for (int j = i + 1; j < delka; j++)
        {
            pocetPorovnani++;
            if (pole[j] < pole[min])
                min = j;
        }

        int temp = pole[min];
        pole[min] = pole[i];
        pole[i] = temp;
        pocetVymen++;
    }

    Console.WriteLine("\n\nPočet porovnávání: {0}", pocetPorovnani);
    Console.WriteLine("Počet výměn: {0}", pocetVymen);

    Console.WriteLine("\nSeřazené pole: ");
    for (int i = 0; i < n; i++)
    {
        Console.Write("{0}; ", pole[i]);
    }


    Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a.");
    Console.WriteLine("Stiskem jiné klávesy program ukončíte.");
    opakovani = Console.ReadLine();
}