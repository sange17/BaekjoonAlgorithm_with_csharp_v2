using System;
using System.Collections.Generic;
using System.IO;

namespace BaekjoonAlgorithm_with_csharp_v2.Graphs
{
    class Graphs_01043
    {
        static int[] parent;

        public int find(int idx)
        {
            if (parent[idx] == idx) return idx;
            parent[idx] = find(parent[idx]);
            return parent[idx];
        }

        public void union(int a, int b)
        {
            int parent_b = find(b);
            parent[parent_b] = a;       // b의 parent를 a로 변경
        }

        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string[] inputs = sr.ReadLine().Split(' ');

            int n = Int32.Parse(inputs[0]);
            int m = Int32.Parse(inputs[1]);

            bool[] people_know = new bool[n + 1];   // 알고있으면 T, 아니면 F

            HashSet<int>[] parties = new HashSet<int>[m + 1];
            for(int i = 1; i <= m; i++)
            {
                parties[i] = new HashSet<int>();
            }

            inputs = sr.ReadLine().Split(' ');
            int know_num = Int32.Parse(inputs[0]);

            // 진실을 아는 사람은 T
            int tmp = 0;
            for(int i = 1; i <= know_num; i++)
            {
                tmp = Int32.Parse(inputs[i]);
                people_know[tmp] = true;
            }

            parent = new int[n + 1];
            for(int i = 1; i <= n; i++)
            {
                parent[i] = i;
            }

            // party number
            for(int p = 1; p <= m; p++)
            {
                inputs = sr.ReadLine().Split(' ');
                int party_num = Int32.Parse(inputs[0]); // 파티에 오는 사람 수

                if(party_num <= 1)
                {
                    parties[p].Add(Int32.Parse(inputs[1]));
                    continue;
                }

                // 연관 관계 이어줌
                int a = 0;
                int b = 0;
                for(int j = 1; j < party_num; j++)
                {
                    a = Int32.Parse(inputs[j]);
                    b = Int32.Parse(inputs[j + 1]);
                    if(find(a) != find(b))
                    {
                        union(a, b);
                    }

                    parties[p].Add(a);      // 파티에 참여하는 사람 저장
                    parties[p].Add(b);
                }
            }

            // 진실을 아는 사람과 연관 관계 있음 => people_know[i] T로 변경
            bool[] visited = new bool[n + 1];
            for(int i = 1; i <= n; i++)
            {
                if(people_know[i] && !visited[i])
                {
                    int root = find(i);
                    for(int j = 1; j <= n; j++)
                    {
                        if(find(j) == root)
                        {
                            people_know[j] = true;
                            visited[j] = true;
                        }
                    }
                }
            }

            // 모든 파티 참석자가 F여야 과장된 얘기를 할 수 있음
            int result = 0;
            for(int i = 1; i <= m; i++)
            {
                bool flag = false;
                foreach(int person in parties[i])
                {
                    if(people_know[person])
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag) result++;
            }

            Console.WriteLine(result);
        }
    }
}
