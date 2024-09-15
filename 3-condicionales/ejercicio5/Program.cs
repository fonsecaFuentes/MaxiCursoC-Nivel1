using System;

namespace ejercicio1
{
    class Progam
    {
        static void Main(string[] args)
        {
            // Variables
            int num1, num2, num3, num4, con;
            con = 0;

            // Pedir valores
            Console.WriteLine("Ingrese el primer número");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto número");
            num4 = int.Parse(Console.ReadLine());

            Console.WriteLine("<--------------------------------->");

            // Condicionales
            if (num1 > 100){
                Console.Write(num1 + ", ");
                con++;
            }
            if (num2 > 100){
                Console.Write(num2 + ", ");
                con++;
            }
            if (num3 > 100){
                Console.Write(num3 + ", ");
                con++;
            }
            if (num4 > 100){
                Console.Write(num4 + ", ");
                con++;
            }
            if (con > 0){
                Console.WriteLine("...Estos son los números mayores a 100");
            }
            else
            {
                Console.WriteLine("No hay ningun número mayor a 100");
            }
        }
    }
}