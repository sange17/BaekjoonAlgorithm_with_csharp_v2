namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_16239
    {
        public void solve()
        {
            int k = Int32.Parse(Console.ReadLine()!);
            int n = Int32.Parse(Console.ReadLine()!);

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if(i == n)
                {
                    Console.WriteLine(k - sum);
                }
                else
                {
                    Console.WriteLine(i);
                    sum += i;
                }
            }
        }
    }
}
