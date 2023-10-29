using System;

namespace BaekjoonAlgorithm_with_csharp_v2.Mathematics
{
    class Mathematics_28352
    {
        public void solve()
        {
            long week = 1;
            int N = Int32.Parse(Console.ReadLine());

            for(int i = 1; i <= N; i++)
            {
                week = (week * i);
            }

            Console.WriteLine(week / 604800);
        }
    }
}
