// using System;

// namespace promedio_alumno
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             //variables
//             float nota1, nota2, nota3, promedio;

//             //pedir datos
//             Console.WriteLine("Ingrese sus ultimas notas");
//             Console.WriteLine("Primer nota");
//             nota1 = float.Parse(Console.ReadLine());
//             Console.WriteLine("Segunda nota");
//             nota2 = float.Parse(Console.ReadLine());
//             Console.WriteLine("Tercera nota");
//             nota3 = float.Parse(Console.ReadLine());

//             //Calculos
//             promedio = (nota1 + nota2 + nota3) / 3;

//             //mostrar resultado
//             Console.WriteLine("El alumno con sus notas " + nota1 + ", " + nota2 + " y " + nota3 + ". Su promedio es de " + promedio.ToString("0.00"));
//         }
//     }
// }