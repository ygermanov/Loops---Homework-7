using System;

namespace _05.Calculate
{
    class Calculate
    {
        static double fact(int number) //5 4 3 2 1
        {
            if (number == 1) return 1;
            else return number * fact(number - 1); //5 * 4 * 3 * 2 * 1
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            double calc = 1d;
            for (int i = 1; i <= n; i++)  //1 + 1!/x + 2!/x2 + … + n!/xn. 
            {
                calc += fact(i) / Math.Pow(x, i);
            }
            Console.WriteLine("{0:F5}",calc);
        }
    }
}
