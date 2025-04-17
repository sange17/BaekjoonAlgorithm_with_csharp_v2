namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_10693
    {
        public void solve()
        {
            int t = Int32.Parse(Console.ReadLine()!);
            for (int i = 1; i <= t; i++)
            {
                string line = Console.ReadLine()!;
                int n = Int32.Parse(line.Split(" ")[0]);
                int m = Int32.Parse(line.Split(" ")[1]);

                Console.WriteLine("Case " + i + ": " + (m - (n - 1)));
            }
        }
    }
}
