using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Greedy
{
    class Greedy_01969
    {
        public void solve()
        {
            string line = Console.ReadLine();
            int n = Int32.Parse(line.Split(' ')[0]);
            int m = Int32.Parse(line.Split(' ')[1]);
            string[] word = new string[1000];
            int result_sum = 0;
            string result = string.Empty;

            for(int i = 0; i < n; i++)
            {
                word[i] = Console.ReadLine();
            }

            for(int i = 0; i < m; i++)
            {
                int[] array = new int[26];
                int maxed = 0;
                int max_index = 0;

                for(int j = 0; j < n; j++)
                {
                    array[word[j][i] - 'A']++;
                }
                for (int j = 0; j < 26; j++)
                {
                    if (maxed < array[j])
                    {
                        maxed = array[j];
                        max_index = j;
                    }
                }
                result_sum += n - maxed;
                result += (char)(max_index + 'A');
            }
            Console.Write(result + "\n" + result_sum);
        }
    }
}
