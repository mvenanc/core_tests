using System;
using System.Globalization;

namespace exercicio_listas {
    class Program {
        static void Main (string[] args) {
            
            int n = int.Parse (Console.ReadLine ());
            
            /*
            double[] vet = new double[n];
        
            for (int i = 0; i < n; i++) {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;

            foreach(var item in vet){
                sum+= item;
            }

            double avg= sum / n;
            Console.WriteLine("ALTURA MEDIA " + avg.ToString("F2",CultureInfo.InvariantCulture));*/

            Produto[] vet = new Produto[n];
            for (int i = 0; i < n; i++) {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vet[i] = new Produto {Nome = nome, Preco = preco} ;
            }
            
            double sum = 0.0;

            foreach(var item in vet){
                sum+= item.Preco;
            }
            double avg= sum / n;
            Console.WriteLine("PRECO MEDIO " + avg.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}