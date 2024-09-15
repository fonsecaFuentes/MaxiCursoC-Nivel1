using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, cont = 0, contenido;

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Ingrese 20 números");
                n = int.Parse(Console.ReadLine());

                contenido = Par(n);

                if (contenido == 1)
                {
                    cont++;
                }
            }
            Console.WriteLine("La cantidad de números pares de la lista es de: " + cont);
        }

        static int Par(int a)
        {
            if (a % 2 == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}