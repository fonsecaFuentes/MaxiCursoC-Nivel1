using System;

namespace evaluacion
{
    class Program
    {
        static void Main(string[] args)
        {
            // double n1, n2, r;
            // n1 = 1.5;
            // n2 = 3.5;

            // n2 = n2 + 0.5;

            // r = n1 + 0.5;

            // r = n1 * n2;

            // Console.WriteLine(r);

            // int inicio = 10;
            // int intervalo = 2;

            // while (inicio >= 0)
            // {
            //     Console.WriteLine(inicio + " ");
            //     inicio -= intervalo;
            // }

            // for (int i = 1; i <= 10; i++)
            // {
            //     if (i % 2 != 0)
            //     {
            //         Console.WriteLine(i);
            //     }
            // }

            int numero;
            int suma = 0;

            numero = int.Parse(Console.ReadLine());

            while (numero != 0)
            {
                suma += numero % 10;
                numero /= 10;
            }
            Console.WriteLine(suma);
        }
    }
}