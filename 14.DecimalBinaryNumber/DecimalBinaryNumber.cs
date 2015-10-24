using System;

namespace _14.DecimalBinaryNumber
{
    class DecimalBinaryNumber
    {
        static void Main()
        {
            long decimalNumber = long.Parse(Console.ReadLine());
            string binarynumber = string.Empty;
            if (decimalNumber == 0) binarynumber = "0";
            while (decimalNumber != 0)
            {
                binarynumber += (decimalNumber % 2).ToString();
                decimalNumber /= 2;
            }
            char[] reverse = binarynumber.ToCharArray();
            Array.Reverse(reverse);
            Console.WriteLine(reverse);
        }
    }
}
