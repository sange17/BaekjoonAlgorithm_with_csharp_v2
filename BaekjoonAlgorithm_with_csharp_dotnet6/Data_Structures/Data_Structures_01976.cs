using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Data_Structures
{
    class Data_Structures_01976
    {
        static int[] parent;

        static int find(int x)
        {
            if (x == parent[x])
                return x;

            return parent[x] = find(parent[x]);
        }

        static void union(int x, int y)
        {
            x = find(x);
            y = find(y);

            if(x != y)
            {
                if(x < y)
                    parent[y] = x;
                else
                    parent[x] = y;
            }
        }

        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int N = Int32.Parse(sr.ReadLine());
            int M = Int32.Parse(sr.ReadLine());

            parent = new int[N + 1];
            for(int i = 1; i <= N; i++)
                parent[i] = i;

            string[] lineArray;
            int temp = 0;
            for(int i  = 1; i <= N; i++)
            {
                lineArray = sr.ReadLine().Split(' ');
                for(int j = 1; j <= N; j++)
                {
                    temp = Int32.Parse(lineArray[j - 1]);

                    if (temp == 1)
                        union(i, j);
                }
            }

            lineArray = sr.ReadLine().Split(' ');
            int start = find(Int32.Parse(lineArray[0]));
            int now = 0;
            for(int i = 1; i < M; i++)
            {
                now = Int32.Parse(lineArray[i]);

                if(start != find(now))
                {
                    sw.WriteLine("NO");
                    sr.Close();
                    sw.Close();
                    return;
                }
            }

            sw.WriteLine("YES");
            sr.Close();
            sw.Close();
        }
    }
}
