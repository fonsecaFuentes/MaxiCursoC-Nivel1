using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            float importeTotal, litros;
            string descuento = "0%";

            // Pedir datos
            Console.Write("Ingrese la cantidad de litros vendidos: ");
            litros = float.Parse(Console.ReadLine());
            Console.Write("Ingrese el todal de esa venta: ");
            importeTotal = float.Parse(Console.ReadLine());

            // Condicionales
            // if (litros > 100 && litros <= 300){
            //     descuento = "10%";
            //     importeTotal *= 0.90F;
            // }
            // else if (litros > 300 && litros <= 500){
            //     descuento = "15%";
            //     importeTotal *= 0.85F;
            // }
            // else if (litros > 500){
            //     descuento = "25%";
            //     importeTotal *= 0.75F;
            // }

            if (litros > 500){
                descuento = "25%";
                importeTotal *= 0.75F;
            }
            else if (litros > 300){
                descuento = "15%";
                importeTotal *= 0.85F;
            }
            else if (litros > 100){
                descuento = "10%";
                importeTotal *= 0.90F;
            }

            Console.WriteLine("El descuento por venta de " + litros + " litros, es del " + descuento + ". Por lo tanto el importe a pagar es de " + importeTotal +" $.");
        }
    }
}