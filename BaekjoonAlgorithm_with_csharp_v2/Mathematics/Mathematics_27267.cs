using System;

namespace BaekjoonAlgorithm_with_csharp_v2.Mathematics
{
    class Mathematics_27267
    {
        public void solve()
        {
            string line = Console.ReadLine();

            int a = Int32.Parse(line.Split(' ')[0]);
            int b = Int32.Parse(line.Split(' ')[1]);
            int c = Int32.Parse(line.Split(' ')[2]);
            int d = Int32.Parse(line.Split(' ')[3]);

            if (a * b > c * d) Console.WriteLine('M');
            else if (a * b < c * d) Console.WriteLine('P');
            else if (a * b == c * d) Console.WriteLine('E');
        }
    }
}
