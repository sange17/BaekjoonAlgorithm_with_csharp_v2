namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_31746
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine()!);
            if(N % 2 == 0)
                Console.Write("SciComLove");
            else if(N % 2 == 1)
                Console.Write("evoLmoCicS");
        }
    }
}
