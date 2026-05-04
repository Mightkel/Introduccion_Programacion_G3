//Leer un numero entero y mostrar todos sus antecesores elevados al cubo
using Math = System.Math;
int numero;
Console.Clear();
while (true)
{
    Console.WriteLine("Ingrese un numero");
    if(int.TryParse(Console.ReadLine(), out numero))
    {
        break;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Entrada invalida, ingrese un numero entero");
        Console.ResetColor();
    }
}
Console.WriteLine("Los antecesores elevados al cubo son:");
int contador = 1;
while(contador < numero)
{
    double cubo = Math.Pow(contador, 3);
    Console.WriteLine($"{contador}³ = {cubo}");
    contador++;
}