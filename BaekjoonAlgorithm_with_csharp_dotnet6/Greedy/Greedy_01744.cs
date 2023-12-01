using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Greedy
{
    class Greedy_01744
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine());
            int answer = 0;
            int[] array = new int[N];

            for(int i = 0; i < N; i++)
            {
                array[i] = Int32.Parse(Console.ReadLine());
            }

            Array.Sort(array);

            int minusIdx = 0;
            while(minusIdx < N && array[minusIdx] < 1)
            {
                if(minusIdx + 1 < N && array[minusIdx + 1] < 1)
                {
                    answer += (array[minusIdx] * array[minusIdx + 1]);
                    minusIdx += 2;
                }
                else
                {
                    answer += array[minusIdx++];
                }
            }

            int plusIdx = N - 1;
            while(plusIdx >= minusIdx && array[plusIdx] > 0)
            {
                if(plusIdx - 1 >= minusIdx && array[plusIdx - 1] > 1)
                {
                    answer += (array[plusIdx] * array[plusIdx - 1]);
                    plusIdx -= 2;
                }
                else
                {
                    answer += array[plusIdx--];
                }
            }

            Console.Write(answer);
        }
    }
}
