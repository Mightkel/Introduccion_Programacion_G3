int [] libros = new int [5];
string [] categorias = {"Romance", "Fantasía", "Novela", "Psicología", "No ficción"};
string masventas = "";
int mayor = 0, total = 0;
double promedio;

Console.Clear();
Console.WriteLine("Inventario de Libreria");
for (int i = 0; i < libros.Length; i++)
{
    try
    {
        Console.Write($"Ingrese la cantidad de libros vendidos de {categorias[i]}: ");
        libros[i] = int.Parse(Console.ReadLine()!);
        total += libros[i];
    }
    catch(FormatException)
    {
        Console.ForegroundColor=ConsoleColor.DarkRed;
        Console.WriteLine("Valor invalido. Por favor, ingrese un numero entero");
        Console.ResetColor();
        i--;
    }
    if (libros[i] > mayor)
    {
        mayor = libros[i];
        masventas = categorias[i];
    }   
}
promedio = total/5;

Console.ForegroundColor=ConsoleColor.DarkBlue;
Console.WriteLine(" === Reporte del Inventario === ");
Console.ResetColor();
Console.WriteLine($"Total de libros vendidos: {total}");
Console.WriteLine($"Categoria con más ventas: {masventas} ({mayor} libros vendidos)");
Console.WriteLine($"Promedio de libros vendidos: {promedio}");