namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_17201
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine()!);
            string line = Console.ReadLine()!;

            if (line.Contains("1221") || line.Contains("2112"))
            {
                Console.Write("No");
            }
            else
            {
                Console.Write("Yes");
            }
        }
    }
}
