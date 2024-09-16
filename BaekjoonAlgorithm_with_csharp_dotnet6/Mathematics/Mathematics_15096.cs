namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_15096
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);

            double[] array = Console.ReadLine()!.Split(" ").Select(double.Parse).ToArray();

            double sum = 0;
            int idx = n;
            for (int i = 0; i < idx; i++)
            {
                if (array[i] == -1)
                {
                    n -= 1;
                    continue;
                }

                sum += array[i];
            }

            Console.Write(sum / n);
        }
    }
}
