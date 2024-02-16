using System;
using System.Numerics;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_27434
    {
        public static BigInteger fact(int a, int n)
        {
            BigInteger ret = new BigInteger(a);

            if (a < n)
            {
                int b = (a + n) / 2;
                ret = fact(a, b) * (fact(b + 1, n)); //두개로 나눠서 풀이
            }
            return ret;
        }

        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine());

            Console.WriteLine(fact(1, N));
        }
    }
}
