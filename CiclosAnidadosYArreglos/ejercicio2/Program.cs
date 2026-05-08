int numero;
while (true)
{
    Console.WriteLine("Ingrese un numero positivo: ");
    if (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
    {
        Console.WriteLine("Entrada inválida. Por favor, ingrese un número positivo y mayor que cero.");
    }
    else
    { 
        break;
    }
}
Console.WriteLine($"Tabla del {numero}");
for (int i = 1; i <= 12; i++)
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
}
