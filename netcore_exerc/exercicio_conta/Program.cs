using System;
using System.Globalization;

namespace exercicio_conta {
    class Program {
        static void Main (string[] args) {
            Conta c; //= new Conta(123,"marcio",10.20);

            Console.Write ("Entre com o umero da conta:");
            int numero = int.Parse (Console.ReadLine (), CultureInfo.InvariantCulture);
            Console.Write ("Entre com o titular da conta:");
            string titular = Console.ReadLine ();
            Console.Write ("Havara deposito inicial (s/n)?");

            double deposito = 0;
            if (Console.ReadKey ().Key == ConsoleKey.S) {
                Console.WriteLine();
                Console.Write("Entre com o valor do deposito inicial:");
                deposito = double.Parse (Console.ReadLine (), CultureInfo.InvariantCulture);
                c = new Conta (numero, titular, deposito);
            } else {
                c = new Conta (numero, titular);
            }

            Console.WriteLine ();
            Console.WriteLine ("Dados da conta:");
            Console.WriteLine (c);

            Console.Write ("Entre com o valor do deposito:");
            deposito = double.Parse (Console.ReadLine (), CultureInfo.InvariantCulture);
            c.Deposito(deposito);
            Console.WriteLine (c);
            Console.WriteLine ();

            Console.Write ("Entre com o valor do saque:");
            deposito = double.Parse (Console.ReadLine (), CultureInfo.InvariantCulture);
            c.Saque(deposito);
            Console.WriteLine(c);
        }
    }
}