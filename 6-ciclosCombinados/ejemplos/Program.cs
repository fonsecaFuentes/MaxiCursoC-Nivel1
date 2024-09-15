using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ciclos combinados

            // For con for
            // int prom; acu; n; cont;

            // for (int y = 0; y < 10; y++)
            // {
            //     acu = 0;
            //     for (int x = 0; x < 20; x++)
            //     {
            //         Console.WriteLine("Ingrese la edad: ");
            //         n = int.Parse(Console.ReadLine());
            //         acu += n;
            //     }
            //     prom = acu / 20;
            //     Console.WriteLine("El promedio es: " + prom)
            // }

            // For con while
                // for (int x = 0; x < 10; x++)
                // {
                //     Console.WriteLine("Ingrese la edad: ");
                //     n = int.Parse(Console.ReadLine());
                //     cont = 0;
                //     acu = 0;
                //     while (n != 0)
                //     {
                //         acu += n;
                //         cont++;
                //         Console.WriteLine("Ingrese la edad: ");
                //         n = int.Parse(Console.ReadLine());
                //     }
                //     prom = acu / cont;
                //     Console.WriteLine("El promedio es: " + prom)
                // }

            // While con for
                // Console.WriteLine("Ingrese 1 comenzar a procesar o 0 para terminar...");
                // n = int.Parse(Console.ReadLine());
                // while (n != 0)
                // {
                //     acu = 0;
                //     for (int x = 0; x < 20; x++)
                //     {
                //         Console.WriteLine("Ingrese la edad: ");
                //         n = int.Parse(Console.ReadLine());
                //         acu += n;
                //     }
                //     prom = acu / 20;
                //     Console.WriteLine("El promedio es: " + prom)
                //     Console.WriteLine("Ingrese 1 comenzar a procesar o 0 para terminar...");
                //     n = int.Parse(Console.ReadLine());
                // }

            // While con while
            int prom, acu, n, cont;
            Console.WriteLine("Ingrese 1 comenzar a procesar o numero negativo para terminar...");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                cont = 0;
                acu = 0;
                while (n != 0)
                {
                    acu += n;
                    cont++;
                    Console.WriteLine("Ingrese la edad: ");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine(acu);
                }
                prom = acu / cont;
                Console.WriteLine("El promedio es: " + prom);

                Console.WriteLine("Ingrese 1 comenzar a procesar o numero negativo para terminar...");
                n = int.Parse(Console.ReadLine());
            }
        }
    }
}