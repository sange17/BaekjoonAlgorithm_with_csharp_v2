using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Graphs
{
    class Graphs_11779
    {
        static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        static int N = 0;
        static int M = 0;
        static List<List<int>>[] array = new List<List<int>>[1002];
        static int[] value = new int[1002];
        static int[] prev_arr = new int[1002];

        static void dijkstra(int start)
        {
            for(int i = 1; i <= N; i++) value[i] = 2100000000;

            value[start] = 0;
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
            pq.Enqueue(0, start);

            int str = 0;
            int val = 0;
            int weight = 0;
            int dest = 0;

            while(pq.TryPeek(out int item, out int priority))
            {
                str = priority;
                val = -item;

                pq.Dequeue();

                if (val > value[str]) continue;

                for(int i = 0; i < array[str].Count; i++)
                {
                    weight = val + array[str][i][1];
                    dest = array[str][i][0];

                    if (value[dest] <= weight) continue;

                    prev_arr[dest] = str;
                    value[dest] = weight;
                    pq.Enqueue(-weight, dest);
                }
            }
        }

        public void solve()
        {
            N = Int32.Parse(sr.ReadLine());
            M = Int32.Parse(sr.ReadLine());

            string line = string.Empty;
            int str = 0;
            int dest = 0;
            int val = 0;

            for (int i = 0; i < 1002; i++) 
                array[i] = new List<List<int>>();

            for(int i = 0; i < M; i++)
            {
                line = sr.ReadLine();
                str = Int32.Parse(line.Split(' ')[0]);
                dest = Int32.Parse(line.Split(' ')[1]);
                val = Int32.Parse(line.Split(' ')[2]);

                array[str].Add(new List<int> { dest, val });
            }

            line = sr.ReadLine();
            int need_str = Int32.Parse(line.Split(' ')[0]);
            int need_dest = Int32.Parse(line.Split(' ')[1]);

            dijkstra(need_str);

            sw.WriteLine(value[need_dest]);

            List<int> list = new List<int>();

            list.Add(need_dest);
            int temp = prev_arr[need_dest];
            while(temp != need_str)
            {
                //Console.WriteLine(temp);
                list.Add(temp);
                temp = prev_arr[temp];
            }

            list.Add(need_str);

            sw.WriteLine(list.Count);
            for(int i = list.Count - 1; i >= 0; i--)
            {
                if(i > 0)
                {
                    sw.Write(list[i] + " ");
                }
                else
                {
                    sw.Write(list[i]);
                }
            }

            sr.Close();
            sw.Close();
        }
    }
}
