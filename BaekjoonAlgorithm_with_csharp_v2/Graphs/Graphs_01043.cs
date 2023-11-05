using System;
using System.Collections.Generic;
using System.IO;

namespace BaekjoonAlgorithm_with_csharp_v2.Graphs
{
    class Graphs_01043
    {
        static int[] parents;
        static List<int> eList;

        static int find(int x)
        {
            if (parents[x] == x) return x;
            return find(parents[x]);
        }

        static void union(int x, int y)
        {
            int rx = find(x);
            int ry = find(y);
            if(eList.Contains(ry))
            {
                int tmp = rx;
                rx = ry;
                ry = tmp;
            }

            parents[ry] = rx;
        }

        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string line = sr.ReadLine();
            int n = Int32.Parse(line.Split(' ')[0]);
            int m = Int32.Parse(line.Split(' ')[1]);

            parents = new int[n + 1];
            for(int i = 1; i < n + 1; i++)
            {
                parents[i] = i;
            }

            line = sr.ReadLine();
            int en = Int32.Parse(line.Split(' ')[0]);
            eList = new List<int>();
            
            if(en == 0)
            {
                sw.WriteLine(m);
                return;
            }
            else
            {
                for(int i = 0; i < en; i++)
                {
                    eList.Add(Int32.Parse(line.Split(' ')[i]));
                }
            }

            List<int>[] partyList = new List<int>[m];
            for(int i = 0; i < m; i++)
            {
                partyList[i] = new List<int>();
            }

            for(int i = 0; i < m; i++)
            {
                line = sr.ReadLine();
                int pn = Int32.Parse(line.Split(' ')[0]);

                int x = Int32.Parse(line.Split(' ')[1]);
                partyList[i].Add(x);
                for(int j = 1; j < pn; j++)
                {
                    int y = Int32.Parse(line.Split(' ')[j]);
                    union(x, y);
                    partyList[i].Add(y);
                }
            }

            int count = 0;
            for(int i = 0; i < m; i++)
            {
                Boolean flag = true;
                foreach(int num in partyList[i])
                {
                    if(eList.Contains(find(parents[num])))
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag) count++;
            }

            sw.WriteLine(count);

            sr.Close();
            sw.Close();
        }
    }
}
