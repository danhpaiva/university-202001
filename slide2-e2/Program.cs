using System;

namespace slide2_e2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nCálculo da Área do Triângulo");

            double b = 0, a = 0, r = 0;

            Console.WriteLine("\tInforme a base do triângulo: ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("\tInforme a altura do triângulo: ");
            a = double.Parse(Console.ReadLine());

            //Cálculo
            r = (b * a) / 2;

            Console.WriteLine($"\tO resultado da área é: {r} !");
        }
    }
}
