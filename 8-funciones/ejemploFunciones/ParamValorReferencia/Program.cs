using System;

namespace ParamValorReferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0, resultado;
            PedirDatos(ref n1, ref n2);
            //lógica
            resultado = Suma(ref n1, n2);
            //fin de lógica

            Console.WriteLine("El resultado es de: " + resultado);
            Console.WriteLine("El contenido de n1 es de: " + n1);
        }

        static int Suma(ref int a, int b)
        {
            int r;
            r = a + b;
            a = 9999;
            return r;
        }

        static void PedirDatos(ref int num1, ref int num2)
        {
            Console.WriteLine("Ingrese un número:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número:");
            num2 = int.Parse(Console.ReadLine());
        }
    }
}