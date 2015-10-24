using System;

namespace _12.RandomizeNumbers
{
    class RandomizeNumbers
    {
        static void Main()
        {
            Random random = new Random();
            int numMax = int.Parse(Console.ReadLine());
            int[] numCheck = new int[numMax];
            int count = 0;
            int mark = 0;
            while (true)
            {
                mark = random.Next(1, numMax + 1);
                if (numCheck[mark - 1] == 0)
                {
                    numCheck[mark - 1] = 1;
                    Console.Write(mark + " ");
                    count++;
                }
                if (count == numMax)
                {
                    break;
                }
            }
            Console.WriteLine();
        }
    }
}
