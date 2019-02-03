using System;
using System.Globalization;

namespace exercicio_03 {
    public class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        double ValorTotalEmEstoque () {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos (int quantidade) {
            this.Quantidade += quantidade;
        }
        public void RemoverProdutos (int quantidade) {
            this.Quantidade -= quantidade;
        }

        public override string ToString () {
            //CultureInfo invC = CultureInfo.InvariantCulture;
            //Thread.CurrentThread.CurrentCulture = invC;             
            //return $"Dados do produto: {Nome}, {Preco:C2}, {Quantidade} unidades, Total: {ValorTotalEmEstoque()}";

            //return $"Dados do produto: {Nome}, {Preco:C2}, {Quantidade} unidades, Total: {ValorTotalEmEstoque()}";

            
            return Nome 
                + ", $" + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture);

        }
    }
}