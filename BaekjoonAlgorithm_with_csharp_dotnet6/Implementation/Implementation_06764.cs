namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_06764
    {
        public void solve()
        {
            int a = Int32.Parse(Console.ReadLine()!);
            int b = Int32.Parse(Console.ReadLine()!);
            int c = Int32.Parse(Console.ReadLine()!);
            int d = Int32.Parse(Console.ReadLine()!);

            if(a < b && b < c && c < d)
                Console.Write("Fish Rising");
            else if(a > b && b > c && c > d)
                Console.Write("Fish Diving");
            else if(a == b && b == c && c == d)
                Console.Write("Fish At Constant Depth");
            else
                Console.Write("No Fish");
        }
    }
}
