using System;

namespace e01_avulso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\tLeitor de Endereços");

            Console.WriteLine("\tInforme sua rua: ");
            string rua = Console.ReadLine();

            Console.WriteLine("\tInforme o número da sua casa: ");
            string numero = Console.ReadLine();

            Console.WriteLine("\tInforme seu bairro: ");
            string bairro = Console.ReadLine();

            Console.WriteLine("\tInforme sua cidade: ");
            string cidade = Console.ReadLine();

            Console.WriteLine("\tInforme seu estado: ");
            string estado = Console.ReadLine();

            Console.WriteLine("\tInforme seu país: ");
            string pais = Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"\n\tSeu endereço é:\nRua: {rua} Número: {numero}\nBairro: {bairro}\nCidade:{cidade}\nEstado: {estado}\nPaís: {pais}");
        }
    }
}
