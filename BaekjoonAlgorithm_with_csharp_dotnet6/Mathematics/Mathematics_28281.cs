using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_28281
    {
        public void solve()
        {
            string line = Console.ReadLine();
            int N = Int32.Parse(line.Split(' ')[0]);
            int X = Int32.Parse(line.Split(' ')[1]);

            string[] array1 = Console.ReadLine().Split(' ');
            int[] array2 = new int[N];

            for(int i = 0; i < N; i++)
            {
                array2[i] = Int32.Parse(array1[i]);
            }

            int min = Int32.MaxValue;
            int value = 0;
            for(int i = 0; i < N - 1; i++)
            {
                value = (array2[i] * X) + (array2[i + 1] * X);

                if (value < min) min = value;
            }

            Console.Write(min);
        }
    }
}
