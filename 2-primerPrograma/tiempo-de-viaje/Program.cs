// using System;

// namespace tiempo_de_viaje
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             //Iniciar variables
//             float dis, vel, time_hs, time_min;

//             //Pedir los valores al usuario
//             Console.WriteLine("Escriba la distancia en Km del camino al realizar: ");
//             dis = float.Parse(Console.ReadLine());
//             Console.WriteLine("Escriba la velocidad promedio en el vieje: ");
//             vel = float.Parse(Console.ReadLine());

//             //Realizar calculo
//             time_hs = dis / vel;
//             time_min = (time_hs % 1.00f) * 100;

//             //Mostrar por pantalla
//             Console.WriteLine("El tiempo aproximado en recorrer " + dis + "Km" + " es " + time_hs.ToString("0") + " horas " + " y " + time_min.ToString("0") + " minutos.");
//         }
//     }
// }