int [] numeros = new int[8];
for (int i = 0; i < numeros.Length; i++)
{
    Console.Write($"Ingrese el numero #{i + 1}: ");
    numeros[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Numeros positivos; hasta cero o menor:");
for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] == 0)
    {
        break;
    }
    if (numeros[i] < 0)
    {
        continue;
    }
    Console.WriteLine(numeros[i]);
}