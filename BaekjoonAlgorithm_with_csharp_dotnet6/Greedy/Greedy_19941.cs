namespace BaekjoonAlgorithm_with_csharp_dotnet6.Greedy
{
    class Greedy_19941
    {
        static char[] info;
        static int answer = 0;

        static bool bergerCheck(int index)
        {
            if (info[index] == 'H')
            {
                info[index] = 'X';
                answer++;
                return true;
            }
            return false;
        }

        public void solve()
        {
            string line = Console.ReadLine();
            int N = Int32.Parse(line.Split(" ")[0]);
            int K = Int32.Parse(line.Split(" ")[1]);
            info = Console.ReadLine().ToCharArray();

            for(int i = 0; i < N; i++)
            {
                if (info[i] == 'P')
                {
                    int index = Math.Max(i - K, 0);
                    bool check = false;

                    for(int j = index; j < i; j++)
                    {
                        if (bergerCheck(j))
                        {
                            check = true;
                            break;
                        }
                    }

                    if (!check)
                    {
                        index = i + K >= N ? N - 1 : i + K;
                        for(int j = i + 1; j<= index; j++)
                        {
                            if (bergerCheck(j))
                                break;
                        }
                    }
                }
            }
            Console.Write(answer);
        }
    }
}
