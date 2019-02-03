using System;
using System.Globalization;

namespace exercicio_conta {
    public class Conta {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public Conta (int numero, string titular) {
            Numero = numero;
            Titular = titular;
        }
        public Conta (int numero, string titular, double deposito) : this (numero, titular) {            
            Deposito(deposito);
        }

        public void Deposito (double valor) {
            if (valor > 0) {
                Saldo += valor;
            }

        }
        public void Saque (double valor) {
            double taxa = 5.0;
            if (Saldo >= (valor + taxa)) {
                Saldo -= (valor + taxa);
            }
        }

        public override string ToString () {
            FormattableString message = $"Conta: {Numero}, Titular: {Titular}, Saldo: $ {Saldo}";
            string messageInInvariantCulture = FormattableString.Invariant (message);
            return messageInInvariantCulture;
        }
    }
}