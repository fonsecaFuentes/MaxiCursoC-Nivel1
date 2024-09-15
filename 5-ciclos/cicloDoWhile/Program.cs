using System;
using System.Diagnostics;

namespace cicloDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con = 0, acu = 0;
            float promedio;

            do{
                Console.WriteLine("Ingrese un número");
                n = int.Parse(Console.ReadLine());

                if (n != 0){
                    con++;
                    acu += n;
                }

            }while (n != 0);

            promedio = acu / con;

            Console.WriteLine("Ingresaste: " + con + " números. Y la sume total es de: " + acu);
            Console.WriteLine("El promedio de los números ingresados es: " + promedio);
        }
    }
}