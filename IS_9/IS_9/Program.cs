int sirka = 8;
int vyska = 8;
bool b = true; // pomocná proměnná b jako bool

Console.WriteLine("\n");

//1
Console.WriteLine("(1)");
for (int i = 0; i < vyska; i++)
{
    for (int j = 0; j < sirka; j++)
    {
        if (i == vyska / 2 || j == sirka / 2 || i == j || j == sirka - 1 - i)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.Write("\n");
}

//2
Console.WriteLine("\n(2)");
for (int i = 0; i < vyska; i++)
{
    for (int j = 0; j < sirka; j++)
    {
        if (j == sirka - 1 || j == 0 || i == 0 || i == vyska - 1 || j == sirka / 2 || i == vyska / 2)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.Write("\n");
}

//3
Console.WriteLine("\n(3)");
for (int i = 0; i < vyska; i++)
{
    for (int j = 0; j < sirka; j++)
    {
        if (j == sirka - 1 || j == 0 || i == 0 || i == vyska - 1 || i == j || j == sirka - 1 - i)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.Write("\n");
}

//4
Console.WriteLine("\n(4)");
for (int i = 0; i < vyska; i++)
{
    for (int j = 0; j < sirka; j++)
    {
        if (i == 0 || i == vyska - 1 || j == vyska - 1 - i)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.Write("\n");
}

//5
Console.WriteLine("\n(5)");
for (int i = 0; i < vyska; i++)
{
    for (int j = 0; j < sirka; j++)
    {
        if (i == 0 || i == vyska - 1 || i == j)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.Write("\n");
}

//6
Console.WriteLine("\n(6)");
for (int i = 0; i < vyska; i++)
{
    for (int j = 0; j < sirka; j++)
    {
        if (j == 0 || j == sirka - 1 || i == j)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.Write("\n");
}

//7
Console.WriteLine("\n(7)");
for (int i = 0; i < vyska; i++)
{
    for (int j = 0; j < sirka; j++)
    {
        if (j == 0 || j == sirka - 1 || j == vyska - 1 - i)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.Write("\n");
}

//8
Console.WriteLine("\n(8)");
for (int i = 0; i < vyska; i++)
{
    for (int j = 0; j < sirka; j++)
    {
        if (j % 2 != 0 && i % 2 != 0)
        {
            Console.Write(" ");
        }
        else
        {
            Console.Write("*");
        }
    }
    Console.Write("\n");
}

//9
Console.WriteLine("\n(9)");
for (int i = 0; i < vyska; i++)
{
    for (int j = 0; j < sirka; j++)
    {
        if ((j + 1) % 3 == 0 || (i + 1) % 3 == 0)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.Write("\n");
}

//10
b = true;
Console.WriteLine("\n(10)");
for (int i = 0; i < vyska; i++)
{
    for (int j = 0; j < sirka; j++)
    {
        if (i % 2 == 0 || (b && j == 0 || !b && j == sirka - 1))
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
    if (i % 2 == 0)
    {
        b = !b;
    }
    Console.Write("\n");
}

//11
b = true;
Console.WriteLine("\n(11)");
for (int i = 0; i < vyska; i++)
{
    for (int j = 0; j < sirka; j++)
    {
        if (j % 2 == 0 || (b && i == 0 || !b && i == sirka - 1))
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
        if (j % 2 == 0)
        {
            b = !b;
        }
    }
    Console.Write("\n");
}

//12
b = true;
Console.WriteLine("\n(12)");
for (int i = 0; i < vyska; i++)
{
    for (int j = 0; j < sirka; j++)
    {
        if ((b && i % 2 == 0 && j % 2 != 0) || (!b && j % 2 == 0))
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
    b = !b;
    Console.Write("\n");
}

//13
Console.WriteLine("\n(13)");
for (int i = 0; i < vyska; i++)
{
    for (int j = 0; j < sirka; j++)
    {
        if (i < vyska / 2 && j < sirka / 2 && (i == 0 || i == vyska / 2 - 1 || j == 0 || j == sirka / 2 - 1)
            || i >= vyska / 2 && j >= sirka / 2 && (i == vyska / 2 || i == vyska - 1 || j == sirka / 2 || j == sirka - 1))
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.Write("\n");
}

//14
Console.WriteLine("\n(14)");
for (int i = 0; i < vyska; i++)
{
    for (int j = 0; j < sirka; j++)
    {
        if (i < vyska / 2 && j < sirka / 2 || i >= vyska / 2 && j >= sirka / 2)
        {
            Console.Write(" ");
        }
        else
        {
            Console.Write("*");
        }
    }
    Console.Write("\n");
}

//15
Console.WriteLine("\n(15)");
for (int i = 0; i < vyska; i++)
{
    for (int j = 0; j < sirka; j++)
    {
        if (i == vyska / 2 - j - 1 || i == vyska / 2 + j || j == sirka / 2 + i || j == sirka - i + sirka / 2 - 1)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.Write("\n");
}

//16
Console.WriteLine("\n(16)");
for (int i = 0; i < vyska; i++)
{
    for (int j = 0; j < sirka; j++)
    {
        if (i <= vyska / 2 && j >= sirka / 2 - i - 1 && j <= sirka / 2 + i ||
            i > vyska / 2 && j <= vyska - i + vyska / 2 - 1 && i <= vyska / 2 + j)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.Write("\n");
}

//17
Console.WriteLine("\n(17)");
for (int i = 0; i < vyska; i++)
{
    for (int j = 0; j < sirka; j++)
    {
        if ((j + i) % 3 == 0)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.Write("\n");
}

//18
b = true;
Console.WriteLine("\n(18)");
for (int i = 0; i < vyska; i++)
{
    if (i % 3 == 0)
    {
        b = !b;
    }
    for (int j = 0; j < sirka; j++)
    {
        if ((!b && (j - i) % 3 == 0) || (b && (j + i) % 3 == 0 && j != 0))
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.Write("\n");
}

//19
b = true;
Console.WriteLine("\n(19)");
for (int i = 0; i < vyska; i++)
{
    if (i == vyska / 2)
    {
        b = !b;
    }
    for (int j = 0; j < sirka; j++)
    {
        if ((b && j < sirka - i && i <= j) || (!b && j >= sirka - i - 1 && i >= j))
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.Write("\n");
}

//20
b = true;
Console.WriteLine("\n(20)");
for (int i = 0; i < vyska; i++)
{
    for (int j = 0; j < sirka; j++)
    {
        if (j != 0 && j % 2 == 0)
        {
            b = !b;
        }
        if (b)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
    if (i % 2 == 0)
    {
        b = !b;
    }
    Console.Write("\n");
}