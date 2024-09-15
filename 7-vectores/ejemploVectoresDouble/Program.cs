using System;

namespace ejemploVectoresDouble
{
    class Progam
    {
        static void Main(string[] args)
        {
            double[] muestraMatutina = new double[3];
            double[] muestraVespertina = new double[3];
            double[] muestraNocturna = new double[3];

            //cruce
            //registro matutino
            int dia;
            double temperatura;
            Console.WriteLine("Cargue el registro matutino...");
            for (int x = 0; x < 3; x++)
            {
                Console.WriteLine("Ingrese día: ");
                dia = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese temperatura... ");
                temperatura = double.Parse(Console.ReadLine());

                muestraMatutina[dia-1] = temperatura;
            }

            //registro vespertino
            // Console.WriteLine("Cargue el registro matutino...");
            // for (int x = 0; x < 3; x++)
            // {
            //     Console.WriteLine("Ingrese día: ");
            //     dia = int.Parse(Console.ReadLine());
            //     Console.WriteLine("Ingrese temperatura... ");
            //     temperatura = double.Parse(Console.ReadLine());

            //     muestraVespertina[dia-1] = temperatura;
            // }

            // //registro nocturno
            // Console.WriteLine("Cargue el registro matutino...");
            // for (int x = 0; x < 3; x++)
            // {
            //     Console.WriteLine("Ingrese día: ");
            //     dia = int.Parse(Console.ReadLine());
            //     Console.WriteLine("Ingrese temperatura... ");
            //     temperatura = double.Parse(Console.ReadLine());

            //     muestraNocturna[dia-1] = temperatura;
            // }

            //leer registro
            for (int x = 0; x < 3; x++)
            {
                Console.WriteLine("Muestra matutina de día " + (x+1) + " temperatura " + muestraMatutina[x]);
            }
        }
    }
}