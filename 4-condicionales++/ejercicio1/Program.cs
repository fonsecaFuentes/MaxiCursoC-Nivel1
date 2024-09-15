using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int n1, n2, r;
            string operacion;
            r = 0;

            Console.Write("Cargue el primer número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Cargue el segundo número: ");
            n2 = int.Parse(Console.ReadLine());

            if (n1 > n2){
                r = n1 - n2;
                operacion = "resta";
            }
            else if (n1 == n2){
                r = n1 + n2;
                operacion = "suma";
            }
            else{
                r = n1 * n2;
                operacion = "multiplicación";
            }

            Console.WriteLine("La operación a realizar es... " + operacion + ". El resultado es... " + r);
        }
    }
}