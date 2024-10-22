namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_15051
    {
        public void solve()
        {
            int a1 = Int32.Parse(Console.ReadLine()!);
            int a2 = Int32.Parse(Console.ReadLine()!);
            int a3 = Int32.Parse(Console.ReadLine()!);

            int case1 = a2 * 2 + a3 * 4;
            int case2 = a1 * 2 + a3 * 2;
            int case3 = a1 * 4 + a2 * 2;

            Console.Write(Math.Min(Math.Min(case1, case2), case3));
        }
    }
}
