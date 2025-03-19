namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_32089
    {
        public void solve()
        {
            while (true)
            {
                int n = Int32.Parse(Console.ReadLine()!);

                if (n == 0)
                {
                    break;
                }

                int[] array = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

                int max = 0;
                int sum = 0;
                for (int i = 0; i < array.Length - 2; i++)
                {
                    sum = 0;

                    for (int j = i; j <= i + 2; j++)
                    {
                        sum += array[j];
                    }

                    if (sum > max) max = sum;
                }

                Console.WriteLine(max);
            }
        }
    }
}
