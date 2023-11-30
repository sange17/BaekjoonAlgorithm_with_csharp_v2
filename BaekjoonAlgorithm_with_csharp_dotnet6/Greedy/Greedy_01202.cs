using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Greedy
{
    class Greedy_01202
    {
        static int N = 0;
        static int K = 0;
        static int M = 0;
        static int V = 0;
        static int C = 0;

        List<int> weight = new List<int>();
        List<List<int>> jew = new List<List<int>>();

        public void solve()
        {
            string line = Console.ReadLine();
            N = int.Parse(line.Split(' ')[0]);
            K = int.Parse(line.Split(' ')[1]);
            for(int i = 0; i < N; i++)
            {
                line = Console.ReadLine();
                M = Int32.Parse(line.Split(' ')[0]);
                V = Int32.Parse(line.Split(' ')[1]);
                jew.Add(new List<int> { M, V });
            }

            for(int i = 0; i < K; i++)
            {
                C = Int32.Parse(Console.ReadLine());
                weight.Add(C);
            }

            jew.Sort();
            weight.Sort();

            long result = 0;
            int j = 0;
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();

            for(int i = 0; i < K; i++)
            {
                while(j < N)
                {
                    if (jew[j][0] <= weight[i])
                    {
                        pq.Enqueue(i, jew[j][1]);
                        j++;
                    }
                    else break;
                }

                if(pq.Count > 0)
                {
                    result += pq.Peek();
                    pq.Dequeue();
                }
            }

            Console.Write(result);
        }
    }
}
