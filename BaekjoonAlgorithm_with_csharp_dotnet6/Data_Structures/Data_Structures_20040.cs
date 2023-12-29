using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Data_Structures
{
    class Data_Structures_20040
    {
        static int N = 0;
        static int M = 0;
        static int res = 0;
        static int[] parents;

        static int find(int n)
        {
            if(n == parents[n]) return n;
            return parents[n] = find(parents[n]);
        }

        static Boolean union(int a, int b)
        {
            int aRoot = find(a);
            int bRoot = find(b);
            if(aRoot == bRoot) return false;
            parents[bRoot] = aRoot;
            return true;
        }

        public void solve()
        {
            string line = Console.ReadLine();
            N = Int32.Parse(line.Split(' ')[0]);
            M = Int32.Parse(line.Split(' ')[1]);

            parents = new int[N];
            for(int i = 0; i < N; i++)
            {
                parents[i] = i;
            }

            int a = 0;
            int b = 0;
            for(int i = 1; i <= M; i++)
            {
                line = Console.ReadLine();
                a = Int32.Parse(line.Split(' ')[0]);
                b = Int32.Parse(line.Split(' ')[1]);
                if(!union(a,b))
                {
                    res = i;
                    break;
                }
            }

            Console.Write(res);
        }
    }
}
