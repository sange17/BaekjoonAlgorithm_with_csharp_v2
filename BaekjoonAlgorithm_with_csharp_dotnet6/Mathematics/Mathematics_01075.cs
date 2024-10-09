namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_01075
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine()!);
            int F = Int32.Parse(Console.ReadLine()!);

            N -= (N % 100);
            int maxNum = N + 99;

            for (int i = N; i <= maxNum; i++)
            {
                if (i % F == 0)
                {
                    Console.Write((i % 100).ToString().PadLeft(2, '0'));
                    break;
                }
            }
        }
    }
}
