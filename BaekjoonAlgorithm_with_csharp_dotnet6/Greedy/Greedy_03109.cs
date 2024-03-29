namespace BaekjoonAlgorithm_with_csharp_dotnet6.Greedy
{
    class Greedy_03109
    {
        static int r, c, cnt = 0;
        static char[,] map;
        static int[] dr = { -1, 0, 1 };

        static bool dfs(int x, int y)
        {
            for(int i = 0; i < 3; i++)
            {
                int nx = x + 1;
                int ny = y + dr[i];

                if (nx < 0 || nx > c - 1 || ny < 0 || ny > r - 1) continue;
                if (map[ny,nx] == '.')
                {
                    if(nx == c - 1)
                    {
                        cnt++;
                        return true;
                    }

                    map[ny, nx] = '-';
                    if (dfs(nx, ny)) return true;
                }
            }
            return false;
        }

        public void solve()
        {
            string line = Console.ReadLine();
            r = Int32.Parse(line.Split(" ")[0]);
            c = Int32.Parse(line.Split(" ")[1]);
            map = new char[r, c];

            for(int i = 0; i < r; i++)
            {
                line = Console.ReadLine();
                for (int j = 0; j < c; j++)
                    map[i, j] = line[j];
            }

            for(int i = 0; i < r; i++)
            {
                dfs(0, i);
            }
            Console.WriteLine(cnt);
        }
    }
}
