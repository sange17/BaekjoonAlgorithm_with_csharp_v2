namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_13236
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);

            Console.Write(n + " ");
            while (true)
            {
                if (n == 1) break;

                if (n % 2 == 0)
                    n /= 2;
                else
                    n = (3 * n + 1);

                Console.Write(n + " ");
            }
        }
    }
}
