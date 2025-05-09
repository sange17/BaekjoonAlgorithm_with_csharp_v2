namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_04922
    {
        public void solve()
        {
            while (true)
            {
                int N = Int32.Parse(Console.ReadLine()!);
                if (N == 0) break;
                Console.WriteLine(N + " => " + (N * N - N + 1));
            }
        }
    }
}
