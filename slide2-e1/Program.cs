using System;

namespace slide2_e1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\nCalculating the Math Power of a Number");

            double basePower = 0, exponent = 0, result = 0;

            Console.WriteLine("Inform the power base: ");
            basePower = int.Parse(Console.ReadLine()); //TypeCast

            Console.WriteLine("Inform the power exponent: ");
            exponent = int.Parse(Console.ReadLine()); //TypeCast

            result = Math.Pow(basePower, exponent);

            Console.WriteLine($"\nThe result of the potency is: {result} .");
        }
    }
}
