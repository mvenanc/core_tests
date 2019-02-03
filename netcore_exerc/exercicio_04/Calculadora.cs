using System;

namespace exercicio_04 {
    public class Calculadora {
        public static double Pi = 3.14;
        public static double Circunferencia (double raio) {
            return 2 * Pi * raio;
        }

        public static double Volume (double raio) {
            return Pi * Math.Pow (raio, 3) * 4.0 / 3.0;
        }
    }

}