namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_01145
    {
        public void solve()
        {
            // 입력 받기
            int[] numbers = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            int current = 1;

            while (true)
            {
                int divisibleCount = 0;

                foreach (int num in numbers)
                {
                    if (current % num == 0)
                    {
                        divisibleCount++;
                    }
                }

                if (divisibleCount >= 3)
                {
                    Console.WriteLine(current);
                    break;
                }

                current++;
            }
        }
    }
}
