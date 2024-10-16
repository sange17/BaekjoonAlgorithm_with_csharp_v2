namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_05919
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine()!);
            int[] array = new int[N];
            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                array[i] = Int32.Parse(Console.ReadLine()!);
                sum += array[i];
            }

            int avg = sum / N;
            int result = 0;
            for (int i = 0; i < N; i++)
            {
                if (array[i] < avg) result += (avg - array[i]);
            }

            Console.Write(result);
        }
    }
}
