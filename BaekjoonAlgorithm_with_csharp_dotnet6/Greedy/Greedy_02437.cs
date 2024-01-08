using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Greedy
{
    class Greedy_02437
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine());

            int[] array = new int[n];
            string[] line = Console.ReadLine().Split(' ');

            for(int i = 0; i < n; i++)
                array[i] = Int32.Parse(line[i]);

            Array.Sort(array);

            int sum = 0;

            for(int i = 0; i < n; i++)
            {
                if (array[i] > sum + 1) break;
                sum += array[i];
            }
            Console.Write(sum + 1);
        }
    }
}
