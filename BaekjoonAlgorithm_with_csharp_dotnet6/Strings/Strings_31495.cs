namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_31495
    {
        public void solve()
        {
            string line = Console.ReadLine()!;
            if(line.Length <= 2) Console.Write("CE");
            else
            {
                if (line[0] == '\"' && line[line.Length - 1] == '\"')
                    Console.Write(line.Substring(1, line.Length - 2));
                else
                    Console.Write("CE");
            }
        }
    }
}
