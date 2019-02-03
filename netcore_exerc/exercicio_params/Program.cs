using System;

namespace exercicio_params
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Sum(1,2,3,4,5,6,9,7,8));
            Console.WriteLine(Calculator.Sum(1,2,3,4,5,6));
            Console.WriteLine(Calculator.Sum(1,2,3,4,5,6,9,7,8,10)) ;


        }
    }
}
