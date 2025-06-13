namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_23972
    {
        public void solve()
        {
            string[] input = Console.ReadLine()!.Split();
            long K = long.Parse(input[0]);
            long N = long.Parse(input[1]);

            if (N == 1)
            {
                Console.WriteLine(-1);
            }
            else
            {
                // X >= KN / (N - 1)
                long numerator = K * N;
                long denominator = N - 1;

                // 올림을 위해 나누어 떨어지지 않으면 +1
                long result = (numerator + denominator - 1) / denominator;

                Console.WriteLine(result);
            }
        }
    }
}
