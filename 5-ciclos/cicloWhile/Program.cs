using System;

namespace cicloWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con = 0, acu = 0;
            Console.WriteLine("Ingrese un número");
            n = int.Parse(Console.ReadLine());
            acu += n;

            while (n != 0){
                Console.WriteLine("Ingrese un número");
                n = int.Parse(Console.ReadLine());
                con++;
                acu += n;
            }
            Console.WriteLine("Ingresaste: " + con + " números. Y la sume total es de: " + acu);
        }
    }
}