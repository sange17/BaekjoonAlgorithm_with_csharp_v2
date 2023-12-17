using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Greedy
{
    class Greedy_28062
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine());
            int[] array = new int[N];
            string[] arrayLine = Console.ReadLine().Split();

            for(int i = 0; i < N; i++)
            {
                array[i] = int.Parse(arrayLine[i]);
            }

            Array.Sort(array);

            int result = 0;
            int odd = 0;
            for(int i = N - 1; i >= 0; i--)
            {
                if (array[i] % 2 != 0)
                {
                    if (odd != 0)
                    {
                        result += odd + array[i];
                        odd = 0;
                    }
                    else
                        odd = array[i];
                }
                else
                    result += array[i];
            }

            Console.Write(result);
        }
    }
}
