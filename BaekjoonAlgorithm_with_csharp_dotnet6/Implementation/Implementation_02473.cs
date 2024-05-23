using System;
namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_02473
    {
        static long[] pick = new long[3];
        static long max = long.MaxValue;

        static void solution(long[] arr, int index)
        {
            int left = index + 1;
            int right = arr.Length - 1;

            while(left < right)
            {
                long sum = arr[left] + arr[right] + arr[index];
                long absSum = Math.Abs(sum);

                if(absSum < max)
                {
                    pick[0] = arr[left];
                    pick[1] = arr[right];
                    pick[2] = arr[index];
                    max = absSum;
                }

                if (sum > 0)
                    right--;
                else
                    left++;
            }
        }

        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine());
            long[] arr = new long[n];

            string[] line = Console.ReadLine().Split(" ");
            for(int i = 0; i < n; i++)
                arr[i] = long.Parse(line[i]);

            Array.Sort(arr);

            for (int i = 0; i < n - 2; i++)
                solution(arr, i);

            Array.Sort(pick);

            for(int i = 0; i < 3; i++)
                Console.Write(pick[i] + " ");
        }
    }
}
