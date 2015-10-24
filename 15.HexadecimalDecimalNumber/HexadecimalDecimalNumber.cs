using System;
using System.Collections.Generic;

namespace _15.HexadecimalDecimalNumber
{
    class HexadecimalDecimalNumber
    {
        static void Main()
        {
            string hexNumber = Console.ReadLine();
            long decimalNumber = 0;
            int powNumber = hexNumber.Length - 1;
            Dictionary<char, int> specSymbols = new Dictionary<char, int>()
            {
                {'A', 10},
                {'B', 11},
                {'C', 12},
                {'D', 13},
                {'E', 14},
                {'F', 15},
                {'a', 10},
                {'b', 11},
                {'c', 12},
                {'d', 13},
                {'e', 14},
                {'f', 15}
            };
            for (int i = 0; i < hexNumber.Length; i++)
            {
                if (specSymbols.ContainsKey(hexNumber[i]))
                {
                    decimalNumber += specSymbols[hexNumber[i]] * (long)Math.Pow(16, powNumber);
                    powNumber--;
                }
                else
                {
                    decimalNumber += long.Parse(hexNumber[i].ToString()) * (long)Math.Pow(16, powNumber);
                    powNumber--;
                }
            }
            Console.WriteLine(decimalNumber);
        }
    }
}
