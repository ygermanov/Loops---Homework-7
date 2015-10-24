using System;
using System.Collections.Generic;

namespace _16.DecimalHexadecimalNumber
{
    class DecimalHexadecimalNumber
    {
        static void Main()
        {
            long decimalNumber = long.Parse(Console.ReadLine());
            string hexNumber = string.Empty;
            Dictionary<long, char> specSymbols = new Dictionary<long, char>()
            {
                {10, 'A'},
                {11, 'B'},
                {12, 'C'},
                {13, 'D'},
                {14, 'E'},
                {15, 'F'}
            };
            if (decimalNumber == 0) hexNumber = "0";
            while (decimalNumber != 0)
            {
                if (specSymbols.ContainsKey(decimalNumber % 16))
                {
                    hexNumber += specSymbols[decimalNumber % 16];
                    decimalNumber /= 16;
                }
                else
                {
                    hexNumber += (decimalNumber % 16).ToString();
                    decimalNumber /= 16;
                }
            }
            char[] reverse = hexNumber.ToCharArray();
            Array.Reverse(reverse);
            Console.WriteLine(reverse);
        }
    }
}
