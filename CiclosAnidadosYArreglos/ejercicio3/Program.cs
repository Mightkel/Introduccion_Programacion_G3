Console.WriteLine("Triángulo:");
Console.WriteLine();

for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= 5 - i; j++)
    {
        Console.Write(" ");
    }
    for (int k = 1; k <= (2 * i - 1); k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.WriteLine();

Console.WriteLine("Cuadrado:");
Console.WriteLine();
for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= 5; j++)
    {
        Console.Write("**");
    }

    Console.WriteLine();
}
Console.WriteLine();