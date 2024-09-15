using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, var = 0;

            Console.WriteLine("Introduzca un número...");
            num = int.Parse(Console.ReadLine());
            PositivoNegativoCero(num, ref var);
            if (var > 0)
            {
                Console.WriteLine("El valor es positivo");
            }
            else if (var < 0)
            {
                Console.WriteLine("El valor es negativo");
            }
            else
            {
                Console.WriteLine("El valor es 0");
            }
        }

        static void PositivoNegativoCero(int n, ref int var)
        {
            if (n > 0)
            {
                var = 1;
            }
            else  if (n < 0)
            {
                var = -1;
            }
            else
            {
                var = 0;
            }
        }
    }
}