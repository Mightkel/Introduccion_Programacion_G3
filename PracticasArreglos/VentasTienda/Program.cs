double [] ventas = new double [7];
double total=0, menor=9999;
int dias=0;
Console.Clear();
Console.WriteLine("Ingrese los datos de las ventas de la semana");
for (int i = 0; i < ventas.Length; i++)
{
    try
    {
        Console.Write($"Venta #{i+1}: ");
        ventas[i] = double.Parse(Console.ReadLine()!);
        total += ventas[i];
    }
    catch
    {
        Console.ForegroundColor=ConsoleColor.DarkRed;
        Console.WriteLine("Valor invalido. Por favor, ingrese un numero");
        Console.ResetColor();
        i--;
    }
    if (ventas[i] < menor)
    {
        menor = ventas[i];
    }
    if (ventas[i] >= 150)
    {
        dias ++;
    }
}
Console.ForegroundColor=ConsoleColor.DarkBlue;
Console.WriteLine(" === Registro semanal de ventas === ");
Console.ResetColor();
Console.WriteLine($"Total vendido: C${total:N2}");
Console.WriteLine($"Días en los que las ventas superaron los C$150: {dias}");
Console.WriteLine($"Ventas más bajas: C${menor:N2}");
