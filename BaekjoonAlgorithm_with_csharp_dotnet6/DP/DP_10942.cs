using System.Text;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.DP
{
    class DP_10942
    {
        static bool[,] dp;

        static void solution(int[] array, int n)
        {
            for(int i = 1; i <= n; i++)
                dp[i, i] = true;

            for (int i = 1; i <=  n - 1; i++)
                if (array[i] == array[i + 1])
                    dp[i, i + 1] = true;

            for(int i = 2; i < n; i++)
                for(int j = 1; j <= n - i; j++)
                    if (array[j] == array[j + i] && dp[j + 1, j + i - 1])
                        dp[j, j + i] = true;
        }

        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine());
            int[] array = new int[n + 1];
            dp = new bool[n + 1, n + 1];

            string[] strings = Console.ReadLine().Split(" ");
            for(int i = 1; i <= n; i++)
            {
                array[i] = Int32.Parse(strings[i - 1]);
            }

            solution(array, n);
            int m = Int32.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            string line = string.Empty;
            for(int i = 0; i < m; i++)
            {
                line = Console.ReadLine();
                int start = Int32.Parse(line.Split(" ")[0]);
                int end = Int32.Parse(line.Split(" ")[1]);

                if (dp[start, end]) sb.Append("1\n");
                else sb.Append("0\n");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
