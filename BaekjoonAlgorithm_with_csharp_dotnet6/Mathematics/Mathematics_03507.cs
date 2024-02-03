using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_03507
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine());

            if (N > 198) Console.WriteLine(0);
            else Console.WriteLine(99 - (N - 99) + 1);
        }
    }
}
