using System;

// Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:
// CADENA FUENTE: “La mar estaba serena"
// CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
// CADENA RESULTADO: “Li mir estibi sereni"

namespace ejercicio_3
{
    class Progam
    {
        static void Main(string[] args)
        {
            // variables
            char caracter, caracter1, caracter2;
            int x = 0;
            char[] cadena = new char[30];

            Console.WriteLine("Ingrese una letra....");
            caracter = char.Parse(Console.ReadLine());

            while (caracter != '.' && x<30)
            {
                cadena[x] = caracter;
                Console.WriteLine("Ingrese otra letra....");
                caracter = char.Parse(Console.ReadLine());
                x++;
            }

            if (x >= 30)
            {
                x--;
            }
            cadena[x] = '\0';
            Console.WriteLine("La frase completa es... ");
            x = 0;
            while (cadena[x] != '\0')
            {
                Console.Write(cadena[x]);
                x++;
            }
            Console.WriteLine("...Ingrese un carecter a reemplazar....");
            caracter1 = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo carecter....");
            caracter2 = char.Parse(Console.ReadLine());
            x = 0;

            while (cadena[x] != '\0')
            {
                if (cadena[x] == caracter1)
                {
                    cadena[x] = caracter2;
                }
                x++;
            }

            Console.WriteLine("La nueva frase es... ");
            x = 0;
            while (cadena[x] != '\0')
            {
                Console.Write(cadena[x]);
                x++;
            }
        }
    }
}