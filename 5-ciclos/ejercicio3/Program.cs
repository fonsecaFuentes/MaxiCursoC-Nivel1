using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad, mayor = 0, cont = 0;

            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese una edad");
                edad = int.Parse(Console.ReadLine());
                if (edad > 18){
                    cont++;
                    mayor += edad;
                }
            }
            if (mayor != 0)
            {
                Console.WriteLine("El promedio de las edades mayores a 18 años es: " + (mayor/cont));
            }
            else
            {
                Console.WriteLine("No se ingreso ninguna edad mayor a 18");
            }
        }
    }
}