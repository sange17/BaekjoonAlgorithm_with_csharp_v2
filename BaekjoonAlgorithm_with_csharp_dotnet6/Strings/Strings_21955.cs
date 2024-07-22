namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_21955
    {
        public void solve()
        {
            string n = Console.ReadLine()!;
            int length = n.Length;

            Console.Write(n.Substring(0, length / 2) + " " + n.Substring(length / 2, length / 2));
        }
    }
}
