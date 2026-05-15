//Matriz 3x3
int[,] matriz = new int[3, 3];
Console.Clear();
Console.WriteLine("Digite los elementos de la matriz 3x3:");
for (int f = 0; f < 3; f++)
{
    for (int c = 0; c < 3; c++)
    {
        Console.Write($"Elemento [{f}, {c}]: ");
        matriz[f, c] = int.Parse(Console.ReadLine()!);
    }
}
Console.WriteLine("Mostrar Matriz");
for (int f = 0; f < 3; f++)
{
    for (int c = 0; c < 3; c++)
    {
        if (matriz[f,c] % 2 == 0  && matriz[f,c] >= 0)
        {
            Console.ForegroundColor=ConsoleColor.DarkGreen;
            Console.Write($"{matriz[f,c]} ");
            Console.ResetColor();
        }
        else if(matriz[f, c] % 2 != 0 && matriz[f,c] >= 0)
        {
            Console.ForegroundColor=ConsoleColor.DarkRed;
            Console.Write($"{matriz[f, c]} ");
            Console.ResetColor();
        }
        else if (matriz[f, c] < 0)
        {
            Console.ForegroundColor=ConsoleColor.DarkYellow;
            Console.Write($"{matriz[f, c]} ");
            Console.ResetColor();
        }
    }
    Console.WriteLine();
}