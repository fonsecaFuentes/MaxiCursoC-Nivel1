using System;

namespace ejemploVectores
{
    class Progam
    {
        static void  Main(string[] args)
        {
            // Vectores. Arrays. Arreglos
            int n;
            int acu = 0;
            int[] numeros = new int[10];

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un número....");
                n = int.Parse(Console.ReadLine());
                numeros[x] = n;
            }

            for (int x = 0; x < 10; x++)
            {
                acu += numeros[x];
                Console.WriteLine("El valor es... " + numeros[x]);
            }

            int prom = acu / 10;
            Console.WriteLine("El valor es... " + prom);
        }
    }
}