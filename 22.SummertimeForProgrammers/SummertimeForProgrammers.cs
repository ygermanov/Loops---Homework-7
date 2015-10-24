using System;

namespace _22.SummertimeForProgrammers
{
    class SummertimeForProgrammers
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int bottom = number * 2;
            int top = number + 1;
            Console.WriteLine("{0}{1}{0}",new string(' ', (bottom - top) / 2), new string('*', top));
            int temp = number / 2 - 1;
            for (int i = 1; i < number - temp; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string(' ', (bottom - top) / 2), new string(' ', number - 1));
            }
            for (int i = 1; i < temp + 1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string(' ', (bottom - top) / 2 - i), new string(' ', number + i * 2 - 1));
            }
            for (int i = 1; i <= number * 2; i++)
            {
                if (i <= number)
                {
                    Console.WriteLine("*{0}*", new string('.', bottom - 2));
                }
                else
                {
                    Console.WriteLine("*{0}*", new string('@', bottom - 2));
                }
            }
            Console.WriteLine(new string('*', number * 2));
        }
    }
}
