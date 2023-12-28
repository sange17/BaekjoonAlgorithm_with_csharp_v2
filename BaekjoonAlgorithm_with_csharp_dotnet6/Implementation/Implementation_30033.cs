using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_30033
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine());
            int[] array = new int[N];

            string line = Console.ReadLine();
            for(int i = 0; i < N; i++)
            {
                array[i] = Int32.Parse(line.Split(' ')[i]);
            }

            int count = 0;
            line = Console.ReadLine();
            for(int i = 0;i < N; i++)
            {
                if (array[i] <= Int32.Parse(line.Split(' ')[i]))
                    count++;
            }

            Console.Write(count);
        }
    }
}
