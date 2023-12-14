using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_27434
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine());

            Console.WriteLine(factorial(N));
        }

        static long factorial(int n)
        {
            if (n <= 0) return 1;

            return n * factorial(n - 1);
        }
    }
}
