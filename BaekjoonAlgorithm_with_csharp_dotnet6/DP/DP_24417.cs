using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.DP
{
    class DP_24417
    {
        static int MOD = 1000000007;
        public void solve()
        {
            int n = 0;
            int z = 0;
            int x = 1;
            int y = 1;
            n = Int32.Parse(Console.ReadLine());
            for(int i = 3; i <= n; i++)
            {
                z = y;
                y = (x + y) % MOD;
                x = z;
            }

            Console.Write(y + " " + (n - 2));
        }
    }
}
