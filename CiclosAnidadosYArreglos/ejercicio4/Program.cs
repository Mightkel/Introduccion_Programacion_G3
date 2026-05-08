Console.Clear();
Console.WriteLine("Numeros del 1 al 20, omitiendo multiplos de 3 y deteniendose en 15:");
for (int i = 1; i<=20; i++)
{
    if (i % 3 == 0)
    {
        continue;
    }
    else if (i >= 15)
    {
        break;
    }
    Console.WriteLine($"{i}");
}
