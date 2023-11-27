using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.DP
{
    class DP_01562
    {
        static int MOD = 1000000000;

        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine());

            long[,,] dp = new long[N + 1, 11, 1 << 10];

            for(int i = 1; i < 10; i++)
            {
                dp[1, i, 1 << i] = 1;
            }

            int bit = 0;
            for(int i = 2; i < N + 1; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    for(int k = 0; k < 1024; k++)
                    {
                        bit = k | (1 << j);
                        if(j == 0)
                        {
                            dp[i, j, bit] = (dp[i, j, bit] + dp[i - 1, j + 1, k]) % MOD;
                        }
                        else if(j == 9)
                        {
                            dp[i, j, bit] = (dp[i, j, bit] + dp[i - 1, j - 1, k]) % MOD;
                        }
                        else
                        {
                            dp[i, j, bit] = (dp[i, j, bit] + dp[i - 1, j + 1, k] + dp[i - 1, j - 1, k]) % MOD;
                        }
                    }
                }
            }

            long sum = 0;
            for(int i = 0; i < 10; i++)
            {
                sum = (sum + dp[N, i, 1023]) % MOD;
            }

            Console.Write(sum);
        }
    }
}
