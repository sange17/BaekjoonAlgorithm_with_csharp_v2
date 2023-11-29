using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Greedy
{
    class Greedy_01339
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine());
            string[] array = new string[26];
            int[] alpha = new int[26];
            for(int i = 0; i < N; i++)
            {
                array[i] = Console.ReadLine();
            }

            int temp = 0;
            for(int i = 0; i < N; i++)
            {
                temp = (int)Math.Pow(10, array[i].Length - 1);

                for(int j = 0; j < array[i].Length; j++)
                {
                    alpha[(int)array[i][j] - 65] += temp;
                    temp /= 10;
                }
            }

            Array.Sort(alpha);
            int index = 9;
            int sum = 0;
            for(int i = alpha.Length - 1; i >= 0; i--)
            {
                if (alpha[i] == 0)
                {
                    break;
                }
                sum += alpha[i] * index;
                index--;
            }

            Console.Write(sum);
        }
    }
}
