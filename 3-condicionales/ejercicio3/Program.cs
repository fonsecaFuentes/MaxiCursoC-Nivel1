using System;

namespace ejercicio1
{
    class Progam
    {
        static void Main(string[] args)
        {
            // Variables
            float importe;

            // Pedir valores
            Console.WriteLine("Ingrese importe:");
            importe = float.Parse(Console.ReadLine());

            // Condicionales
            if(importe >= 5000){
                importe *= 0.82f;
            }
            else if(importe >= 1000){
                importe *= 0.90f;
            }

            Console.WriteLine("El usuario debe pagar...$ " + importe);
        }
    }
}