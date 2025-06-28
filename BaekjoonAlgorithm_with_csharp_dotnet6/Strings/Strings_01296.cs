namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_01296
    {
        public void solve()
        {
            string yeondoo = Console.ReadLine()!;
            int n = int.Parse(Console.ReadLine()!);
            List<string> teams = new List<string>();

            for (int i = 0; i < n; i++)
            {
                teams.Add(Console.ReadLine()!);
            }

            string bestTeam = "";
            int maxScore = -1;

            foreach (string team in teams)
            {
                int L = CountChar(yeondoo + team, 'L');
                int O = CountChar(yeondoo + team, 'O');
                int V = CountChar(yeondoo + team, 'V');
                int E = CountChar(yeondoo + team, 'E');

                int score = ((L + O) * (L + V) * (L + E) * (O + V) * (O + E) * (V + E)) % 100;

                if (score > maxScore)
                {
                    maxScore = score;
                    bestTeam = team;
                }
                else if (score == maxScore)
                {
                    if (string.Compare(team, bestTeam) < 0)
                    {
                        bestTeam = team;
                    }
                }
            }

            Console.WriteLine(bestTeam);
        }

        static int CountChar(string input, char c)
        {
            return input.Count(ch => ch == c);
        }
    }
}
