using System;

namespace acu_con
{
    class Progam
    {
        static void Main(string[] atgs)
        {
            // Acumuladores y Contadores
            // variables
            int contador = 0, acumulador = 0, ed1 = 20, ed2 = 10, ed3 = 30, promedio;
            const int mayor = 18;

            if (ed1 >= mayor){
                contador = contador + 1;
                acumulador = acumulador + ed1;
            }
            if (ed2 >= mayor){
                contador ++;
                acumulador += ed2;
            }
            if(ed3 >= mayor){
                contador ++;
                acumulador += ed3;
            }

            //Calculos
            promedio = acumulador / contador;

            // Mostrar por consola
            Console.WriteLine("La cantidad de personas mayores de edad son: " + contador);
            Console.WriteLine("El promedio de esas edades son: " + promedio);
        }
    }
}