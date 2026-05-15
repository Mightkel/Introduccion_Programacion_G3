int[,] matriz = new int[5, 5];
Console.Clear();
Console.WriteLine("Ingrese los datos de la matriz 5x5");
for (int f = 0; f < 5; f++)
{
    for (int c = 0; c < 5; c++)
    {
        try
        {
            Console.Write($"Elemento [{f},{c}]: ");
            matriz[f, c] = int.Parse(Console.ReadLine()!);
        }
        catch (FormatException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Elemento invalido, ingrese un número válido");
            Console.ResetColor();
        }
    }
}
Console.WriteLine();
Console.Write("Ingrese el número que desea buscar en la matriz: ");
int numero = int.Parse(Console.ReadLine()!);

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine(" === Resultado de la búsqueda ===");
Console.ResetColor();

for (int f = 0; f < 5; f++)
{
    for (int c = 0; c < 5; c++)
    {
        if (matriz[f, c] == numero)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
        Console.Write(matriz[f, c] + "\t");
    }
    Console.WriteLine();
}
Console.ResetColor();
