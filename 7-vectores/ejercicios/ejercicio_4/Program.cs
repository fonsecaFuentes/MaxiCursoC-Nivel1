using System;

// Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
// - Número de Artículo (1 a 15)
// - Cantidad Vendida
// Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
// Se pide determinar e informar:
// a) El número de artículo que más se vendió en total.
// b) Los números de artículos que no registraron ventas.
// c) Cuantas unidades se vendieron del número de artículo 10.

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables
            int nroArticulo, cantVendida;
            int[] totalCantidadVendida = new int[15];

            for (int i = 0; i < 15; i++)
            {
                totalCantidadVendida[i] = 0;
            }

            Console.WriteLine("Ingrese el número del artículo");
            nroArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad vendida");
            cantVendida = int.Parse(Console.ReadLine());

            while (nroArticulo != 0 && nroArticulo <= 15)
            {
                totalCantidadVendida[nroArticulo - 1] += cantVendida;

                Console.WriteLine("Ingrese el número del artículo");
                nroArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese cantidad vendida");
                cantVendida = int.Parse(Console.ReadLine());
            }

            // punto a
            int maxCantidad = totalCantidadVendida[0];
            int posArtMax = 1;

            for (int i = 0; i < 15; i++)
            {
                if (totalCantidadVendida[i] > maxCantidad)
                {
                    maxCantidad = totalCantidadVendida[i];
                    posArtMax = i + 1;
                }
            }

            Console.WriteLine("El articulo que mas se vendio es: " + posArtMax + " con la suma de un total de $ " + maxCantidad);

            // punto b
            for (int i = 0; i < 15; i++)
            {
                if (totalCantidadVendida[i] == 0)
                {
                    Console.WriteLine("Los artículos que no vendieron son:");
                    Console.WriteLine(i + 1);
                }
            }

            // punto b
            Console.WriteLine("Las ventas en el artículo 10 son: " + totalCantidadVendida[9]);
        }
    }
}