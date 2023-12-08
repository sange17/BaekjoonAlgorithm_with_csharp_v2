using System;

namespace BaekjoonAlgorithm_with_v2.Mathematics
{
    class Mathematics_30007
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine());

            string line = string.Empty;
            int A = 0;
            int B = 0;
            int X = 0;

            for (int i = 0; i < N; i++)
            {
                line = Console.ReadLine();
                A = Int32.Parse(line.Split(' ')[0]);
                B = Int32.Parse(line.Split(' ')[1]);
                X = Int32.Parse(line.Split(' ')[2]);

                Console.WriteLine(A * (X - 1) + B);
            }
        }
    }
}
