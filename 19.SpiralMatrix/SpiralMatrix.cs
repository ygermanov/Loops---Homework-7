using System;

namespace _19.SpiralMatrix
{
    class SpiralMatrix
    {
        static void Main()
        {
            int size;
            while (true)
            {
                Console.Clear();
                string input = Console.ReadLine();
                bool checkInput = int.TryParse(input, out size) && (1 <= size && size <= 20);
                if (checkInput)
                {
                    break;
                }
            }

            int[,] matrix = new int[size, size];
            int counter = 2;
            int row = 0, col = 1;
            int check1 = size - 1;
            int check2 = 0;
            bool check = false;
            matrix[0, 0] = 1;
            while (counter <= (size * size))
            {
                if (col < check1 && row < check1 && col > check2)
                {
                    matrix[row, col] = counter;
                    counter++;
                    col++;
                }
                else if (col == check1 && row < check1)
                {
                    matrix[row, col] = counter;
                    counter++;
                    row++;
                }
                else if (row == check1 && col <= check1 && col > check2)
                {
                    matrix[row, col] = counter;
                    counter++;
                    col--;
                }
                else if (col == check2 && row <= check1 && row > check2)
                {
                    matrix[row, col] = counter;
                    counter++;
                    row--;
                    if (row == check2) check = true;
                }
                if (check)
                {
                    check1--;
                    check2++;
                    check = false;
                    row++;
                    if (counter <= size * size)
                    {
                        matrix[row, col + 1] = counter;
                        if (col + 2 <= check1) col += 2;
                        else
                        {
                            row++;
                            col = check1;
                        }
                        counter++;
                    }
                }
            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("{0} ", matrix[i,j].ToString().PadLeft(3, ' '));
                }
                Console.WriteLine();
            }
        }
    }
}
