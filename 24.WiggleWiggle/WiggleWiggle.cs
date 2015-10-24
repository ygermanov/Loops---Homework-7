using System;

namespace _24.WiggleWiggle
{
    class WiggleWiggle
    {
        static void Main()
        {
            string numbers = Console.ReadLine();
            string[] splitNumbers = numbers.Split();
            int lenght = splitNumbers.GetLength(0);
            ulong number1;
            ulong number2;
            ulong[] newNumbers = new ulong[lenght];
            for (int i = 0; i < lenght; i += 2)
            {
                number1 = ulong.Parse(splitNumbers[i]);
                number2 = ulong.Parse(splitNumbers[i + 1]);
                ulong temp = 1;
                ulong mask;
                for (int j = 1; j <= 63; j += 2)
                {
                    mask = temp << (j - 1);
                    if ((number1 | mask) != number1 && (number2 | mask) == number2)
                    {
                        number1 = number1 | mask;
                        number2 = number2 ^ mask;
                    }
                    else if ((number1 | mask) == number1 && (number2 | mask) != number2)
                    {
                        number1 = number1 ^ mask;
                        number2 = number2 | mask;
                    }
                }
                newNumbers[i] = number1;
                newNumbers[i + 1] = number2;
            }
            foreach (ulong v in newNumbers)
            {
                number1 = v;
                ulong mask;
                ulong temp = 1;
                for (int i = 1; i <= 63; i++)
                {
                    mask = temp << (i - 1);
                    if ((number1 | mask) == number1)
                    {
                        number1 = number1 ^ mask;
                    }
                    else
                    {
                        number1 = number1 | mask;
                    }
                }
                string binarynumber = string.Empty;
                number2 = number1;
                while (number2 != 0)
                {
                    binarynumber = (number2 % 2).ToString() + binarynumber;
                    number2 /= 2;
                }
                binarynumber = binarynumber.PadLeft(63, '0');
                Console.Write("{0} ", number1);
                Console.Write(binarynumber);
                Console.WriteLine();
            }
        }
    }
}
