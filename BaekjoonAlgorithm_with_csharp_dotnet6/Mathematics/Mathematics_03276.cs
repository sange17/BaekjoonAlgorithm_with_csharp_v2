using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_03276
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine());

            int minCol = int.MaxValue;
            int minRow = int.MaxValue;
            int minSum = int.MaxValue;

            for(int i = 1; i <= N; i++)
            {
                int j = N % i == 0 ? N / i : N / i + 1;
                if(i + j < minSum)
                {
                    minSum = i + j;
                    minRow = i;
                    minCol = j;
                }
            }

            Console.Write(minRow + " " + minCol);
        }
    }
}
