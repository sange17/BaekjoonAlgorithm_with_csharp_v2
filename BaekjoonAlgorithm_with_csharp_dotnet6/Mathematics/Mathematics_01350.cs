namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_01350
    {
        public void solve()
        {
            long N = Int32.Parse(Console.ReadLine()!);
            long[] array = Console.ReadLine()!.Split(" ").Select(long.Parse).ToArray();
            long cluster = Int32.Parse(Console.ReadLine()!);

            long sum = 0;
            for (int i = 0; i < N; i++)
            {
                if (array[i] == 0) continue;

                if (array[i] % cluster == 0)
                    sum += (cluster * (array[i] / cluster));
                else
                    sum += (cluster * (array[i] / cluster)) + cluster;
            }

            Console.Write(sum);
        }
    }
}
