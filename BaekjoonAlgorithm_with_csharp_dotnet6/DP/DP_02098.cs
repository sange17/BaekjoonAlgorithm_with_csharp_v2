namespace BaekjoonAlgorithm_with_csharp_dotnet6.DP
{
    class DP_02098
    {
        static int n = 0;
        static int statusFullBit = 0;
        static int INF = 987654321;
        static int[,] w;
        static int[,] dp;

        static int tsp(int x, int check)
        {
            if(check == statusFullBit)
            {
                if (w[x, 0] == 0) return INF;
                else return w[x, 0];
            }

            if (dp[x, check] != -1) return dp[x, check];

            dp[x, check] = INF;

            for(int i = 0; i < n; i++)
            {
                int next = check | (1 << i);

                if (w[x, i] == 0 || (check & (1<<i)) != 0) continue;

                dp[x, check] = Math.Min(dp[x, check], tsp(i, next) + w[x, i]);
            }

            return dp[x, check];
        }

        public void solve()
        {
            n = Int32.Parse(Console.ReadLine());
            statusFullBit = (1 << n) - 1;
            w = new int[n, n];
            dp = new int[n, statusFullBit];
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < statusFullBit; j++)
                {
                    dp[i, j] = -1;
                }
            }

            string[] array;
            for(int i = 0; i < n; i++)
            {
                array = Console.ReadLine().Split(" ");
                for(int j = 0; j < n; j++)
                {
                    w[i, j] = Int32.Parse(array[j]);
                }
            }

            Console.Write(tsp(0, 1));
        }
    }
}
