namespace BaekjoonAlgorithm_with_csharp_dotnet6.Graphs
{
    class Graphs_02623
    {
        static int n;
        static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        static List<int>[] list;
        static Queue<int> q;
        static int[] ranks;

        static void topologySort()
        {
            while(q.Count > 0)
            {
                int pos = q.Dequeue();
                sw.WriteLine(pos);
                foreach(int nxt in list[pos])
                {
                    ranks[nxt]--;
                    if (ranks[nxt] == 0)
                        q.Enqueue(nxt);
                }
            }
        }

        public void solve()
        {
            string line = sr.ReadLine();
            n = Int32.Parse(line.Split(" ")[0]);
            int m = Int32.Parse(line.Split(" ")[1]);

            list = new List<int>[n + 1];
            for (int i = 1; i < n + 1; i++)
            {
                list[i] = new List<int>();
            }

            ranks = new int[n + 1];
            for(int i = 0; i < m; i++)
            {
                string[] lines = sr.ReadLine().Split(" ");
                int size = Int32.Parse(lines[0]);
                for (int j = 2; j < size + 1; j++)
                {
                    int a = Int32.Parse(lines[j - 1]);
                    int b = Int32.Parse(lines[j]);

                    list[a].Add(b);
                    ranks[b]++;
                }
            }

            q = new Queue<int>();
            for (int i = 1; i < n + 1; i++)
            {
                if (ranks[i] == 0)
                    q.Enqueue(i);
            }

            topologySort();

            bool flag = false;
            for (int i = 1; i < n + 1; i++)
            {
                if (ranks[i] != 0)
                {
                    flag = true;
                    break;
                }
            }

            if (flag)
            {
                Console.WriteLine(0);
            }
            else
            {
                sr.Close();
                sw.Close();
            }
        }
    }
}
