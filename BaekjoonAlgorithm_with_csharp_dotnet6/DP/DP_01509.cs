using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.DP
{
    class DP_01509
    {
        static bool[,] palindrome;
        static int[] dp;
        static bool flag = false;
        static int s = 0;
        static int e = 0;

        static void checkPalindrome(string str, int len)
        {
            for(int start = 1; start <= len; start++)
            {
                for(int end = start; end<= len; end++)
                {
                    flag = true;

                    s = start - 1;
                    e = end - 1;
                    while(s <= e)
                    {
                        if (str[s++] != str[e--])
                        {
                            flag = false;
                            break;
                        }
                    }

                    if (flag) palindrome[start, end] = true;
                }
            }
        }

        public void solve()
        {
            string str = Console.ReadLine();
            int len = str.Length;
            palindrome = new bool[len + 1, len + 1];
            dp = new int[len + 1];

            for(int i = 1; i <= len; i++)
            {
                dp[i] = Int32.MaxValue;
            }

            checkPalindrome(str, len);

            for(int i = 1; i <= len; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    if (palindrome[j,i])
                    {
                        dp[i] = Math.Min(dp[i], dp[j - 1] + 1);
                    }
                }
            }

            Console.WriteLine(dp[len]);
        }
    }
}
