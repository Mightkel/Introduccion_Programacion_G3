int [] vector = new int [5];
int [] vectorCuadrado = new int [5];
int suma = 0;
Console.Clear();
Console.WriteLine("Por favor ingrese los valores del vector:");
for (int i = 0; i < vector.Length; i++)
{
    try
    {
        Console.Write($"Valor {i+1}: ");
        vector[i] = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.ForegroundColor=ConsoleColor.DarkRed;
        Console.WriteLine("Valor invalido. Por favor ingrese un numero entero");
        Console.ResetColor();
        i--;

    }
}
for (int i = 0; i < vectorCuadrado.Length; i++)
{
    suma += vector[i] * vector[i];
}
double magnitud = Math.Sqrt(suma);
Console.ForegroundColor=ConsoleColor.DarkBlue;
Console.WriteLine($"La magnitud del vector es: {magnitud}");
Console.ResetColor();