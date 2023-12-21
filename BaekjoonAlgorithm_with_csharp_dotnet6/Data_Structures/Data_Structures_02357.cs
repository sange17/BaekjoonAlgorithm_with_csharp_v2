using System;
using System.Diagnostics;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Data_Structures
{
    class Data_Structures_02357
    {
        static int[] array;
        static int[] minTree;
        static int[] maxTree;

        // 각 구간 별로 최솟값을 저장.
        static int minInit(int start, int end, int node)
        {
            if(start == end)
            {
                return minTree[node] = array[start];
            }

            int mid = (start + end) / 2;
            return minTree[node] = Math.Min(minInit(start, mid, node * 2), minInit(mid + 1, end, node * 2 + 1));
        }

        // 각 구간 별로 최댓값을 저장.
        static int maxInit(int start, int end, int node)
        {
            if (start == end)
            {
                return maxTree[node] = array[start];
            }

            int mid = (start + end) / 2;
            return maxTree[node] = Math.Max(maxInit(start, mid, node * 2), maxInit(mid + 1, end, node * 2 + 1));
        }

        // left ~ right 범위 내에 최솟값을 찾음.
        static int minFind(int start, int end, int node, int left, int right)
        {
            // 범위를 벗어난 경우
            if (right < start || end < left)
            {
                return int.MaxValue;
            }

            // 범위 안에 있는 경우
            if(left <= start && end <= right)
            {
                return minTree[node];
            }

            int mid = (start + end) / 2;

            return Math.Min(minFind(start, mid, node * 2, left, right), minFind(mid + 1, end, node * 2 + 1, left, right));
        }

        // left ~ right 범위 내에 최댓값을 찾음.
        static int maxFind(int start, int end, int node, int left, int right)
        {
            // 범위를 벗어난 경우
            if (right < start || end < left)
            {
                return int.MinValue;
            }

            // 범위 안에 있는 경우
            if (left <= start && end <= right)
            {
                return maxTree[node];
            }

            int mid = (start + end) / 2;

            return Math.Max(maxFind(start, mid, node * 2, left, right), maxFind(mid + 1, end, node * 2 + 1, left, right));
        }

        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string line = sr.ReadLine();

            int N = Int32.Parse(line.Split(' ')[0]);
            int M = Int32.Parse(line.Split(' ')[1]);

            array = new int[N + 1];
            for(int i = 1; i <= N; i++)
            {
                array[i] = Int32.Parse(sr.ReadLine());
            }

            minTree = new int[N * 4];
            maxTree = new int[N * 4];

            minInit(1, N, 1);
            maxInit(1, N, 1);

            int left = 0;
            int right = 0;
            for(int i = 0; i < M; i++)
            {
                line = sr.ReadLine();

                left = Int32.Parse(line.Split(' ')[0]);
                right = Int32.Parse(line.Split(' ')[1]);

                sw.WriteLine(minFind(1, N, 1, left, right) + " " + maxFind(1, N, 1, left, right));
            }

            sr.Close();
            sw.Close();
        }
    }
}
