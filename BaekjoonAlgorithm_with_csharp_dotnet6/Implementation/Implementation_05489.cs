namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_05489
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine()!);
            int[] array = new int[10001];
            int max = 0;
            for (int i = 0; i < N; i++)
            {
                int num = Int32.Parse(Console.ReadLine()!);

                array[num]++;

                if (max < array[num])
                {
                    max = array[num];
                }
            }

            for (int i = 1; i <= 10000; i++)
            {
                if (array[i] == max)
                {
                    Console.Write(i);
                    break;
                }
            }
        }
    }
}
