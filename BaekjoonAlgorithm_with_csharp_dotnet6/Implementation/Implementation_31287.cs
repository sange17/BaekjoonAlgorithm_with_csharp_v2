namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_31287
    {
        public void solve()
        {
            string line = Console.ReadLine();
            int N = int.Parse(line.Split(" ")[0]);
            int K = int.Parse(line.Split(" ")[1]);

            line = Console.ReadLine();

            int curX = 0;
            int cunY = 0;
            bool flag = false;

            if (K > N >> 1)
                K = N >> 1;

            for (int i = 0; i < K; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (line[j] == 'U')
                        ++cunY;
                    else if (line[j] == 'D')
                        --cunY;
                    else if (line[j] == 'R')
                        --curX;
                    else if (line[j] == 'L')
                        ++curX;

                    if (cunY == 0 && curX == 0)
                    {
                        flag = true;
                        break;
                    }
                }
            }

            if (flag)
                Console.Write("YES");
            else
                Console.Write("NO");
        }
    }
}
