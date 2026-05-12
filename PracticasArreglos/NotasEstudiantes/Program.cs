double [] notas = new double [8];
int reprobados = 0;
double totalnotas = 0, promedio;; 

Console.Clear();
Console.WriteLine("Ingrese las notas de ocho estudiantes:");
for (int i = 0; i< notas.Length; i++)
{
    try
    {
        Console.Write($"Estudiante #{i+1}: ");
        notas[i] = int.Parse(Console.ReadLine()!);
        totalnotas += notas[i];
        if (notas[i] < 0 || notas[i] > 100)
        {
            throw new ArgumentOutOfRangeException("La nota debe ser entre 0 y 100.");
        }
        if (notas[i] < 60)
        {
            reprobados++;
        }
    }
    catch(ArgumentOutOfRangeException ex)
    {
        Console.ForegroundColor=ConsoleColor.DarkRed;
        Console.WriteLine(ex.Message);
        Console.ResetColor();
        i--;
    }
    catch(FormatException)
    {
        Console.ForegroundColor=ConsoleColor.DarkRed;
        Console.WriteLine("Valor invalido. Por favor, ingrese un numero");
        Console.ResetColor();
        i--;
    }
}
promedio = totalnotas/8;

Console.ForegroundColor=ConsoleColor.DarkBlue;
Console.WriteLine(" === Informe de Calificaciones === ");
Console.ResetColor();
Console.WriteLine($"Promedio de Calificaciones: {promedio:N2}%");
Console.WriteLine($"Cantidad de reprobados: {reprobados}");
Console.WriteLine("Notas aprobadas:");
for (int i = 0; i < notas.Length; i++)
{
    if (notas[i] < 60)
    {
        continue;
    }
    else
    {
        Console.WriteLine($"{notas[i]:N2}%");
    }
}
