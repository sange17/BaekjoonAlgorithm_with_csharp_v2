namespace BaekjoonAlgorithm_with_csharp_dotnet6.Greedy
{
    class Greedy_30805
    {
        public void solve()
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] A = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            int M = int.Parse(Console.ReadLine()!);
            int[] B = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            // dp[i, j]는 A[0..i-1], B[0..j-1] 까지의 공통 부분 수열 중 사전순 가장 나중인 것
            List<int>[,] dp = new List<int>[N + 1, M + 1];

            for (int i = 0; i <= N; i++)
            {
                for (int j = 0; j <= M; j++)
                {
                    dp[i, j] = new List<int>();
                }
            }

            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= M; j++)
                {
                    if (A[i - 1] == B[j - 1])
                    {
                        var candidate = new List<int>(dp[i - 1, j - 1]);
                        candidate.Add(A[i - 1]);
                        dp[i, j] = candidate;
                    }
                    else
                    {
                        var first = dp[i - 1, j];
                        var second = dp[i, j - 1];
                        dp[i, j] = CompareLex(first, second) > 0 ? first : second;
                    }
                }
            }

            var result = dp[N, M];
            Console.WriteLine(result.Count);
            if (result.Count > 0)
            {
                Console.WriteLine(string.Join(" ", result));
            }
        }

        // 리스트 a가 b보다 사전순으로 나중이면 양수, 같으면 0, 앞서면 음수
        static int CompareLex(List<int> a, List<int> b)
        {
            int len = Math.Min(a.Count, b.Count);
            for (int i = 0; i < len; i++)
            {
                if (a[i] != b[i])
                    return a[i] - b[i];
            }
            return a.Count - b.Count;
        }
    }
}
