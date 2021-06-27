using System;

namespace e01_avulso
{
    class Program
    {
        static void Main(string[] args)
        {
            DataAddresses dataAddresses = new DataAddresses();

            Console.WriteLine("\n\tAddress Reader");

            Console.WriteLine("\tInform your street: ");
            dataAddresses.Road = Console.ReadLine();

            Console.WriteLine("\tEnter your home number: ");
            dataAddresses.HomeNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("\tInform your neighborhood: ");
            dataAddresses.District = Console.ReadLine();

            Console.WriteLine("\tInform your city: ");
            dataAddresses.City = Console.ReadLine();

            Console.WriteLine("\tInform your State: ");
            dataAddresses.State = Console.ReadLine();

            Console.WriteLine("\tEnter your country: ");
            dataAddresses.Country = Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"\n\tYour address is:" +
                $"\nStreet: {dataAddresses.Road}\n" +
                $"Number: {dataAddresses.HomeNumber}\n" +
                $"District: {dataAddresses.District}\n" +
                $"City:{dataAddresses.City}\n" +
                $"State: {dataAddresses.State}\n" +
                $"Country: {dataAddresses.Country}");
        }
    }
}
