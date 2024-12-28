namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_08320
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);
            int count = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i * j <= n) count++;
                }
            }
            Console.Write(count);
        }
    }
}
