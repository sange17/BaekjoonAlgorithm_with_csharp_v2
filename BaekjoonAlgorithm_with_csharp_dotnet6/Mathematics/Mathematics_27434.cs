using System;
using System.Numerics;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_27434
    {
        public void solve()
        {
            int n = int.Parse(Console.ReadLine()!);
            Console.Out.Write(FastFactorial(n));
        }

        static BigInteger FastFactorial(int n)
        {
            if (n < 2) return BigInteger.One;
            return Product(2, n);
        }

        static BigInteger Product(int low, int high)
        {
            if (low > high) return BigInteger.One;
            if (low == high) return new BigInteger(low);
            if (high - low == 1) return new BigInteger(low) * new BigInteger(high);
            int mid = (low + high) / 2;
            return Product(low, mid) * Product(mid + 1, high);
        }
    }
}
