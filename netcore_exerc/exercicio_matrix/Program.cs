using System;

namespace exercicio_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            double [,] mtx = new double[2,3];

            Console.WriteLine(mtx.Length);
            Console.WriteLine(mtx.Rank);
            Console.WriteLine(mtx.GetLength(0));

        }
    }
}
