namespace BaekjoonAlgorithm_with_csharp_dotnet6.DP
{
    class DP_14501
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine()!);
            List<Tuple<int, int>> list = new List<Tuple<int, int>>();
            int[] dp = new int[N + 1];
            for (int i = 0; i < N; i++)
            {
                int[] inputs = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
                list.Add(new Tuple<int, int>(inputs[0], inputs[1]));
            }

            for (int i = 0; i < N; i++)
            {
                if (dp[i] > dp[i + 1])
                    dp[i + 1] = dp[i];

                if (i + list[i].Item1 < N + 1)
                    if (dp[i] + list[i].Item2 > dp[i + list[i].Item1])
                        dp[i + list[i].Item1] = dp[i] + list[i].Item2;
            }

            Console.Write(dp[N]);
        }
    }
}
