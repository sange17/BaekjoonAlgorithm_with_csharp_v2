namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_31616
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);
            string line = Console.ReadLine()!;

            line = string.Concat(line.Distinct());
            if(line.Length == 1) Console.Write("Yes");
            else Console.Write("No");
        }
    }
}
