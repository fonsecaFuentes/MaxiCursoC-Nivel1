using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con = 0;

            Console.WriteLine("Ingrese un número para saber si es primo o no.");
            n = int.Parse(Console.ReadLine());


            // do{
            //     Console.WriteLine("Ingrese un número para saber si es primo o no. Nota ingrese 0 para salir del programa...");
            //     n = int.Parse(Console.ReadLine());
            //     if (n != 0){
            //         if (n % 2 != 0){
            //             Console.WriteLine("El número " + n + " es un número primo.");
            //         }else{
            //             Console.WriteLine("El número " + n + " no es un número primo.");
            //         }
            //     }
            // } while (n != 0);

            for (int x = 1; x <= n; x++)
            {
                if (n % x == 0)
                {
                    con++;
                }
            }
            if (con == 2)
            {
                Console.WriteLine("El número " + n + " es un número primo.");
            }
            else
            {
                Console.WriteLine("El número " + n + " no es un número primo.");
            }
        }
    }
}