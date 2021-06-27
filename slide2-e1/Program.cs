using System;

namespace slide2_e1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\nCalculating the Math Power of a Number");

            double base_power = 0, exponent = 0, result = 0;

            Console.WriteLine("Inform the power base: ");
            base_power = int.Parse(Console.ReadLine()); //TypeCast

            Console.WriteLine("Inform the power exponent: ");
            exponent = int.Parse(Console.ReadLine()); //TypeCast

            result = Math.Pow(base_power, exponent);

            Console.WriteLine($"\nThe result of the potency is: {result} .");
        }
    }
}
