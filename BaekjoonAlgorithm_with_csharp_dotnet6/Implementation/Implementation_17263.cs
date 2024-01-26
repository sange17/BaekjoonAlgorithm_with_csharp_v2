using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_17263
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine());
            string[] array1 = Console.ReadLine().Split(" ");
            int[] array2 = new int[n];

            for(int i = 0; i < n; i++)
            {
                array2[i] = Int32.Parse(array1[i]);
            }

            Array.Sort(array2);

            Console.Write(array2[n - 1]);
        }
    }
}
