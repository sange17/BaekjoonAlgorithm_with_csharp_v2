namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_20674
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine()!);
            int[] array = new int[N];
            for (int i = 0; i < N; i++)
                array[i] = Int32.Parse((Console.ReadLine()!));

            int sum = 0;
            for (int i = 1; i < N; i++)
            {
                if (array[i - 1] < array[i])
                {
                    sum += (array[i] - array[i - 1]);
                    array[i] = array[i - 1];
                }
            }

            Console.Write(sum);
        }
    }
}
