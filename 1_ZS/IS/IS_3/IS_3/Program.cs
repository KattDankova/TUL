string opakovani = "a";

while (opakovani == "a")
{
    Console.Clear(); // vymaže obrazovku
    Console.WriteLine("*********************************");
    Console.WriteLine("********* Analýza textu *********");
    Console.WriteLine("**********Tomáš Žižka ************");
    Console.WriteLine("*********************************");

    /*string text = "Dnes je středa";
    Console.WriteLine(text);
    Console.WriteLine(text[0]);
    Console.WriteLine(text[1]);
    Console.WriteLine(text[2]);
    Console.WriteLine(text[4]);
    Console.WriteLine(text.Length);*/


    Console.Write("\nZadejte vstupní text: ");
    string text = Console.ReadLine();

    Console.WriteLine("\n==================");
    Console.WriteLine("Zadali jsme: {0}", text);
    Console.WriteLine("==================");

    text = text.ToLower();

    Console.WriteLine("\n==================");
    Console.WriteLine("Převedený text: {0}", text);
    Console.WriteLine("==================");

    string samohlasky = "aeiouyáéěíóúůý";
    string souhlasky = "bcčdďfghjklmnňpqrřsštťvwxzž";
    string cislice = "0123456789";
    int pocetSamohlasek = 0;
    int pocetSouhlasek = 0;
    int pocetCislic = 0;
    char predchoziZnak = '\0';
    int pocetCH = 0;

    foreach (char znak in text)
    {
        if (souhlasky.Contains(znak))
        {
            if (znak != 'h' && predchoziZnak != 'c')
                pocetSouhlasek++;
            else
                pocetCH++;
        }
        else if (samohlasky.Contains(znak))
            pocetSamohlasek++;
        else if (cislice.Contains(znak))
            pocetCislic++;
        predchoziZnak = znak;
    }

    Console.WriteLine("\nPočet samohlásek: {0}", pocetSamohlasek);
    Console.WriteLine("Počet souhlasek: {0}", pocetSouhlasek);
    Console.WriteLine("Počet číslic: {0}", pocetCislic);
    Console.WriteLine("Počet ostaních znaků: {0}", text.Length - pocetSamohlasek - pocetSouhlasek - pocetCH - pocetCislic);

    Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a.");
    Console.WriteLine("Stiskem jiné klávesy program ukončíte.");
    opakovani = Console.ReadLine();
}