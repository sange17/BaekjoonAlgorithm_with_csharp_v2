namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_14209
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine()!);

            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                string line = Console.ReadLine()!;

                for (int j = 0; j < line.Length; j++)
                {
                    if (line[j] == 'A') sum += 4;
                    else if (line[j] == 'K') sum += 3;
                    else if (line[j] == 'Q') sum += 2;
                    else if (line[j] == 'J') sum += 1;
                    else if (line[j] == 'X') sum += 0;
                }
            }

            Console.Write(sum);
        }
    }
}
