using System;

namespace _09.MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(j + i);
                }
                Console.WriteLine();
            }
        }
    }
}
//      0 0 0 0 0 0 0 0
//      0 0 0 0 0 0 0 0
//      0 0 0 0 0 0 0 0
//      0 0 0 0 0 0 0 0
//      0 0 0 0 0 0 0 0
//      0 0 0 0 0 0 0 0
//      0 0 0 0 0 0 0 0