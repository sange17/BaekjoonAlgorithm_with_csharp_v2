using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Data_Structures
{
    class Data_Structures_02042
    {
        static long[] array, tree;

        static long init(int start, int end, int node)
        {
            if (start == end) return tree[node] = array[start];

            int mid = (start + end) / 2;

            return tree[node] = init(start, mid, node * 2) + init(mid + 1, end, node * 2 + 1);
        }

        static long sum(int start, int end, int node, int left, int right)
        {
            if(left > end || right < start) return 0;

            if (left <= start && end <= right) return tree[node];

            int mid = (start + end) / 2;
            return sum(start, mid, node * 2, left, right) + sum(mid + 1, end, node * 2 + 1, left, right);
        }

        static void update(int start, int end, int node, int idx, long dif)
        {
            if (idx < start || idx > end) return;

            tree[node] += dif;
            if (start == end) return;

            int mid = (start + end) / 2;
            update(start, mid, node * 2, idx, dif);
            update(mid + 1, end, node * 2 + 1, idx, dif);
        }

        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string line = sr.ReadLine();
            int N = Int32.Parse(line.Split(' ')[0]);
            int M = Int32.Parse(line.Split(' ')[1]);
            int K = Int32.Parse(line.Split(' ')[2]);

            array = new long[N + 1];
            for(int i = 1; i <= N; i++)
            {
                array[i] = long.Parse(sr.ReadLine());
            }

            int k = (int)Math.Ceiling(Math.Log(N) / Math.Log(2)) + 1;
            int size = (int)Math.Pow(2, k);
            tree = new long[size];

            init(1, N, 1);

            int a = 0;
            int b = 0;
            long c = 0;
            long dif = 0;
            for(int i = 0; i < M + K; i++)
            {
                line = sr.ReadLine();

                a = Int32.Parse(line.Split(' ')[0]);
                b = Int32.Parse(line.Split(' ')[1]);
                c = long.Parse(line.Split(' ')[2]);

                if(a == 1)
                {
                    dif = c - array[b];
                    array[b] = c;
                    update(1, N, 1, b, dif);
                }
                else if(a == 2)
                {
                    sw.WriteLine(sum(1, N, 1, b, (int)c));
                }
            }

            sr.Close();
            sw.Close();
        }
    }
}
