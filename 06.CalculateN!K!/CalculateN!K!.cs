using System;

namespace _06.CalculateN_K_
{
    class Program
    {
        static int fact(int number) //5 4 3 2 1
        {
            if (number == 1) return 1;
            else return number * fact(number - 1); //5 * 4 * 3 * 2 * 1
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int calc = 0;
            calc = fact(n) / fact(k);
            Console.WriteLine(calc);
        }
    }
}
