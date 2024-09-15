using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, cont = 0, acum = 0, calcPrimo = 0, prom = 0;

            Console.WriteLine("Ingrese un lote de números al terminar ingrese 0");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                calcPrimo = Primo(n);
                if (calcPrimo == 1)
                {
                    acum += n;
                    cont++;
                }

                Console.WriteLine("Ingrese otro número al terminar ingrese 0");
                n = int.Parse(Console.ReadLine());
            }

            prom = acum / cont;

            Console.WriteLine("El promedio sumando solamente los números primos es: " + prom);
        }

        static int Primo(int a)
        {
            int cont = 0;
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    cont++;
                }
            }

            if (cont == 2)
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