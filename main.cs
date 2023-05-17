using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arreglo1 = new int[3];
        int[] arreglo2 = new int[3];

        // Ingresar datos en el primer arreglo
        Console.WriteLine("Ingrese los datos para el primer arreglo:");

        for (int i = 0; i < arreglo1.Length; i++)
        {
            Console.Write($"Ingrese el valor {i + 1}: ");
            arreglo1[i] = int.Parse(Console.ReadLine());
        }

        // Ingresar datos en el segundo arreglo
        Console.WriteLine("\nIngrese los datos para el segundo arreglo:");

        for (int i = 0; i < arreglo2.Length; i++)
        {
            Console.Write($"Ingrese el valor {i + 1}: ");
            arreglo2[i] = int.Parse(Console.ReadLine());
        }

        // Ordenar los arreglos
        Array.Sort(arreglo1);
        Array.Sort(arreglo2);

        // Mostrar los arreglos ordenados
        Console.WriteLine("\nArreglo 1 ordenado:");
        foreach (int num in arreglo1)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine("\n\nArreglo 2 ordenado:");
        foreach (int num in arreglo2)
        {
            Console.Write(num + " ");
        }

        Console.ReadLine();
    }
}
