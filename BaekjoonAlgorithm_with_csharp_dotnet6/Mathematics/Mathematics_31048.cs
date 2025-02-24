namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_31048
    {
        public void solve()
        {
            int T = Int32.Parse(Console.ReadLine()!);
            int N = 0;
            int result = 0;
            for (int i = 0; i < T; i++)
            {
                N = Int32.Parse(Console.ReadLine()!);
                result = 1;
                for (int j = 1; j <= N; j++)
                {
                    result *= j;
                    result %= 10;
                }

                Console.WriteLine(result);
            }
        }
    }
}
