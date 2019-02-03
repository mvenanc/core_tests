using System;
using System.Globalization;
namespace exercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos:");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Nome, idade e altura :");
            string[] vet = Console.ReadLine().Split(' ');
            string n1 = vet[0];
            int n2 = int.Parse(vet[1]);
            double n3 = double.Parse(vet[2]);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco);
            Console.WriteLine(vet[0]);
            Console.WriteLine(vet[1]);
            Console.WriteLine(vet[2]);
            

        }
    }
}
