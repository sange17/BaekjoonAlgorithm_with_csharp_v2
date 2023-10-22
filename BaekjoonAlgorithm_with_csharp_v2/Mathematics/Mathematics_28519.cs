using System;

namespace BaekjoonAlgorithm_with_csharp_v2.Mathematics
{
    class Mathematics_28519
    {
        public void solve()
        {
            string line = Console.ReadLine();

            long X = long.Parse(line.Split(' ')[0]);
            long Y = long.Parse(line.Split(' ')[1]);
            long max = Math.Max(X, Y);
            long min = Math.Min(X, Y);

            if(max == min)
            {
                Console.WriteLine(min * 2);
            }
            else
            {
                Console.WriteLine(min * 2 + 1);
            }
        }
    }
}
