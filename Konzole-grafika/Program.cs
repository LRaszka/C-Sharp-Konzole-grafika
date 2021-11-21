Console.Write("         *********");
Console.WriteLine();

for (int i = 0; i < 9; i++)
{
    for (int j = i + 1; j < 9; j++)
    {
        Console.Write(" ");
    }
    Console.Write("*");
    for (int j = 9 + 2 * i; j > 0; j--)
    {
        Console.Write(" ");
    }
    Console.Write("*");
    if (i == 1)
        Console.Write("      ***");
    else if (i == 2)
        Console.Write(" ___**");
    else if (i == 3)
        Console.Write("| |");
    else if (i == 4)
        Console.Write(" |");
    Console.WriteLine();
}

for (int i = 0; i < 27; i++)
{
    Console.Write("-");
}

Console.WriteLine();

for (int i =0; i < 10; i++)
{
    if(i == 2 || i == 5)
        Console.WriteLine(" |             -------   |");
    else if(i == 3)
        Console.WriteLine(" |             |__|__|   |");
    else if(i == 4)
        Console.WriteLine(" |             |  |  |   |");
    else if (i == 6)
        Console.WriteLine(" |____                   |");
    else if(i < 7)
        Console.WriteLine(" |                       |");
    else
        Console.WriteLine(" |    |                  |");
}

for (int i = 0; i < 25; i++)
{
    if (i == 0)
        Console.Write(" ");
    Console.Write("-");
}

Console.ReadKey();
