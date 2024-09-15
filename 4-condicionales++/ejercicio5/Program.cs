using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int n1, n2, n3, n4;

            Console.WriteLine("Escribe un número");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe otro número");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe otro número");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe un último número");
            n4 = int.Parse(Console.ReadLine());

            if(n1 > n2 && n2 > n3 && n3 > n4){
                Console.WriteLine("Los números están ordenados de forma decreciente.");
            }
            else{
                Console.WriteLine("Los números no están ordenados de forma decreciente.");
            }

        }
    }
}