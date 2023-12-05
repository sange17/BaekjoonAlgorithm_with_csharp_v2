using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Greedy
{
    class Greedy_01080
    {
        static int row = 0;
        static int col = 0;
        static int[,] aArray;
        static int[,] bArray;
        static int count = 0;

        public void solve()
        {
            string line = Console.ReadLine();
            row = Int32.Parse(line.Split(' ')[0]);
            col = Int32.Parse(line.Split(' ')[1]);
            aArray = new int[row, col];
            bArray = new int[row, col];

            for(int i = 0; i < row; i++)
            {
                line = Console.ReadLine();
                for(int j = 0; j < col; j++)
                {
                    aArray[i, j] = line[j] - '0';
                }
            }

            for (int i = 0; i < row; i++)
            {
                line = Console.ReadLine();
                for (int j = 0; j < col; j++)
                {
                    bArray[i, j] = line[j] - '0';
                }
            }

            for(int i = 0; i < row - 2; i++)
            {
                for(int j = 0; j < col - 2; j++)
                {
                    if (aArray[i, j] != bArray[i, j])
                    {
                        change(i, j);
                        count++;
                    }
                }
            }

            int flag = 0;
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    if (aArray[i, j] == bArray[i, j])
                        flag++;
                }
            }

            if(flag == row * col)
                Console.Write(count);
            else
                Console.Write(-1);
        }

        static void change(int x, int y)
        {
            for(int i = x; i< x + 3; i++)
            {
                for(int j = y; j < y + 3; j++)
                {
                    aArray[i, j] = aArray[i, j] ^ 1;
                }
            }
        }
    }
}
