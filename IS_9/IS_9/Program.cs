int sirka = 8;
int vyska = 8;

Console.WriteLine("\n");

//4
for (int i = 0; i <= vyska; i++)
{
    for (int j = 0; j < sirka; j++)
    {
        if (i == 0 || i == vyska - 1)
        {
            Console.Write("*");
        }
        else
        {
            if (j == vyska - i - 1)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
    }
    Console.Write("\n");
}

//14
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