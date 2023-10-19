using System;
using System.IO;

namespace BaekjoonAlgorithm_with_csharp_v2.Mathematics
{
    class Mathematics_10830
    {
        static int MOD = 1000;
        static int N = 0;

        static public int[,] multiply(int[,] o1, int[,] o2)
        {
            int[,] ret = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    for (int k = 0; k < N; k++)
                    {
                        ret[i, j] += o1[i, k] * o2[k, j];
                        ret[i, j] %= MOD;
                    }
                }
            }

            return ret;
        }

        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string line = Console.ReadLine();

            N = Int32.Parse(line.Split(' ')[0]);
            long B = long.Parse(line.Split(' ')[1]);

            int[,] origin = new int[N, N];
            int[,] result = new int[N, N];

            string[] array = new string[N];
            for(int i = 0; i < N; i++)
            {
                array = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    origin[i, j] = Int32.Parse(array[j]);
                }

                // 결과값을 담을 행렬(맨 처음 초기값은 단위행렬(I)로 초기화 해준다.)
                result[i, i] = 1;

            }

            while (B > 0)
            {
                // 지수가 홀수라면 origin 배열을 한 번 더 곱해준다.
                if (B % 2 == 1)
                {
                    result = multiply(result, origin);
                }
                origin = multiply(origin, origin);

                B /= 2;
            }

            for(int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    sw.Write(result[i, j] + " ");
                }
                sw.WriteLine();
            }

            sr.Close();
            sw.Close();
        }
    }
}
