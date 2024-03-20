namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_21631
    {
        public void solve()
        {
            string line = Console.ReadLine();
            long a = long.Parse(line.Split(" ")[0]);
            long b = long.Parse(line.Split(" ")[1]);

            if (a >= b) Console.Write(b);
            else Console.Write(a + 1);
        }
    }
}
