namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_13580
    {
        public void solve()
        {
            string line = Console.ReadLine()!;
            int a = Int32.Parse(line.Split(" ")[0]);
            int b = Int32.Parse(line.Split(" ")[1]);
            int c = Int32.Parse(line.Split(" ")[2]);

            if(a + b == c || a + c == b || b + c == a)
                Console.Write("S");
            else if(a == b || a == c || b == c)
                Console.Write("S");
            else
                Console.Write("N");
        }
    }
}
