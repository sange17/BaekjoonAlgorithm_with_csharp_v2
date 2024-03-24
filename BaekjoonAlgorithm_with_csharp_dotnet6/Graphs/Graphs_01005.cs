namespace BaekjoonAlgorithm_with_csharp_dotnet6.Graphs
{
    class Graphs_01005
    {
        static int[] calcTopologicalSort(int[] time, bool[,] matrix, int[] link)
        {
            Queue<int> queue = new Queue<int>();
            int[] result = new int[link.Length];

            for(int i = 1; i< link.Length; i++)
            {
                if (link[i] == 0)
                {
                    result[i] = time[i];
                    queue.Enqueue(i);
                }
            }

            while(queue.Count > 0)
            {
                int prev = queue.Dequeue();

                for(int i = 1; i < link.Length; i++)
                {
                    if (matrix[prev, i])
                    {
                        result[i] = Math.Max(result[i], result[prev] + time[i]);

                        --link[i];

                        if (link[i] == 0)
                        {
                            queue.Enqueue(i);
                        }
                    }
                }
            }

            return result;
        }

        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int T = Int32.Parse(sr.ReadLine());

            string line = string.Empty;
            for(int i = 0; i < T; i++)
            {
                line = sr.ReadLine();
                int N = Int32.Parse(line.Split(" ")[0]);
                int K = Int32.Parse(line.Split(" ")[1]);
                int[] time = new int[N + 1];
                bool[,] matrix = new bool[N + 1, N + 1];
                int[] link = new int[N + 1];

                line = sr.ReadLine();
                for(int j = 1; j < N + 1; j++)
                {
                    time[j] = Int32.Parse(line.Split(" ")[j - 1]);
                }

                for(int j = 0; j < K; j++)
                {
                    line = sr.ReadLine();
                    int X = Int32.Parse(line.Split(" ")[0]);
                    int Y = Int32.Parse(line.Split(" ")[1]);

                    matrix[X, Y] = true;
                    link[Y]++;
                }

                int W = Int32.Parse(sr.ReadLine());

                sw.WriteLine(calcTopologicalSort(time, matrix, link)[W]);
            }

            sr.Close();
            sw.Close();
        }
    }
}
