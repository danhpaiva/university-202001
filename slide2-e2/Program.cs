using System;

namespace slide2_e2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nCalculation of the Triangle Area");

            Console.WriteLine("\tInform the base of the triangle: ");
            double baseTriangle = double.Parse(Console.ReadLine());

            Console.WriteLine("\tEnter the height of the triangle: ");
            double heightTriangle = double.Parse(Console.ReadLine());

            double result = (baseTriangle * heightTriangle) / 2;
            Console.WriteLine($"\tThe result of the triangle area is: {result} !");
        }
    }
}
