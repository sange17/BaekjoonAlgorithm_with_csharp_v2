namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_32929
    {
        public void solve()
        {
            int x = Int32.Parse(Console.ReadLine()!);
            if(x % 3 == 0)
                Console.Write("S");
            else if(x % 3 == 1)
                Console.Write("U");
            else if(x % 3 == 2)
                Console.Write("O");
        }
    }
}
