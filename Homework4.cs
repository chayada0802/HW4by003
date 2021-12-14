using System;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Townnumber, TargetTownnumber = 0, check = 0;
            Townnumber = int.Parse(Console.ReadLine());
            string[] TownName = new string[Townnumber];
            int[,] Distance = new int[Townnumber, Townnumber];
            int[] Result = new int[Townnumber];
            int[] result = new int[Townnumber];
            string TargetTown, StartTown;
            for (int i = 0; i < Townnumber; i++)
            {
                TownName[i] = Console.ReadLine();
            }
            StartTown = TownName[0];
            for (int i = 1; i < Townnumber; i++)
            {
                for (int m = 0; m < i; m++)
                {
                    Distance[i, m] = int.Parse(Console.ReadLine());
                    Distance[m, i] = Distance[i, m];
                }
            }
            TargetTown = Console.ReadLine();
            for (check = 0; check < Townnumber; check++)
            {
                if (TargetTown == TownName[check])
                {
                    TargetTownnumber = check;
                }
            }
            for (int i = 0; i < Townnumber; i++)
            {
                int k = 0;
                for (int j = 1 + i; j <= TargetTownnumber; j++)
                {
                    if (Distance[k, j] != -1)
                    {
                        Result[i] = Result[i] + Distance[k, j];
                        k = j;
                    }
                }
                if (i > 0)
                {
                    if (Result[0] <= Result[i])
                    {
                        Result[0] = Result[0];
                    }
                    if (Result[i] <= Result[0] && Result[i] != 0)
                    {
                        Result[0] = Result[i];
                    }
                }
            }
            result[0] =Distance[0, 2] + Distance[2, 5] + Distance[5, 4];
            result[1] =Distance[0, 1] + Distance[1, 3] + Distance[3, 4];
            result[2] =Distance[0, 5] + Distance[5, 4];
            result[3] =Distance[0, 5] + Distance[5, 3] + Distance[3, 1] + Distance[1, 2] + Distance[2, 3] + Distance[3, 4];
            for (int l = 0; l < TargetTownnumber; l++)
            {
                if (Result[0] <= result[l])
                {
                    Result[0] = Result[0];
                }
                else
                {
                    Result[0] = result[l];
                }
            }
            Console.WriteLine(Result[0]);
        }
    }
}
