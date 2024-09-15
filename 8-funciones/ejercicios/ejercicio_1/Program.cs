using System;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0, numero2 = 0, resultado;
            Console.WriteLine("Ingrese el precio de un artículo:");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida:");
            numero2 = int.Parse(Console.ReadLine());

            resultado = Producto(numero1, numero2);

            Console.WriteLine("Monto total a pagar es de: $" + resultado);
        }

        static int Producto(int n1, int n2)
        {
            int r;
            r = n1 * n2;
            return r;
        }
    }
}