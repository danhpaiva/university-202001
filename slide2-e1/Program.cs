using System;

namespace slide2_e1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\nCalculating the Math Power of a Number");

            Console.WriteLine("Inform the power base: ");
            double basePower = int.Parse(Console.ReadLine());
            Console.WriteLine("Inform the power exponent: ");
            double exponent = int.Parse(Console.ReadLine());

            double result = Math.Pow(basePower, exponent);
            Console.WriteLine($"\nThe result of the potency is: {result} .");
        }
    }
}
