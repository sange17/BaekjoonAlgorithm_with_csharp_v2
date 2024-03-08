using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.DP
{
    class DP_11049
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine());
            int INF = int.MaxValue;
            int[] data = new int[n + 1];
            int[,] dp;

            string line;
            for(int i = 0; i < n; i++)
            {
                line = Console.ReadLine();
                int a = Int32.Parse(line.Split(" ")[0]);
                int b = Int32.Parse(line.Split(" ")[1]);
                data[i] = a;
                data[i + 1] = b;
            }

            dp = new int[n, n];

            for(int i = 2; i < n + 1; i++)
            {
                for (int j = 0; j < n - i + 1; j++)
                {
                    dp[j, j + i - 1] = INF;
                    for(int k = j; k < j + i - 1; k++)
                    {
                        int value = dp[j, k] + dp[k + 1, j + i - 1] + (data[j] * data[k + 1] * data[j + i]);
                        dp[j, j + i - 1] = Math.Min(dp[j, j + i - 1], value);
                    }
                }
            }

            Console.Write(dp[0, n - 1]);
        }
    }
}
