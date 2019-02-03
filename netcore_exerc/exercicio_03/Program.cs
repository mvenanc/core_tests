using System;
using System.Globalization;

namespace exercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            Console.WriteLine("Entre com os dados");
            Console.Write("Nome : ");
            produto.Nome =  Console.ReadLine();
            Console.Write("Preco : ");
            produto.Preco =  double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque : ");
            produto.Quantidade =  int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + produto);

            Console.Write("Numero de produtos a adicionar : ");
            int quantidade = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(quantidade);

            Console.WriteLine("Dados alterados: " + produto);

            Console.Write("Numero de produtos a serem removidos do estoque : ");
            quantidade = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(quantidade);
            Console.WriteLine("Dados alterados: " + produto);
        }
    }
}
