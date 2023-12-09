using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Geometry
{
    class Geometry_01027
    {
        static int[] map;
        static int N;

        static int Count(int idx)
        {
            int cnt = 0;
            double tmp = 0;
            double slope = 0;

            for (int i = idx - 1; i >= 0; i--)
            {
                slope = (double)(map[idx] - map[i]) / (idx - i);

                if(i == idx - 1 || tmp > slope)
                {
                    cnt++;
                    tmp = slope;
                }
            }

            for(int i = idx + 1; i < N; i++)
            {
                slope = (double)(map[idx] - map[i]) / (idx - i);

                if(i == idx + 1 || tmp < slope)
                {
                    cnt++;
                    tmp = slope;
                }
            }

            return cnt;
        }

        public void solve()
        {
            N = Int32.Parse(Console.ReadLine());
            map = new int[N];

            string[] line = Console.ReadLine().Split(' ');
            for(int i = 0; i < N; i++)
            {
                map[i] = Int32.Parse(line[i]);
            }

            int ans = 0;
            for (int i = 0; i < N; i++)
            {
                ans = Math.Max(ans, Count(i));
            }

            Console.Write(ans);
        }
    }
}
