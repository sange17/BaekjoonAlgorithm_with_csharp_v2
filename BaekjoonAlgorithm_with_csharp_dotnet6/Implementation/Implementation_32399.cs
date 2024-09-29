namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_32399
    {
        public void solve()
        {
            string line = Console.ReadLine()!;
            if (line == "(1)")
                Console.Write(0);
            else if (line[1] == '1')
                Console.Write(2);
            else
                Console.Write(1);
        }
    }
}
