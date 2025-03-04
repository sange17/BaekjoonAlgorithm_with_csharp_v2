namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_23303
    {
        public void solve()
        {
            string line = Console.ReadLine()!;
            if(line.Contains("d2") || line.Contains("D2"))
                Console.Write("D2");
            else
                Console.Write("unrated");
        }
    }
}
