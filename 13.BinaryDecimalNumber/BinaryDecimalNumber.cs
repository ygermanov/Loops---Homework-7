using System;

namespace _13.BinaryDecimalNumber
{
    class BinaryDecimalNumber
    {
        static void Main()
        {
            string binaryNumber = Console.ReadLine();
            int powNumber = binaryNumber.Length - 1;
            int decimalnumber = 0;
            for (int i = 0; i < binaryNumber.Length; i++)
            {
                decimalnumber += int.Parse(binaryNumber[i].ToString()) * (int)Math.Pow(2, powNumber);
                powNumber--;
            }
            Console.WriteLine(decimalnumber);
        }
    }
}
