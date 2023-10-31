using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonAlgorithm_with_csharp_v2.DP
{
    class DP_11054
    {
        static int N;
        static int[] seq;
        static int[] r_dp;
        static int[] l_dp;

        static void LIS()
        {
            for(int i = 0; i < N; i++)
            {
                r_dp[i] = 1;

                // 0 ~ i 이전 원소를 탐색
                for(int j = 0; j < i; j++)
                {
                    // j번째 원소가 i번째 원소보다 작으면서 i번째 dp가 j번째 dp+1 값보다 작은 경우
                    if(seq[j] < seq[i] && r_dp[i] < r_dp[j] + 1)
                    {
                        r_dp[i] = r_dp[j] + 1;
                    }
                }
            }
        }

        static void LDS()
        {
            for(int i = N - 1; i >= 0; i--)
            {
                l_dp[i] = 1;

                for(int j = N - 1; j > i; j--)
                {
                    // i번째 원소가 j번째 원소보다 크면서 i번째 dp가 j번째 dp+1 값보다 작은 경우
                    if(seq[j] < seq[i] && l_dp[i] < l_dp[j] + 1)
                    {
                        l_dp[i] = l_dp[j] + 1;      // j번째 원소의 +1이 i번째 dp값이 됨
                    }
                }
            }
        }


        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            N = Int32.Parse(sr.ReadLine());

            r_dp = new int[N];      // LIS
            l_dp = new int[N];      // LDS
            seq = new int[N];

            string[] array = sr.ReadLine().Split(' ');

            for(int i = 0; i < N; i++)
            {
                seq[i] = Int32.Parse(array[i]);
            }

            LIS();
            LDS();

            int max = 0;
            for (int i = 0; i < N; i++)
            {
                if(max < r_dp[i] + l_dp[i])
                {
                    max = r_dp[i] + l_dp[i];
                }
            }

            Console.WriteLine(max - 1);
        }
    }
}
