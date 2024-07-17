namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_06784
    {
        public void solve()
        {
            int n = int.Parse(Console.ReadLine()!);

            string[] lst = new string[n];
            for (int i = 0; i < n; i++)
            {
                lst[i] = Console.ReadLine()!;
            }

            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                if (lst[i] == Console.ReadLine()!)
                {
                    ans++;
                }
            }

            Console.WriteLine(ans);
        }
    }
}
