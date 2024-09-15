using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int edad = 20;

            // BLOQUE IF, ELSE: Condicionales
            // if (edad >= 21){ // Si es necesario llaves en este bloque porque tiene mas de una linea de codigo
            //     if (edad >= 30)
            //         Console.WriteLine("30 OFF"); // No es necesario llaves en estos bloques porque tiene una sola linea de codigo
            //     else
            //         Console.WriteLine("21 OFF"); // No es necesario llaves en estos bloques porque tiene una sola linea de codigo
            // }
            // else
            //     Console.WriteLine("10 OFF"); // No es necesario llaves en estos bloques porque tiene una sola linea de codigo

            // BLOQUE IF, ELSE IF: Condicionales
            if (edad >= 30) // No es necesario llaves en estos bloques porque tiene una sola linea de codigo
                Console.WriteLine("30 OFF");
            else if (edad >= 21) // No es necesario llaves en estos bloques porque tiene una sola linea de codigo
                Console.WriteLine("21 OFF");
            else // No es necesario llaves en estos bloques porque tiene una sola linea de codigo
                Console.WriteLine("10 OFF");

            // Fin
            Console.WriteLine("FIN");
        }
    }
}