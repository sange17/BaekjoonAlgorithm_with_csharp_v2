namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_14568
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine()!);
            int count = 0;
            for (int i = 1; i <= 100; i++)
            {
                for (int j = 1; j <= 100 - i; j++)
                {
                    for (int k = 1; k <= 100; k++)
                    {
                        if (i >= j + 2 && j != 0 && k != 0 && k % 2 == 0 && i + j + k == N)
                        {
                            count++;
                        }
                    }
                }
            }

            Console.Write(count);
        }
    }
}
