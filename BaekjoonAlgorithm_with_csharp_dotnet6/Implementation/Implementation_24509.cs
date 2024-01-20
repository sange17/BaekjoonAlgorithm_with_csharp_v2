using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_24509
    {
        static int N = 0;
        static int[,] students;
        static bool[] chk;

        public static void find(int idx)
        {
            int max = -1;
            int ans = 0;
            for(int i = 1; i <= N; i++)
            {
                if (!chk[i] && students[i, idx] > max)
                {
                    ans = i;
                    max = students[i, idx];
                }
            }
            chk[ans] = true;
            Console.Write(ans + " ");
        }

        public void solve()
        {
            N = Int32.Parse(Console.ReadLine());
            students = new int[N + 1, 4];
            chk = new bool[N + 1];

            string line = string.Empty;
            for(int i = 0; i < N; i++)
            {
                line = Console.ReadLine();
                int idx = Int32.Parse(line.Split(" ")[0]);
                for(int j = 0; j < 4; j++)
                {
                    students[idx, j] = Int32.Parse(line.Split(" ")[j + 1]);
                }
            }

            for (int i = 0; i < 4; i++)
                find(i);
        }
    }
}
