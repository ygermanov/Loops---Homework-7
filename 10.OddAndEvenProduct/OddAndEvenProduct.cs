using System;

namespace _10.OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main()
        {
            string num = Console.ReadLine(); // 2 6 5 4 3 10 254
            string[] numbers = num.Split(' ');
            int odd = 1;
            int even = 1;
            int count = 1;
            foreach (string v in numbers)
            {
                if (count % 2 == 0)
                {
                    even *= Convert.ToInt32(v);
                }
                else
                {
                    odd *= Convert.ToInt32(v);
                }
                count++;
            }
            if (even == odd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("product = {0}", even);
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("odd_product = {0}", odd);
                Console.WriteLine("even_product = {0}", even);
            }
        }
    }
}
