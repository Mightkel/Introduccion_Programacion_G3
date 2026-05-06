//crea un arreglo de notas de 15 estudiantes, luego calcula el promedio de notas y los 3 primeros lugares.
//no se puede ingresar notas menores a 0 ni mayores a 100
int [] notas = new int[15];
int suma = 0;
double promedio = 0;

for (int i = 0; i < notas.Length; i++)
{
    try
    {
        Console.WriteLine($"Ingrese la nota del estudiante {i + 1}: ");
        int nota = int.Parse(Console.ReadLine());
        if (nota < 0 || nota > 100)
        {
            throw new ArgumentOutOfRangeException("La nota debe ser entre 0 y 100.");
        }
        notas[i] = nota;
        suma += nota;
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine(ex.Message);
        i--; // Reintentar la misma posición
    }
    catch (FormatException)
    {
        Console.WriteLine("Entrada inválida. Ingrese un número válido.");
        i--; // Reintentar la misma posición
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ocurrió un error: {ex.Message}");
        i--; // Reintentar la misma posición
    }
}