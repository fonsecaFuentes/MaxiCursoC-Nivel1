// using System;

// namespace comision_empleado
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Inicialisación de variables y constantes
//             // Variables
//             float empFacturado, comision, sueldoTotal;
//             // Constantes
//             const float sueldo = 15000;
//             const float porcentaje = 0.05f;

//             // Pedido de datos al usuario por teclado
//             Console.WriteLine("Ventas de los empleados del comercio...");
//             Console.WriteLine("Empleado 1 ingrese su venta: ");
//             empFacturado = float.Parse(Console.ReadLine());

//             // Realizamos operaciones correspondientes
//             comision = empFacturado * porcentaje;

//             sueldoTotal = comision + sueldo;

//             // Mostrar resultado por consola
//             Console.WriteLine("El empleado tubo una venta de " + empFacturado + "$" + " su comision correspondiente es " + comision + "$" + " por lo tanto su sueldo es de " + sueldoTotal + "$");
//         }
//     }
// }