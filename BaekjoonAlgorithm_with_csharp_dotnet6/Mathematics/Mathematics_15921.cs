namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_15921
    {
        public void solve()
        {
            double N = Int32.Parse(Console.ReadLine()!);
            if (N == 0) Console.Write("divide by zero");
            else
            {
                double[] array = Console.ReadLine()!.Split(" ").Select(double.Parse).ToArray();
                double avg = array.Sum() / N;

                double expectedVal = 0;
                for (int i = 0; i < N; i++)
                {
                    expectedVal += (array[i] * (1 / N));
                }

                if(expectedVal == 0) Console.Write("divide by zero");
                else
                {
                    Console.Write(Math.Round(avg / expectedVal,2 , MidpointRounding.AwayFromZero).ToString("0.00"));
                }
            }
        }
    }
}
