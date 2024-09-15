using System;

namespace ejercicio1
{
    class Progam
    {
        static void Main(string[] args)
        {
            // Variables
            int numero;

            // Pedir valores
            Console.WriteLine("Ingrese un número:");
            numero = int.Parse(Console.ReadLine());

            // Condicionales
            if(numero > 0)
                Console.WriteLine("Positivo");
            else if(numero == 0)
                Console.WriteLine("Cero");
            else
                Console.WriteLine("Negativo");
        }
    }
}