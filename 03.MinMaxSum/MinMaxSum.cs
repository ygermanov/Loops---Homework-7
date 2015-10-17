using System;


namespace _03.MinMaxSum
{
    class MinMaxSum
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            double avrg = 0d;
            int min = 100000000;
            int max = 0;
            for (int i = 0; i < num; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                sum += numbers;
                if (max < numbers)
                {
                    max = numbers;
                }
                if (min > numbers)
                {
                    min = numbers;
                }
            }
            avrg = (double)sum / num;
            Console.WriteLine("min = {0}", min);
            Console.WriteLine("max = {0}", max);
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("avg = {0:F2}", avrg);

        }
    }
}
