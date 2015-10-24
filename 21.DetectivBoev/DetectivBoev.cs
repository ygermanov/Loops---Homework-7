using System;

namespace test2
{
    class Program
    {
        static void Main()
        {
            string secretWord = Console.ReadLine();
            string message = Console.ReadLine();
            int mask = 0;
            for (int i = 0; i < secretWord.Length; i++)
            {
                mask += (int)secretWord[i];
            }
            int tempMask = 0;
            while (true)
            {
                if (mask == 0)
                {
                    mask = tempMask;
                    tempMask = 0;
                }
                tempMask += mask % 10;
                mask /= 10;
                if (mask == 0 && tempMask < 10) break;
            }
            string newMessage = string.Empty;
            for (int i = 0; i < message.Length; i++)
            {
                if ((int)message[i] % tempMask == 0)
                {
                    newMessage += (char)(message[i] + tempMask);
                }
                else
                {
                    newMessage += (char)(message[i] - tempMask);
                }
            }
            char[] output = newMessage.ToCharArray();
            Array.Reverse(output);
            Console.WriteLine(output);
        }
    }
}
