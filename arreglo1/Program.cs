//almacenar 10 edades en un arreglo, luego mostrar el promedio de las edades, el maximo y el minimo
//crea arreglo de edades
int[] edades = new int[10];
//pedir edades
for (int i = 0; i < edades.Length; i++)
{
    try
    {
        
    Console.WriteLine("Ingrese la edad " + (i + 1) + ":");
    edades[i] = int.Parse(Console.ReadLine());

    }
    catch
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Error: Ingrese un número válido.");
        i--;
        Console.ResetColor();
    }   
}

//calcular promedio, maximo y minimo
int suma = 0, maximo = edades[0], minimo = edades[0];
foreach (int edad in edades)
{
    suma += edad;
    if (edad > maximo)
        maximo = edad;
    if (edad < minimo)
        minimo = edad;
}
double promedio = (double)suma / edades.Length; 

//mostrar resultados
Console.WriteLine("El promedio de las edades es: " + promedio);
Console.WriteLine("La edad máxima es: " + maximo);
Console.WriteLine("La edad mínima es: " + minimo);
