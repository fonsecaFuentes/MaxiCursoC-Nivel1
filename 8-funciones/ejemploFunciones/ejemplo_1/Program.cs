using System;

namespace ejemplo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resultado;

            Console.WriteLine("Ingrese un número:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número:");
            n2 = int.Parse(Console.ReadLine());

            //lógica
            resultado = Suma(n1, n2);
            //fin de lógica

            Console.WriteLine("El resultado es de: " + resultado);
        }

        static int Suma(int a, int b)
        {
            int r;
            r = a + b;
            return r;
        }
    }
}