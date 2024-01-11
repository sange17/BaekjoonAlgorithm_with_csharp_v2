using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_11051
    {
        static int div = 10007;

        static int factorial(int N)
        {
            if(N <= 1) return 1;

            return (N * factorial(N - 1)) % div;
        }

        static int mod_inverse(int a, int p)
        {
            int ret = 1;
            while(p > 0)
            {
                if(p % 2 == 1)
                {
                    ret *= a;
                    p--;
                    ret %= div;
                }
                a *= a;
                a %= div;
                p >>= 1;
            }

            return ret;
        }

        public void solve()
        {
            string line = Console.ReadLine();
            int N = Int32.Parse(line.Split(' ')[0]);
            int K = Int32.Parse(line.Split(' ')[1]);

            Console.Write((factorial(N) * mod_inverse((factorial(N - K) * factorial(K)) % div, div - 2)) % div);
        }
    }
}
