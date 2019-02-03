using System;
using System.Globalization;

namespace exercicio_04
{
    
    class Program
    {

        static void Main(string[] args)
        {
            
            
            Console.Write("Entre com o valor do raio: ");

            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = Calculadora.Circunferencia(raio);

            Console.WriteLine("Circunferência:: " + circ.ToString("F2", CultureInfo.InvariantCulture));

            double vol = Calculadora.Volume(raio);
            Console.WriteLine("Volume: " + vol.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Valor de Pi: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}
