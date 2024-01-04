using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Graphs
{
    class Graphs_13023
    {
        static bool status;
        static List<int>[] list;
        static bool[] check;

        static void dfs(int idx, int depth)
        {
            if (depth == 5)
            {
                status = true;
                return;
            }
            check[idx] = true;
            foreach(int next in list[idx])
            {
                if (!check[next])
                {
                    dfs(next, depth + 1);
                }
            }
            check[idx] = false;
        }

        public void solve()
        {
            string line = Console.ReadLine();

            int n = Int32.Parse(line.Split(' ')[0]);
            int m = Int32.Parse(line.Split(' ')[1]);

            list = new List<int>[n];
            for(int i = 0; i < n; i++)
            {
                list[i] = new List<int>();
            }

            int a = 0;
            int b = 0;
            for(int i = 0; i < m; i++)
            {
                line = Console.ReadLine();
                a = Int32.Parse(line.Split(' ')[0]);
                b = Int32.Parse(line.Split(' ')[1]);
                list[a].Add(b);
                list[b].Add(a);
            }

            status = false;
            for(int i = 0; i < n; i++)
            {
                check = new bool[n];
                dfs(i, 1);
                if(status)
                {
                    Console.Write(1);
                    return;
                }
            }
            Console.Write(0);
        }
    }
}
