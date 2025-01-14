namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_20673
    {
        public void solve()
        {
            int p = Int32.Parse(Console.ReadLine()!);
            int q = Int32.Parse(Console.ReadLine()!);

            if(p <= 50 && q <= 10)
                Console.Write("White");
            else if(q > 30)
                Console.Write("Red");
            else
                Console.Write("Yellow");
        }
    }
}
