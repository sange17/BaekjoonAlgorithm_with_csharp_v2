using System;

namespace BaekjoonAlgorithm_with_csharp_v2.Mathematics
{
    class Mathematics_30214
    {
        public void solve()
        {
            string line = Console.ReadLine();

            double s1 = double.Parse(line.Split(' ')[0]);
            double s2 = double.Parse(line.Split(' ')[1]);

            Console.WriteLine(s2 / 2.0 <= s1 ? "E" : "H");
        }
    }
}
