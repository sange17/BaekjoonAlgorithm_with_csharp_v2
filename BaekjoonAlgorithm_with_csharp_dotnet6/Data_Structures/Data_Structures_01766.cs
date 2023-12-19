using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Data_Structures
{
    class Data_Structures_01766
    {
        static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        static int n = 0;
        static int m = 0;

        public void solve()
        {
            string line = sr.ReadLine();
            n = Int32.Parse(line.Split(' ')[0]);
            m = Int32.Parse(line.Split(' ')[1]);

            List<List<int>> list = new List<List<int>>();
            int[] indegree = new int[n + 1];

            for (int i = 0; i < n + 1; i++)
                list.Add(new List<int>());

            int v1 = 0;
            int v2 = 0;
            for (int i = 0; i < m; i++)
            {
                line = sr.ReadLine();

                v1 = Int32.Parse(line.Split(' ')[0]);
                v2 = Int32.Parse(line.Split(' ')[1]);

                list[v1].Add(v2);
                indegree[v2]++;
            }

            togologicalSort(indegree, list);

            sr.Close();
            sw.Close();
        }

        static void togologicalSort(int[] indegree, List<List<int>> list)
        {
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();

            for(int i = 1; i <= n; i++)
            {
                if (indegree[i] == 0)
                    pq.Enqueue(i, i);
            }

            int node = 0;
            while(pq.Count > 0)
            {
                node = pq.Dequeue();

                foreach(int i in list[node])
                {
                    indegree[i]--;

                    if (indegree[i] == 0)
                        pq.Enqueue(i, i);
                }

                sw.Write(node + " ");
            }
        }
    }
}
