using System;

namespace slide2_e1
{
    class Program
    {
        static void Main(string[] args)
        {
            double b = 0, e = 0, r = 0;
            Console.WriteLine("Slide 02 - Exercício 01");

            Console.WriteLine("Informe a base: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o expoente: ");
            e = int.Parse(Console.ReadLine());

            //Cálculo
            r = Math.Pow(b, e);

            Console.WriteLine($"Resultado: {r}");
        }
    }
}
