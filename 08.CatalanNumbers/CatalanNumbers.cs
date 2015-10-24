using System;

namespace _08.CatalanNumbers
{
    class CatalanNumbers
    {
        static double fact(int number) //5 4 3 2 1
        {
            if (number <= 1) return 1;
            else return number * fact(number - 1); //5 * 4 * 3 * 2 * 1
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double calc = 1;
            calc = fact(2 * n) / (fact(n + 1) * fact(n));
            Console.WriteLine(calc);
        }
    }
}
