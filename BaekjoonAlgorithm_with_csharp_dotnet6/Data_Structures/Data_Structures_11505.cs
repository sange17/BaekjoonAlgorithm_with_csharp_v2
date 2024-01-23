using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Data_Structures
{
    class Data_Structures_11505
    {
        static int MOD = 1000000007;
        static long[] array;
        static long[] tree;

        public static long init(int start, int end, int node)
        {
            if(start == end)
                return tree[node] = array[start];

            int mid = (start + end) / 2;

            return tree[node] = (init(start, mid, node * 2) * init(mid + 1, end, node * 2 + 1)) % MOD;
        }

        public static long mul(int start, int end, int node, int left, int right)
        {
            if (left > end || right < start)
                return 1;

            if (left <= start && end <= right)
                return tree[node];

            int mid = (start + end) / 2;
            return (mul(start, mid, node * 2, left, right) * mul(mid + 1, end, node * 2 + 1, left, right)) % MOD;
        }

        public static long update(int start, int end, int node, int idx, long val)
        {
            if (idx < start || idx > end)
                return tree[node];

            if (start == end)
                return tree[node] = val;

            int mid = (start + end) / 2;
            return tree[node] = (update(start, mid, node * 2, idx, val) * update(mid + 1, end, node * 2 + 1, idx, val)) % MOD;
        }

        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string line = sr.ReadLine();
            int N = Int32.Parse(line.Split(" ")[0]);
            int M = Int32.Parse(line.Split(" ")[1]);
            int K = Int32.Parse(line.Split(" ")[2]);

            array = new long[N + 1];
            for(int i = 1; i <= N; i++)
            {
                array[i] = long.Parse(sr.ReadLine());
            }

            tree = new long[N * 4];

            init(1, N, 1);

            for(int i = 0; i < M + K; i++)
            {
                line = sr.ReadLine();
                int a = Int32.Parse(line.Split(" ")[0]);
                int b = Int32.Parse(line.Split(" ")[1]);
                long c = long.Parse(line.Split(" ")[2]);

                if(a == 1)
                {
                    array[b] = c;
                    update(1, N, 1, b, c);
                }
                else if(a == 2)
                {
                    sw.WriteLine(mul(1, N, 1, b, (int) c));
                }
            }

            sr.Close();
            sw.Close();
        }
    }
}
