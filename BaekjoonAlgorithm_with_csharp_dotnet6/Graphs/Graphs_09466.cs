namespace BaekjoonAlgorithm_with_csharp_dotnet6.Graphs
{
    class Graphs_09466
    {
        static int T, N, res;
        static int[] arr;
        static bool[] visited, done;

        static void dfs(int idx)
        {
            if (done[idx])return;
            if (visited[idx])
            {
                done[idx] = true;
                res++;
            }
            visited[idx] = true;
            dfs(arr[idx]);
            done[idx] = true;
            visited[idx] = false;
        }

        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            T = Int32.Parse(sr.ReadLine());
            for (int t = 1; t <= T; t++)
            {
                N = Int32.Parse(sr.ReadLine());
                res = 0;
                arr = new int[N + 1];
                done = new bool[N + 1];
                visited = new bool[N + 1];
                string[] strs = sr.ReadLine().Split(" ");
                for (int n = 1; n <= N; n++)
                    arr[n] = Int32.Parse(strs[n - 1]);
                
                for (int i = 1; i <= N; i++)
                {
                    if (done[i]) continue;
                    dfs(i);
                }

                sw.WriteLine(N - res);
            }

            sr.Close();
            sw.Close();
        }
    }
}
