namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_06856
    {
        public void solve()
        {
            int m = Int32.Parse(Console.ReadLine()!);
            int n = Int32.Parse(Console.ReadLine()!);
            int count = 0;

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i + j == 10) count++;
                }
            }

            if (count == 1)
            {
                Console.Write("There is " + count + " way to get the sum 10.");
            }
            else
            {
                Console.Write("There are " + count + " ways to get the sum 10.");
            }
        }
    }
}
