using System;

// Hacer un programa que solicite 10  números enteros y los guarde en un vector. Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.

namespace ejercicio_2
{
    class Progam
    {
        static void Main(string[] args)
        {
            // variables
            int n;
            int acu = 0;
            int cont = 0;
            int prom = 0;
            int[] numeros = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un número....");
                n = int.Parse(Console.ReadLine());
                numeros[i] = n;
            }

            for (int i = 0; i < 10; i++)
            {
                acu += numeros[i];
                cont++;
            }

            prom = acu / cont;

            Console.WriteLine("El promedio es... " + prom + " y los valores que son mayores al promedio... ");

            for (int i = 0; i < 10; i++)
            {
                if (numeros[i] > prom)
                {
                    Console.WriteLine("Este numero es mayor al promedio... " + numeros[i]);
                }
            }
        }
    }
}