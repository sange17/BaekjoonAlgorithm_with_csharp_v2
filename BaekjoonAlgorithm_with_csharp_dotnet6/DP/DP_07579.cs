using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.DP
{
    class DP_07579
    {
        public void solve()
        {
            string line = Console.ReadLine();
            int N = Int32.Parse(line.Split(" ")[0]);
            int M = Int32.Parse(line.Split(" ")[1]);
            int[] memory = new int[N];
            int[] cost = new int[N];
            int sum = 0;
            int[] dp;

            string[] array1 = Console.ReadLine().Split(" ");
            for(int i = 0; i < N; i++)
            {
                memory[i] = Int32.Parse(array1[i]);
            }

            string[] array2 = Console.ReadLine().Split(" ");
            for(int i = 0; i < N; i++)
            {
                cost[i] = Int32.Parse(array2[i]);
                sum += cost[i];
            }

            dp = new int[sum + 1];
            for(int i = 0; i < N; i++)
            {
                for(int j = sum; j >= cost[i]; j--)
                {
                    dp[j] = Math.Max(dp[j], dp[j - cost[i]] + memory[i]);
                }
            }
            
            for(int i = 0; i <= sum; i++)
            {
                if (dp[i] >= M)
                {
                    Console.Write(i);
                    break;
                }
            }
        }
    }
}
