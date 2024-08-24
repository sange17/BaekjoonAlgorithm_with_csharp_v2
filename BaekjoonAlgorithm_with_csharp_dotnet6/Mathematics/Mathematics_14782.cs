namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_14782
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0) sum += i;
            }

            Console.Write(sum);
        }
    }
}
