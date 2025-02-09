namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_31608
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine()!);
            string S = Console.ReadLine()!;
            string T = Console.ReadLine()!;

            int count = 0;
            for (int i = 0; i < N; i++)
                if (S[i] != T[i]) count++;

            Console.Write(count);
        }
    }
}
