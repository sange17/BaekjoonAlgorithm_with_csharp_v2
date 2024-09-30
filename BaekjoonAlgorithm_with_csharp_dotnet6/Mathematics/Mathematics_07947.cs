namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_07947
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);

            for (int i = 0; i < n; i++)
            {
                double sum1 = 0;
                double sum2 = 0;
                double sum3 = 0;
                for (int j = 0; j < 10; j++)
                {
                    double[] array = Console.ReadLine()!.Split(" ").Select(double.Parse).ToArray();
                    sum1 += array[0];
                    sum2 += array[1];
                    sum3 += array[2];
                }

                Console.WriteLine(Math.Round(sum1 / 10, MidpointRounding.AwayFromZero)
                          + " " + Math.Round(sum2 / 10, MidpointRounding.AwayFromZero)
                          + " " + Math.Round(sum3 / 10, MidpointRounding.AwayFromZero));
            }
        }
    }
}
