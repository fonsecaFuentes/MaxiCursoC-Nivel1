using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, parMayor = 0, imparMenor = 0, x = 0;
            bool banPar = false, banImpar = false;

            while (x < 5){
                Console.WriteLine("Ingrese un numero...");
                n = int.Parse(Console.ReadLine());

                    if (n % 2 == 0)
                    {
                        if (banPar == false){
                            banPar = true;
                            parMayor = n;
                        }
                        else if (n > parMayor)
                            parMayor = n;
                    }
                    else
                    {
                        if (banImpar == false){
                            banImpar = true;
                            imparMenor = n;
                        }
                        else if (n < imparMenor)
                        {
                            imparMenor = n;
                        }
                    }
                x++;
            }
            if (banPar == true)
                            Console.WriteLine("De los numeros que ingresaste el mayor par es..." + parMayor);
            else
                Console.WriteLine("No has ingresado ningun número par...");
            if (banImpar == true)
                Console.WriteLine("De los numeros que ingresaste el menor impar es..." + imparMenor);
            else
                Console.WriteLine("No has ingresado ningun número impar...");
        }
    }
}