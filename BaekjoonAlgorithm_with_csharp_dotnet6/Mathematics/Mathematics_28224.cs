using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_28224
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum += Int32.Parse(Console.ReadLine());
            }

            Console.Write(sum);
        }
    }
}
