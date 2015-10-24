using System;
using System.Collections.Generic;

namespace _23.LightTheTorches
{
    class LightTheTorches
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            char[] rooms = new char[number];
            string roomsString = Console.ReadLine();
            int temp = 0;
            for (int i = 0; i < number; i++)
            {
                if (roomsString.Length > 0)
                {
                    if (temp >= roomsString.Length)
                    {
                        temp = 0;
                    }
                    rooms[i] = roomsString[temp];
                    temp++;
                }
                else
                {
                    rooms[i] = 'D';
                }
            }
            List<string> movements = new List<string>();
            string tempMovements = Console.ReadLine();
            bool check = true;
            if (tempMovements == "END" || tempMovements == "end") check = false;
            while (check)
            {
                movements.Add(tempMovements);
                tempMovements = Console.ReadLine();
                if (tempMovements == "END" || tempMovements == "end") check = false;
            }
            int mark = number / 2;
            check = false;
            foreach (string v in movements)
            {
                if (v.Length > 1)
                {
                    string[] splitString = v.Split(' ');
                    if (splitString[0] == "LEFT" || splitString[0] == "left")
                    {
                        if (mark - int.Parse(splitString[1]) <= 0)
                        {
                            if (mark == 0) check = true;
                            mark = 0;
                        }
                        else
                        {
                            mark = mark - int.Parse(splitString[1]) - 1;
                        }
                        if (!check)
                        {
                            if (rooms[mark] == 'L') rooms[mark] = 'D';
                            else rooms[mark] = 'L';
                        }
                        check = false;
                    }
                    else if (splitString[0] == "right" || splitString[0] == "RIGHT")
                    {
                        if (mark + int.Parse(splitString[1]) >= number - 1)
                        {
                            if (mark == number - 1) check = true;
                            mark = number - 1;
                        }
                        else
                        {
                            mark = mark + int.Parse(splitString[1]) + 1;
                        }
                        if (!check)
                        {
                            if (rooms[mark] == 'L') rooms[mark] = 'D';
                            else rooms[mark] = 'L';
                        }
                        check = false;
                    }
                }
            }
            int count = 0;
            foreach (char v in rooms)
            {
                if (v == 'D')
                {
                    count++;
                }
            }
            Console.WriteLine(count * (int)'D');
        }
    }
}
