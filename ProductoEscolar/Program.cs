using System.Numerics;

int [] vector1 = new int [5];
int [] vector2 = new int [5];
int [] vector3 = new int [5];
int [] vectorResultados = new int [5];
int acumulador = 0;
Console.WriteLine("Ingrese los valores del primer vector: ");
for (int i = 0; i <vector1.Length; i++)
{
    try
    {
        Console.Write($"Valor {i+1}: ");
        vector1[i] = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.ForegroundColor=ConsoleColor.DarkRed;
        Console.WriteLine("Valor invalido. Por favor, ingrese un numero entero");
        i--;
        Console.ResetColor();
    }
}
Console.WriteLine("Ingrese los valores del segundo vector: ");
for (int i = 0; i < vector2.Length; i++)
{
    try
    {
        Console.Write($"Valor {i+1}: ");
        vector2[i] = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.ForegroundColor=ConsoleColor.DarkRed;
        Console.WriteLine("Valor invalido. Por favor, ingrese un numero entero");
        Console.ResetColor();
    }
}
for (int i = 0; i < vector3.Length; i++)
{
    vector3[i] = vector1[i] * vector2[i];
    vectorResultados[i] = vector3[i];
    acumulador += vector3[i];
}
Console.ForegroundColor=ConsoleColor.DarkBlue;
Console.WriteLine(" === Producto Escolar === ");
Console.ResetColor();
for (int i = 0; i < vectorResultados.Length; i++)
{
    Console.WriteLine($"{vector1[i]} * {vector2[i]} = {vectorResultados[i]}");
}
Console.WriteLine($"Suma total: {acumulador}");