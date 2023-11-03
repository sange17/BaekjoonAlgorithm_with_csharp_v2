using System;
using System.IO;

namespace BaekjoonAlgorithm_with_csharp_v2.Mathematics
{
    class Mathematics_13172
    {
        static int P = 1000000007;

        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int M = Int32.Parse(sr.ReadLine());
            long N = 1;
            long S = 0;

            string line = string.Empty;
            int n = 0;
            int s = 0;
            for(int i = 0; i < M; i++)
            {
                // sr과 Console.ReadLine()을 혼용해서 Segfault오류가 발생한다.
                line = sr.ReadLine();

                n = Int32.Parse(line.Split(' ')[0]);
                s = Int32.Parse(line.Split(' ')[1]);

                S = s * N + S * n;
                N *= n;

                S %= P;
                N %= P;
            }

            if (S % N != 0)
                sw.Write((search(N, P - 2) * S) % P + "");
            else
                sw.Write(S / N + "");

            sr.Close();
            sw.Close();
        }

        static long search(long N, int index)
        {
            if (index == 1)
                return N;

            long temp = search(N, index / 2);

            if (index % 2 == 1)
                return temp * temp % P * N % P;
            else
                return temp * temp % P;
        }
    }
}
