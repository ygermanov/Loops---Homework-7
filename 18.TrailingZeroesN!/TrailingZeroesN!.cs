using System;
using System.Numerics;

namespace _18.TrailingZeroesN_
{
    class Program
    {
        static BigInteger fact(int number) //5 4 3 2 1
        {
            if (number == 1) return 1;
            else return number * fact(number - 1); //5 * 4 * 3 * 2 * 1
        }
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string facNumber = fact(number).ToString();
            char[] reverse = facNumber.ToCharArray();
            Array.Reverse(reverse);
            int count = 0;
            for (int i = 0; i < facNumber.Length; i++)
            {
                if (reverse[i] != '0')
                {
                    break;
                }
                else
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
