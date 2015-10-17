using System;

namespace _04.PrintDeckOf52Cards
{
    class PrintDeckOf52Cards
    {
        static void Main()
        {
            for (int i = 2; i < 15; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    char temp = new char();
                    switch (j)
                    {
                        case 0:
                            temp = '♠';
                            break;
                        case 1:
                            temp = '♥';
                            break;
                        case 2:
                            temp = '♣';
                            break;
                        case 3:
                            temp = '♦';
                            break;
                        default:
                            break;
                    }
                    switch (i)
                    {
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                        case 10:
                            Console.Write("{0}{1}",i,temp);
                            break;
                        case 11:
                            Console.Write("J{0}",temp);
                            break;
                        case 12:
                            Console.Write("Q{0}",temp);
                            break;
                        case 13:
                            Console.Write("K{0}",temp);
                            break;
                        case 14:
                            Console.Write("A{0}",temp);
                            break;

                    }
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
