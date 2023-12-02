using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Greedy
{
    class Greedy_01041
    {
        static int[] side = new int[6];
        static long[] totalSide = new long[3];
        static int[] min = new int[3];

        static void setMinIdx()
        {
            min[0] = Math.Min(side[0], side[5]);
            min[1] = Math.Min(side[1], side[4]);
            min[2] = Math.Min(side[2], side[3]);

            Array.Sort(min);
        }

        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine());
            string[] array = Console.ReadLine().Split(' ');

            for(int i = 0; i < 6; i++) side[i] = Int32.Parse(array[i]);

            setMinIdx();

            totalSide[0] = (long)4;
            totalSide[1] = (long)8 * (N - 2) + (long)4;
            totalSide[2] = (long)5 * (N - 2) * (N - 2) + (long)4 * (N - 2);

            if(N == 1)
            {
                Array.Sort(side);
                Console.Write(side[0] + side[1] + side[2] + side[3] + side[4]);
            }
            else
            {
                Console.Write(totalSide[0] * (min[0] + min[1] + min[2]) + totalSide[1] * (min[0] + min[1]) + totalSide[2] * min[0]);
            }
        }
    }
}
