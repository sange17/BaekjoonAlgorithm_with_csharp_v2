namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_31428
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine()!);
            string line = Console.ReadLine()!;
            char track = Console.ReadLine()![0];
            Console.Write(line.Where(x => x == track).Count());
        }
    }
}
