namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    internal class Strings_23627
    {
        public void solve()
        {
            string line = Console.ReadLine()!;
            if(line.Length < 5)
                Console.Write("not cute");
            else if (line.Substring(line.Length - 5) == "driip")
                Console.Write("cute");
            else
                Console.Write("not cute");
        }
    }
}
