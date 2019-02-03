using System;
using System.Globalization;

namespace exercicio_encap {
    public class Produto {

        //encapsulamento
        // private string Nome;
        // private double Preco;
        // private int Quantidade;

        private string _nome;
        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1)
                    _nome = value;
            }
        }
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }


        public Produto () { }
        public Produto (string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

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
            return Nome +
                ", $" + Preco.ToString ("F2", CultureInfo.InvariantCulture) +
                ", " +
                Quantidade +
                " unidades, Total: $ " +
                ValorTotalEmEstoque ().ToString ("F2", CultureInfo.InvariantCulture);

        }
    }
}