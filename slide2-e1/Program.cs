using System;

namespace slide2_e1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\nCálculo de Potência");

            double b = 0, e = 0, r = 0;

            Console.WriteLine("Informe a base da potência: ");
            b = int.Parse(Console.ReadLine()); //TypeCast

            Console.WriteLine("Informe o expoente da potência: ");
            e = int.Parse(Console.ReadLine()); //TypeCast

            //Calcular a Potência
            r = Math.Pow(b, e);

            Console.WriteLine($"O resultado da potência é: {r} !");
        }
    }
}
