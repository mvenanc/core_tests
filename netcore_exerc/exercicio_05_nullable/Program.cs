using System;

namespace exercicio_05_nullable {
    class Program {
        static void Main (string[] args) {
            //Nullable<double> x = null; //nullable permite que variaveis de valor (structs ou tipos primitivos) ppossam receber null;
            double? x = null; //outra forma de escrever nullable
            double? y = 10.0; //uma vez Nullable, pode-se invocar alguns métodos específicos

            double a = x ?? 5; // operador de coalescencia ??. Se quiser atribuir o valor de ma variavel Nullable para uma variavel normal.
                               // ?? permite que seja copiado o valor caso seja diferente de null, ou um valor padrao.
                               //no caso acima, se x for diferente de null, será atribuido para "a", do contrario, será atribuido o valor 5;
            double b = y ?? 5;


            Console.WriteLine (x.GetValueOrDefault ());
            Console.WriteLine (y.GetValueOrDefault ());

            Console.WriteLine (x.HasValue);
            Console.WriteLine (y.HasValue);

            //Console.WriteLine(x.Value); //se tentar escrever valor de uma variavel Nullable sem valor, será lançado exececao
            if (x.HasValue) {
                Console.WriteLine (x.Value);
            }
            if (y.HasValue) {
                Console.WriteLine (y.Value);
            }


            Console.WriteLine("A :"+ a);
            Console.WriteLine("B :"+ b);            
        }
    }
}