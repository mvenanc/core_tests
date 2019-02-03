using System;
using System.Collections.Generic;

namespace exercicio_conjunto
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(1);
            B.Add(3);
            B.Add(2);
            B.Add(2); // conjunto nao insere numeros repetidos

            foreach(int x in B){
                Console.WriteLine(x); //item de conjunto nao é acessivel por indice
            }

            Console.WriteLine(B.Contains(3));

            //operacoes com conjuntos
            A.ExceptWith(B);
            
            foreach(int x in A){
                Console.WriteLine(x); //item de conjunto nao é acessivel por indice
            }

            A.UnionWith(B);
            foreach(int x in A){
                Console.WriteLine(x); //item de conjunto nao é acessivel por indice. Primeira alteracao. Segunda alteracao.

            }            


        }
    }
}
