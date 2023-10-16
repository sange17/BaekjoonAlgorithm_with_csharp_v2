using System;
using System.Collections.Generic;

namespace BaekjoonAlgorithm_with_csharp_v2.Graphs
{
    class Graphs_02638
    {
        static int[,] arr = new int[105, 105];
        static int[] dx = new int[] { 0, 0, -1, 1 };
        static int[] dy = new int[] { 1, -1, 0, 0 };
        static int n = 0;
        static int m = 0;
        static int ans = 0;
        static Queue<List<int>> queue = new Queue<List<int>>();

        static void dfs(int x, int y)
        {
            if(arr[x,y] == 0)
            {
                arr[x, y] = -1;
            }
            else
            {
                return;
            }

            for(int i = 0; i < 4; i++)
            {
                int X = x + dx[i];
                int Y = y + dy[i];

                if (X >= 1 && X <= n && Y >= 1 && Y <= m) dfs(X, Y);
            }
        }

        public void solve()
        {
            string line = Console.ReadLine();

            n = Int32.Parse(line.Split(' ')[0]);
            m = Int32.Parse(line.Split(' ')[1]);

            string[] lineArray = new string[m];
            for (int i = 1; i <= n; i++)
            {
                lineArray = Console.ReadLine().Split(' ');
                for(int j = 1; j <= m; j++)
                {
                    arr[i, j] = Int32.Parse(lineArray[j - 1]);
                }
            }

            dfs(1, 1);

            while(true)
            {
                for(int i = 1; i <= n; i++)
                {
                    for(int j = 1; j <= m; j++)
                    {
                        if(arr[i,j] == 1)
                        {
                            int count = 0;
                            for(int k = 0; k < 4; k++)
                            {
                                int X = i + dx[k];
                                int Y = j + dy[k];

                                if (arr[X, Y] == -1) count++;
                            }

                            if (count >= 2) queue.Enqueue(new List<int> { i, j });
                        }
                    }
                }

                if (queue.Count == 0) break;

                while(!(queue.Count == 0))
                {
                    int x = queue.Peek()[0];
                    int y = queue.Peek()[1];

                    queue.Dequeue();

                    arr[x, y] = -1;

                    for(int i = 0; i < 4; i++)
                    {
                        int X = x + dx[i];
                        int Y = y + dy[i];

                        if (arr[X, Y] == 0) dfs(X, Y);
                    }
                }

                ans++;
            }

            Console.WriteLine(ans);
        }
    }
}
