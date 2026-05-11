int [] temperaturas = new int [7];
int datos = 0;
int mayor =0, menor =999;

Console.Clear();
Console.WriteLine("Ingrese las temperaturas de la semana:");
for (int i= 0; i < temperaturas.Length; i++)
{
    try
    {
        Console.Write($"Temperatura #{i+1}: ");
        temperaturas[i] = int.Parse(Console.ReadLine()!);
        datos += temperaturas[i];
    }
    catch(FormatException)
    {
        Console.ForegroundColor=ConsoleColor.DarkRed;
        Console.WriteLine("Por favor, Ingrese un numero entero");
        Console.ResetColor();
        i--;
    }

    if (temperaturas[i] > mayor)
    {
        mayor = temperaturas[i];
    }
    if (temperaturas[i] < menor)
    {
        menor = temperaturas[i];
    }

}
double promedio = datos/7;

Console.ForegroundColor=ConsoleColor.DarkBlue;
Console.WriteLine(" === Registro semanal === ");
Console.ResetColor();
Console.WriteLine($"La temperatura más alta fue de: {mayor:N1} Grados");
Console.WriteLine($"La temperatura más baja fue de: {menor:N1} Grados");
Console.WriteLine($"El promedio de la temperatura esta semana fue de: {promedio:N1} Grados");
Console.WriteLine($"El total de temperatura registradad esta semana es de: {datos:N1} Grados");
Console.WriteLine("Las temperaturas registradas fueron: ");
for (int i = 0; i <temperaturas.Length; i++)
{
    Console.WriteLine($"{temperaturas[i]} Grados");
}
