using System;

namespace BaekjoonAlgorithm_with_csharp_v2.Mathematics
{
    class Mathematics_30017
    {
        public void solve()
        {
            string line = Console.ReadLine();
            int p = Int32.Parse(line.Split(' ')[0]);
            int c = Int32.Parse(line.Split(' ')[1]);

            if(p <= c)
            {
                Console.WriteLine(p + p - 1);
            }
            else if(p > c)
            {
                Console.WriteLine(c + c + 1);
            }
        }
    }
}
