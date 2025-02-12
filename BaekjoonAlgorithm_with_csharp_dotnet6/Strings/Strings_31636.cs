namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_31636
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine()!);
            string line = Console.ReadLine()!;
            if(line.Contains("ooo"))
                Console.Write("Yes");
            else
                Console.Write("No");
        }
    }
}
