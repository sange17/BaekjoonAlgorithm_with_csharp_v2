namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_13484
    {
        public void solve()
        {
            int x = Int32.Parse(Console.ReadLine()!);
            int n = Int32.Parse(Console.ReadLine()!);

            int result = x;
            for (int i = 0; i < n; i++)
            {
                int p = Int32.Parse(Console.ReadLine()!);

                result -= p;
                result += x;
            }

            Console.Write(result);
        }
    }
}
