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
    Console.WriteLine();
}

for (int i = 0; i < 27; i++)
{
    Console.Write("-");
}

Console.WriteLine();

for (int i =0; i < 10; i++)
{
    Console.WriteLine(" |                       |");
}

for (int i = 0; i < 25; i++)
{
    if (i == 0)
        Console.Write(" ");
    Console.Write("-");
}

Console.ReadKey();
