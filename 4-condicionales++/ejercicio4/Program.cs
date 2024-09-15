using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int n1, n2, n3;

            Console.WriteLine("Escribe un número");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe otro número");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe un último número");
            n3 = int.Parse(Console.ReadLine());

            if ((n1+n2) > (n2*n3)){
                Console.WriteLine("La suma de los dos primeros números ES mayor al producto del segundo con el tercero");
            }
            else{
                Console.WriteLine("La suma de los dos primeros números NO es mayor al producto del segundo con el tercero");
            }
        }
    }
}