using System;
using System.Collections.Generic;

namespace BaekjoonAlgorithm_with_csharp_v2.Graphs
{
    class Graphs_12851
    {
        static int N = 0;
        static int K = 0;
        static int[] time = new int[100001];
        static int minTime = 987654321;
        static int count = 0;

        static void bfs()
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(N);
            time[N] = 1;

            int now = 0;
            int next = 0;
            while (queue.Count != 0)
            {
                now = queue.Dequeue();

                if (minTime < time[now]) return;

                for(int i = 0; i < 3; i++)
                {
                    if (i == 0) next = now + 1;
                    else if (i == 1) next = now - 1;
                    else next = now * 2;

                    if (next < 0 || next > 100000) continue;

                    if(next == K)
                    {
                        minTime = time[now];
                        count++;
                    }

                    if(time[next] == 0 || time[next] == time[now] + 1)
                    {
                        queue.Enqueue(next);
                        time[next] = time[now] + 1;
                    }
                }
            }
        }

        public void solve()
        {
            string line = Console.ReadLine();

            N = Int32.Parse(line.Split(' ')[0]);
            K = Int32.Parse(line.Split(' ')[1]);

            if(N >= K)
            {
                Console.WriteLine((N - K) + "\n1");
                return;
            }

            bfs();

            Console.WriteLine(minTime + "\n" + count);
        }
    }
}
