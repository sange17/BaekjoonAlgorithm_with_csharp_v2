using System.Collections;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Data_Structures
{
    class Data_Structures_11438
    {
        static int N = 0;
        static int M = 0;
        static int K = 0;
        static int[] depth;
        static int[,] parent;
        static ArrayList[] tree;

        static void dfs(int id, int cnt)
        {
            depth[id] = cnt;

            int len = tree[id].Count;
            for(int i = 0; i < len; i++)
            {
                int next = (int)tree[id][i];

                if (depth[next] == 0)
                {
                    dfs(next, cnt + 1);
                    parent[0, next] = id;
                }
            }
            return;
        }

        static void fillParent()
        {
            for(int i = 1; i <= K; i++)
            {
                for(int j = 1; j <= N; j++)
                {
                    parent[i, j] = parent[i - 1, parent[i - 1, j]];
                }
            }
        }

        static int lca(int a, int b)
        {
            if (depth[a] < depth[b])
            {
                int tmp = a;
                a = b;
                b = tmp;
            }

            for(int i = K; i >= 0; i--)
            {
                if(Math.Pow(2, i) <= depth[a] - depth[b])
                {
                    a = parent[i, a];
                }
            }

            if (a == b) return a;

            for(int i = K; i >= 0; i--)
            {
                if (parent[i,a] != parent[i,b])
                {
                    a = parent[i, a];
                    b = parent[i, b];
                }
            }

            return parent[0, a];
        }

        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            N = Int32.Parse(sr.ReadLine());
            K = -1;
            for (int i = 1; i <= N; i *= 2) K++;

            depth = new int[N + 1];
            parent = new int[K + 1, N + 1];

            tree = new ArrayList[N + 1];
            for(int i = 1; i <= N; i++)
            {
                tree[i] = new ArrayList();
            }

            int a = 0;
            int b = 0;
            string line = string.Empty;
            for(int i = 1; i <= N - 1; i++)
            {
                line = sr.ReadLine();
                a = Int32.Parse(line.Split(" ")[0]);
                b = Int32.Parse(line.Split(" ")[1]);
                tree[a].Add(b);
                tree[b].Add(a);
            }

            dfs(1, 1);

            fillParent();

            M = Int32.Parse(sr.ReadLine());
            for(int i = 1; i <= M; i++)
            {
                line = sr.ReadLine();
                a = Int32.Parse(line.Split(" ")[0]);
                b = Int32.Parse(line.Split(" ")[1]);

                sw.WriteLine(lca(a, b));
            }

            sr.Close();
            sw.Close();
        }
    }
}
