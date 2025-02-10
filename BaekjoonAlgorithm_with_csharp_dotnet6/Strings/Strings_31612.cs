namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_31612
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine()!);
            string S = Console.ReadLine()!;

            int count = 0;
            for (int i = 0; i < N; i++)
            {
                if (S[i] == 'j' || S[i] == 'i')
                    count += 2;
                else if (S[i] == 'o')
                    count++;
            }

            Console.Write(count);
        }
    }
}
