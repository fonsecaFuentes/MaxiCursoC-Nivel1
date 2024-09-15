using System;

namespace corteDeControl
{
    class Program
    {
        static void Main(string[] args)
        {
            // CORTE DE CONTROL
            // legajo, edad, sueldo, codigo de equipo

            int legajo, edad, codigoEquipo;
            float sueldo;
            int equipoActual;

            Console.WriteLine("Ingrese el legajo");
            legajo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la edad");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el sueldo");
            sueldo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el codigo de equipo");
            codigoEquipo = int.Parse(Console.ReadLine());

            while (sueldo >= 0)
            {
                equipoActual = codigoEquipo;

                while (codigoEquipo == equipoActual)
                {
                    Console.WriteLine("Ingrese el legajo");
                    legajo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la edad");
                    edad = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el sueldo");
                    sueldo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el codigo de equipo");
                    codigoEquipo = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}