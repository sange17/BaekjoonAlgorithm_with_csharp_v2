using System;

namespace BaekjoonAlgorithm_with_csharp_v2.Mathematics
{
    class Mathematics_28648
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine());

            int min = Int32.MaxValue;
            string line = string.Empty;
            int a = 0;
            int b = 0;
            for(int i = 0; i < N; i++)
            {
                line = Console.ReadLine();
                a = Int32.Parse(line.Split(' ')[0]);
                b = Int32.Parse(line.Split(' ')[1]);

                if (a + b < min) min = a + b;
            }

            Console.WriteLine(min);
        }
    }
}
