using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Data_Structures
{
    class Data_Structures_01253
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            string[] line = Console.ReadLine().Split(' ');
            for(int i = 0; i < N; i++)
            {
                numbers[i] = Int32.Parse(line[i]); 
            }
            Array.Sort(numbers);

            int result = 0;
            int left = 0;
            int right = 0;
            for(int i = 0; i < N; i++)
            {
                left = 0;
                right = N - 1;
                while(true)
                {
                    if (left == i) left++;
                    else if (right == i) right--;

                    if(left >= right) break;

                    if (numbers[left] + numbers[right] > numbers[i]) right--;
                    else if (numbers[left] + numbers[right] < numbers[i]) left++;
                    else
                    {
                        result++;
                        break;
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
