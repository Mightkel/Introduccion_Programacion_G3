int [] puntaje = new int [6];
int mayor = 0, contador = 0;

Console.Clear();
Console.WriteLine("Ingrese sus 6 puntajes:");
for (int i = 0; i < puntaje.Length; i++)
{
    try
    {
        Console.Write($"Puntaje #{i+1}: ");
        puntaje[i] = int.Parse(Console.ReadLine()!);
    }
    catch(FormatException)
    {
        Console.ForegroundColor=ConsoleColor.DarkRed;
        Console.WriteLine("Valor invalido. Por favor, ingrese un numero entero");
        Console.ResetColor();
        i--;
    }
    if (puntaje[i] > mayor)
    {
        mayor = puntaje[i];
    }
    if (puntaje[i] >= 500)
    {
        contador++;
    }

}
Array.Sort(puntaje);
Console.ForegroundColor=ConsoleColor.DarkBlue;
Console.WriteLine(" === Reporte de puntaje === ");
Console.ResetColor();
Console.WriteLine($"Puntaje más alto: {mayor}");
Console.WriteLine($"Veces que se superaron los 500 puntos: {contador}");
Console.WriteLine($"Puntajes obtenidos, en orden ascendente:");
for (int i = 0; i < puntaje.Length; i++)
{
    Console.WriteLine($"{puntaje[i]}");
}