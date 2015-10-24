using System;

namespace _11.RandomNumbersGivenRange
{
    class RandomNumbersGivenRange
    {
        static void Main()
        {
            Random random = new Random();
            int numCount = int.Parse(Console.ReadLine());
            int numMin = int.Parse(Console.ReadLine());
            int numMax = int.Parse(Console.ReadLine());
            for (int i = 0; i < numCount; i++)
            {
                Console.Write(random.Next(numMin, numMax + 1) + " ");
            }
            Console.WriteLine();
        }
    }
}
