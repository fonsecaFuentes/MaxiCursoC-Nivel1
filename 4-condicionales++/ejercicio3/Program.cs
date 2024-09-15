using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int cpu, ram, disco, costo = 0;

            // Pedir datos al usuario
            Console.WriteLine("Elege su configuración del equipo a comprar....");
            Console.Write("Elige la opción del microprosesador ");
            Console.WriteLine("i5 (opción-1), i7 (opción-2), i9 (opción-3)");
            cpu = int.Parse(Console.ReadLine());
            Console.WriteLine("<-------------->");
            Console.Write("Elige la opción de laMemoria ram ");
            Console.WriteLine("8 RAM (opción-1), 16 RAM (opción-2), 32 RAM (opción-3)");
            ram = int.Parse(Console.ReadLine());
            Console.WriteLine("<-------------->");
            Console.WriteLine("Por defecto el equipo viene con un disco de 500 GB...");
            Console.Write("Elija, (opción-0), para mantener ese almacenamiento");
            Console.WriteLine("Elija, (opción-1), para adquirir un disco de 1 TB, esto tendra un costo adicional de USD 300");
            disco = int.Parse(Console.ReadLine());

            // condicionales
            // switch (cpu){
            //     case 1:
            //         switch (ram){
            //             case 1:
            //                 costo = 800;
            //                 break;
            //             case 2:
            //                 costo = 900;
            //                 break;
            //             case 3:
            //                 costo = 1000;
            //                 break;
            //             default:
            //                 Console.WriteLine("Elija una opcion correcta...");
            //                 break;
            //         }
            //         break;
            //     case 2:
            //         switch (ram){
            //             case 1:
            //                 costo = 900;
            //                 break;
            //             case 2:
            //                 costo = 1000;
            //                 break;
            //             case 3:
            //                 costo = 1400;
            //                 break;
            //             default:
            //                 Console.WriteLine("Elija una opcion correcta...");
            //                 break;
            //         }
            //         break;
            //     case 3:
            //         switch (ram){
            //             case 1:
            //                 costo = 1200;
            //                 break;
            //             case 2:
            //                 costo = 1400;
            //                 break;
            //             case 3:
            //                 costo = 2000;
            //                 break;
            //             default:
            //                 Console.WriteLine("Elija una opcion correcta...");
            //                 break;
            //         }
            //         break;
            //     default:
            //         Console.WriteLine("Elija una opcion correcta...");
            //         break;
            // }

            if (cpu == 1){
                switch (ram)
                {
                    case 1:
                        costo = 800;
                        break;
                    case 2:
                        costo = 900;
                        break;
                    case 3:
                        costo = 1000;
                        break;
                    default:
                        Console.WriteLine("Elija una opcion correcta...");
                    break;
                }
            }
            else if (cpu == 2){
                switch (ram){
                    case 1:
                        costo = 900;
                        break;
                    case 2:
                        costo = 1000;
                        break;
                    case 3:
                        costo = 1400;
                        break;
                    default:
                        Console.WriteLine("Elija una opcion correcta...");
                        break;
                }
            }
            else{
                switch (ram){
                    case 1:
                        costo = 1200;
                        break;
                    case 2:
                        costo = 1400;
                        break;
                    case 3:
                        costo = 2000;
                        break;
                    default:
                        Console.WriteLine("Elija una opcion correcta...");
                        break;
                }
            }

            if (disco == 1){
                costo += 300;
            }

            Console.WriteLine("El valor de la computadora seleccionada es de USD " + costo);

        }
    }
}