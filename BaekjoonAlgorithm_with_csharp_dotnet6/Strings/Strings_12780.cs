namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_12780
    {
        public void solve()
        {
            string H = Console.ReadLine()!;
            string N = Console.ReadLine()!;

            string[] strings = H.Split(N);

            Console.Write(strings.Length - 1);
        }
    }
}
