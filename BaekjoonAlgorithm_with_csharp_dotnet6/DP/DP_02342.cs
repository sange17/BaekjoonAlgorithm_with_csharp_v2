namespace BaekjoonAlgorithm_with_csharp_dotnet6.DP
{
    class DP_02342
    {
        static int[] move;
        static int[,,] dp;

        static int calc(int i, int j)
        {
            int ret = 0;
            if (i == 0) ret = 2;
            else if (i == j) ret = 1;
            else if (Math.Abs(i - j) == 2) ret = 4;
            else ret = 3;

            return ret;
        }

        static int go(int idx, int left, int right)
        {
            if (idx == move.Length) return 0;
            if (dp[idx, left, right] != 0)
            {
                return dp[idx, left, right];
            }
            int leftFoot = go(idx + 1, move[idx], right) + calc(left, move[idx]);
            int rightFoot = go(idx + 1, left, move[idx]) + calc(right, move[idx]);
            dp[idx, left, right] = Math.Min(leftFoot, rightFoot);

            return dp[idx, left, right];
        }

        public void solve()
        {
            string[] line = Console.ReadLine().Split(" ");
            move = new int[line.Length - 1];
            for(int i = 0; i < line.Length - 1; i++) 
            {
                move[i] = Int32.Parse(line[i]);
            }

            dp = new int[line.Length, 5, 5];
            int ans = go(0, 0, 0);
            Console.Write(ans);
        }
    }
}
