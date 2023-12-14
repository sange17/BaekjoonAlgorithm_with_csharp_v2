using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_20833
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine());

            long sum = 0;

            for(int i = 1 ; i <= n; i++)
            {
                sum += i * i * i;
            }

            Console.Write(sum);
        }
    }
}
