using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Graphs
{
    class Graphs_14938
    {
        static int ans = 0;
        static int n = 0;
        static int m = 0;
        static int r = 0;
        static int a = 0;
        static int b = 0;
        static int l;
        static int[] local = new int[101];
        static int[] d = new int[101];
        static List<List<int>>[] v = new List<List<int>>[101];
        
        static void dijkstra(int start)
        {
            int cnt = 0;
            Queue<int> q = new Queue<int>();
            for(int i = 1; i <= n; i++)
            {
                d[i] = 1000000000;
            }

            d[start] = 0;
            q.Enqueue(start);

            while(q.Count > 0)
            {
                int node = q.Peek();
                int dist = d[node];
                q.Dequeue();

                for(int i = 0; i < v[node].Count; i++)
                {
                    int next_node = v[node][i][0];
                    int next_dist = v[node][i][1];

                    if (d[next_node] > dist + next_dist)
                    {
                        d[next_node] = dist + next_dist;
                        q.Enqueue(next_node);
                    }
                }
            }

            for(int i = 1; i <= n; i++)
            {
                if (d[i] <= m) cnt += local[i];
            }

            ans = Math.Max(ans, cnt);
        }

        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string line = sr.ReadLine();
            n = Int32.Parse(line.Split(' ')[0]);
            m = Int32.Parse(line.Split(' ')[1]);
            r = Int32.Parse(line.Split(' ')[2]);

            // 지역별 아이템 갯수 저장
            line = sr.ReadLine();
            for (int i = 1; i <= n; i++)
            {
                local[i] = Int32.Parse(line.Split(' ')[i - 1]);
            }

            // C#은 C++과는 다르게 2차원 list를 초기화하여 사용하여야 NullException 오류가 발생하지 않는다.
            for(int i = 0; i < 101; i++)
            {
                v[i] = new List<List<int>>();
            }

            // 길과 길 사이의 거리 저장
            for (int i = 0; i < r; i++)
            {
                line = sr.ReadLine();
                a = Int32.Parse(line.Split(' ')[0]);
                b = Int32.Parse(line.Split(' ')[1]);
                l = Int32.Parse(line.Split(' ')[2]);


                v[a].Add(new List<int> { b, l });
                v[b].Add(new List<int> { a, l });
            }

            for(int i = 1; i <= n; i++)
            {
                dijkstra(i);
            }

            sw.Write(ans);

            sr.Close();
            sw.Close();
        }
    }
}
