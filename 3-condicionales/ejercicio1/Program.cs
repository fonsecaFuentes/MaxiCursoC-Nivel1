using System;

namespace ejercicio1
{
    class Progam
    {
        static void Main(string[] args)
        {
            // Variables
            int num;
            const int mayor = 10;

            // Pedir valor
            Console.WriteLine("Escriba un numero:");
            num = int.Parse(Console.ReadLine());

            // Condicionales
            if(num > mayor)
                Console.WriteLine("Es mayor a " + mayor);
            else
                Console.WriteLine("No es mayor a " + mayor);
        }
    }
}