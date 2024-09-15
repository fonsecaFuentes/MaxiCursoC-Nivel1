using System;

namespace ejercicio1
{
    class Progam
    {
        static void Main(string[] args)
        {
            // Variables
            int num1, num2, num3, num4, menor;

            // Pedir valores
            Console.WriteLine("Ingrese el primer número");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto número");
            num4 = int.Parse(Console.ReadLine());


            // Condicionales
            if (num1 < num2)
                menor = num1;
            else
                menor = num2;
            if (num3 < menor)
                menor = num3;
            if (num4 < menor)
                menor = num4;

            Console.WriteLine("El número más pequeño es: " + menor);
        }
    }
}