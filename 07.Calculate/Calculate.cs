using System;

namespace _07.Calculate
{

    class Calculate
    {
        static double fact(int number)//5 4 3 2 1
        {
            if (number == 1) return 1;
            else return number * fact(number - 1);//5 * 4 * 3 * 2 * 1
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            double calc = 0;
            calc = fact(n) / (fact(k) * (fact(n - k)));
            Console.WriteLine(calc);
            Console.WriteLine(fact(n));
        }
    }
}
