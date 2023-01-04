//Algoritmus pro řešení kvadratické rovnice
int a = 9;
int b = 12;
int c = 4;
//a != 0
int diskriminant = b * b - 4 * a * c;
//d < 0 => nemá řešení || d == 0 => jedno řešení
double x1 = (-b - Math.Sqrt(diskriminant)) / (2 * a); //Vypis
double x2 = (-b + Math.Sqrt(diskriminant)) / (2 * a); //Vypis

//Algoritmy pro vykreslení jednoduchých geometrických obrazců v textovém režimu
for (int i = 0; i < c; i++)
{
    for (int j = 0; j < c; j++)
    {
        Console.Write("*");
    }
    Console.Write("\n");
}

Console.Write("\n");
for (int i = 0; i < c; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.Write("\n");
}

Console.Write("\n");
int star = 1;
for (int i = 0; i < c; i++)
{
    for (int j = 1; j < c - i; j++)
    {
        Console.Write(" ");
    }

    for (int j = 0; j < star; j++)
    {
        Console.Write("*");
    }
    star += 2;
    Console.Write("\n");
}

Console.Write("\n");
for (int i = c; i >= 1; i--)
{
    for (int j = 0; j <= i - 1; j++)
    {
        Console.Write(" ");
    }
    for (int j = 0; j < c; j++)
    {
        Console.Write("*");
    }
    Console.Write("\n");
}

//Algortimus pro výpočet mocniny (bez funkce i pomocí uživatelem definované funkce)
int mocnina = 3;
int cislo = 4;
int vysledek = 1; //Vypis

for (int i = 0; i < mocnina; i++)
{
    vysledek *= cislo;
}

//Ciferný součet a součin
int dlouhecislo = 12345;
vysledek = 0; //Vypis
while (dlouhecislo != 0)
{
    vysledek += dlouhecislo % 10;
    //       *
    dlouhecislo /= 10;
}

//Dělení pomocí odečítání
int delenec = 13; //Vypis (zbytek)
int delitel = 3;
vysledek = 0; //Vypis
while (delenec > 3)
{
    vysledek++;
    Console.Write($"{delenec} - {delitel} = {delenec - delitel}\n");
    delenec -= delitel;
}

//Fibonacciho posloupnost
int soucet = 0;
cislo = 13;
for (int i = 1; i <= cislo; i++)
{
    int soucasna = fibonacci(i);
    soucet += soucasna;
    Console.Write(soucasna);
    Console.Write("\n");
}

int fibonacci(int x)
{
    if (x == 0)
        return 0;
    else if (x == 1)

        return 1;
    else
    {
        return fibonacci(x - 1) + fibonacci(x - 2);
    }
}

//Generování čísel a jejich uložení do pole
Random random = new Random();
int[] pole = new int[10];

int znamenko;
for (int i = 0; i < pole.Length; i++)
{
    pole[i] = random.Next(0, 20); // kladna
    pole[i] = -random.Next(0, 20); // zaporna

    znamenko = random.Next(0, 2);
    //oboje
    pole[i] = random.Next(0, 20);
    if (znamenko == 0)
    {
        pole[i] = -pole[i];
    }
}

//PI
double e = 0.0001;
double nvm = 1;
double piCtvrt = 1;
znamenko = 1;
while ((1 / nvm) >= e)
{
    nvm = nvm + 2;
    znamenko = -znamenko;
    piCtvrt = piCtvrt + znamenko * (1 / nvm);

    if (znamenko == 1)
        Console.WriteLine("Zlomek: +(1/{0}), aktuální hodnota PI: {1}", nvm, 4 * piCtvrt);
    else
        Console.WriteLine("Zlomek: -(1/{0}), aktuální hodnota PI: {1}", nvm, 4 * piCtvrt);

}

//Euklidův algoritmus
a = 133;
b = 15;

int zA = a;
int zB = b;
int nsd = 0;
int nsn = 0;
while (b != 0)
{
    int tmp = a;
    a = b;
    b = tmp % b;
}
nsd = a; //Vypis
nsn = (zA * zB) / a; //Vypis

//NSD
int[] arr = { 15, 20, 90 };
int result = arr[0]; //Vypis
for (int i = 1; i < arr.Length; i++)
{
    result = gcd(arr[i], result);
}

static int gcd(int a, int b)
{
    if (a == 0)
        return b;
    return gcd(b % a, a);
}

//NSN
static int LcmOfArray(int[] arr, int idx) //Vypis - užití metody v console writeline
{
    if (idx == arr.Length - 1)
    {
        return arr[idx];
    }
    int a = arr[idx];
    int b = LcmOfArray(arr, idx + 1);
    return (a * b / gcd(a, b));
}

//Počet čísel v poli, která jsou beze zbytku dělitelná určitým přirozeným číslem
int pocet = 0; // Vypis
delitel = 20;
for (int i = 0; i < pole.Length; i++)
{
    if (pole[i] % delitel == 0)
    {
        pocet++;
    }
}

//Počet kladných, záporných čísel, která jsou uložena v poli
int kladna = 0;
int zaporna = 0;
int pocetNul = 0;
for (int i = 0; i < pole.Length; i++)
{
    if (pole[i] > 0) // kladná
    {
        kladna++;
    }
    else if (pole[i] < 0) // záporná
    {
        zaporna++;
    }
    else
    {
        pocetNul++;
    }
}

//Počet sudých a lichých čísel, která jsou uložena v poli
int sudy = 0;
int lichy = 0;
for (int i = 0; i < pole.Length; i++)
{
    if (pole[i] % 2 == 0)
    {
        sudy++;
    }
    else
    {
        lichy++;
    }
}

//Převod čísel z 10 soustavy do 2 soustavy
cislo = 70;
int soustava = 2;
int[] DvojPole = new int[20];
int konec = 0;
for (int i = 0; cislo > 0; i++)
{
    DvojPole[i] = cislo % 2;
    cislo = cislo / 2;
    konec = i;
}
//aby se vypsalo jen potřebné číslo
for (int i = konec - 1; i >= 0; i--)
{
    Console.Write(DvojPole[i]);
}

//Převod čísla z 10 do libovolné číselné soustavy a obráceně
int omg;
int zbytek;
for (omg = 0; cislo > 0; omg++)
{
    zbytek = cislo % soustava;
    cislo = (cislo - zbytek) / soustava;
    pole[omg] = zbytek;
}

//Převod čísel z 2 soustavy do 10 soustavy
cislo = 0; //Vypis
for (int i = 0; i <= konec; i++)
{
    if (DvojPole[i] == 1)
    {
        int temp = 1;
        for (int j = 0; j < i; j++)
        {
            temp *= 2;
        }
        cislo += temp;
    }
}

//"Reverze" pole (nejedná se pouze o obrácený výpis pole)
for (int i = 0; i < pole.Length / 2; i++)
{
    int temp = pole[i];
    pole[i] = pole[pole.Length - 1 - i];
    pole[pole.Length - 1 - i] = temp;
}

//Součin pomocí součtu a podobné algoritmy
a = 15;
b = 7;
int soucin = 0; //Vypis
for (int i = 0; i < b; i++)
{
    soucin += a;
}

//Test, kolikrát se vyskytuje určitá číslice v daném čísle
int LongCislo = 1356412;
pocet = 0; //Vypis
cislo = 0; // číslo které hledáme
while (LongCislo > 0)
{
    if (LongCislo % 10 == cislo)
    {
        pocet++;
    }
    LongCislo /= 10;
}

//Vyhledání extrémů v poli - tzn. vyhledání maximální a minimální hodnoty (včetně určení údaje kolikrát byl v poli konkrétní extrém nalezen nebo informace o tom na jaké pozici byl extrém nalezen)
int min = 0;
int max = 0;
min = max = pole[0];
int pocetMax = 1;
int pocetMin = 1;
int indexMax = 0;
int indexMin = 0; 
for (int i = 1; i < pole.Length; i++)
{
    if (pole[i] > max)
    {
        max = pole[i];
        pocetMax = 0;
        indexMax = i;
    }
    if (pole[i] == max)
    {
        pocetMax++;
    }
    if (pole[i] < min)
    {
        min = pole[i];
        pocetMin = 0;
        indexMin = i;
    }
    if (pole[i] == min)
    {
        pocetMin++;
    }
}

//Výpis pozic maxima / minima
for (int i = 0; i < pole.Length; i++)
{
    if (pole[i] == max /*min*/)
    {
        Console.WriteLine("{0}, ", max /*min*/);
    }
}

//Vyhledávání v poli (vstup: hledané číslo, výstup: informace o tom zda hledané číslo bylo nalezeno + kolikrát bylo v poli nalezeno + na jakých pozicích bylo nalezeno)
cislo = 20; // Číslo, které hledáme
pocet = 0; // Vypis
for (int i = 0; i < pole.Length; i++)
{
    if (pole[i] == cislo)
    {
        pocet++;
        Console.Write("\n Pozice: {0}", i);
    }
}

//Výpočet faktoriálu(bez funkce i pomocí uživatelem definované funkce/metody)
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

//Zařazení čísel v poli do intervalů
if (cislo < 0)
{
    Console.WriteLine("\nzáporné");
}
else if (cislo == 0)
{
    Console.WriteLine("\nNula");
}
else
{
    Console.WriteLine("\nKladné");
}

//Pascalův trojúhelník
int n = 0;
star = 1;

for (int i = 0; i < c; i++)
{
    int k = 0;
    for (int j = 1; j < c - i; j++)
    {
        Console.Write(" ");
    }
    for (int j = 0; j < star; j++)
    {
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
    star += 1;
    Console.Write("\n");
    n++;
}

//Analýza textu
string samohlasky = "aeiouyáéěíóúůý";
string souhlasky = "bcčdďfghjklmnňpqrřsštťvwxzž";
string cislice = "0123456789";
int pocetSamohlasek = 0;
int pocetSouhlasek = 0;
int pocetCislic = 0;
string text = "V3lm1 rand0m věta, pr0t0ž3 pr0č n3";
foreach (char znak in text)
{
    if (souhlasky.Contains(znak))
        pocetSouhlasek++;
    else if (samohlasky.Contains(znak))
        pocetSamohlasek++;
    else if (cislice.Contains(znak))
        pocetCislic++;
}

//zobrazení prvku aritmetické a geometrické řady / součet aritmetické nebo geometrické řady
soucet = 0;
for (int i = 1; i < n; i++)
{
    pole[i] = pole[i - 1] + c;
    soucet += pole[i];
    Console.Write("{0}; ", pole[i]);
}

soucet = 0;
for (int i = 1; i < n; i++)
{
    pole[i] = pole[i - 1] * c;
    soucet += pole[i];
    Console.WriteLine("{0}; ", pole[i]);
}

//Práce s 2D polem
int[,] pole2d = new int[10, 10];
for (int i = 0; i < pole2d.GetLength(0); i++)
{
    for (int j = 0; j < pole2d.GetLength(1); j++)
    {
        Console.Write(pole2d[i, j] + " ");
    }
    Console.Write("\n");
}

//základní statistické velličiny: průměr, vážený průměr, medián, apod.
double[] statPole = new double[] { 58, 61, 61, 61, 63, 65, 72, 73, 75 };
//Průměr
double prumer = 0;
for (int i = 0; i < statPole.Length; i++)
{
    prumer += statPole[i];
}
prumer /= statPole.Length;

//Medián
double median = 0;
if (statPole.Length % 2 == 0)
{
    median = (statPole[statPole.Length / 2 - 1] + statPole[statPole.Length / 2]) / 2;
}
else
{
    median = statPole[statPole.Length / 2];
}

//Modus (nejčastější hodnota)
pocet = 0;
double modus = 0;
for (int i = 0; i < statPole.Length; i++)
{
    int count = 0;
    for (int j = 0; j < statPole.Length; j++)
    {
        if (statPole[i] == statPole[j])
        {
            count++;
        }
    }

    if (count > pocet)
    {
        pocet = count;
        modus = statPole[i];
    }
}

//Bubble sort
for (int i = 0; i < pole.Length - 1; i++)
{
    for (int j = 0; j < pole.Length - i - 1; j++)
    {
        if (pole[j + 1] < pole[j])
        {
            int tmp = pole[j + 1];
            pole[j + 1] = pole[j];
            pole[j] = tmp;
        }
    }
}

//Selection sort
for (int i = 0; i < pole.Length - 1; i++)
{
    int maxIndex = i;
    for (int j = i + 1; j < pole.Length; j++)
    {
        if (pole[j] > pole[maxIndex]) maxIndex = j;
    }
    int tmp = pole[i];
    pole[i] = pole[maxIndex];
    pole[maxIndex] = tmp;
}

//Instertion sort
for (int i = 0; i < pole.Length - 1; i++)
{
    int j = i + 1;
    int tmp = pole[j];
    while (j > 0 && tmp > pole[j - 1])
    {
        pole[j] = pole[j - 1];
        j--;
    }
    pole[j] = tmp;
}

//Shaker sort
bool swapped = false;

for (int i = 0; i < pole.Length / 2; i++)
{
    swapped = false;

    for (int j = i; j < pole.Length - i - 1; j++)
    {
        if (pole[j] < pole[j + 1])
        {
            int tmp = pole[j];
            pole[j] = pole[j + 1];
            pole[j + 1] = tmp;
            swapped = true;
        }
    }
    for (int j = pole.Length - 2 - i; j > i; j--)
    {
        if (pole[j] > pole[j - 1])
        {
            int tmp = pole[j];
            pole[j] = pole[j - 1];
            pole[j - 1] = tmp;
            swapped = true;
        }
    }
    if (!swapped) break;
}

//Comb sort
swapped = false;
double gap = pole.Length;
while (gap != 1 || swapped)
{
    gap /= 1.33;
    swapped = false;
    if (gap < 1)
    {
        gap = 1;
    }
    for (int i = 0; i + gap < pole.Length; i++)
    {
        if (pole[i] < pole[i + (int)gap])
        {
            int tmp = pole[i];
            pole[i] = pole[i + (int)gap];
            pole[i + (int)gap] = tmp;
            swapped = true;
        }
    }
}

//Shell sort
int gap2 = pole.Length / 2;
while (gap > 0)
{
    for (int i = 0; i < pole.Length - gap2; i++)
    {
        int j = i + gap2;
        int tmp = pole[j];
        while (j >= gap && tmp > pole[j - gap2])
        {
            pole[j] = pole[j - gap2];
            j -= gap2;
        }
        pole[j] = tmp;
    }
    if (gap == 2)
    {
        gap = 1;
    }
    else
    {
        gap = (int)(gap / 2.2);
    }
}