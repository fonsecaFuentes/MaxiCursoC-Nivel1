using System;

// Hacer un programa que solicite 10 números enteros y los guarde en un vector. Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.

namespace ejercicio_1
{
    class Progam
    {
        static void Main(string[] args)
        {
            // variables
            int n, max;
            int p = 1;
            int[] numeros = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un número....");
                n = int.Parse(Console.ReadLine());
                numeros[i] = n;
            }

            max = numeros[0];

            for (int i = 0; i < 10; i++)
            {
                if (numeros[i] > max)
                {
                    max = numeros[i];
                    p = i + 1;
                }
            }

            Console.WriteLine("El numero maximo es... " + max + " y su posicion es... " + p);
        }
    }
}