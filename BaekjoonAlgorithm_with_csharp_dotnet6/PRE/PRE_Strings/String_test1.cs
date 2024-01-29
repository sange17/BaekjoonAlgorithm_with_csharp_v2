using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.PRE.PRE_Strings
{
    class String_test1
    {
        public void solve()
        {
            string line = Console.ReadLine();
            int N = Int32.Parse(line.Split(" ")[0]);
            int K = Int32.Parse(line.Split(" ")[1]);

            line = Console.ReadLine();

            long x = 0;
            long y = 0;
            bool flag = false;
            for (int i = 0; i < K; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (line[j] == 'U')
                        y++;
                    else if (line[j] == 'D')
                        y--;
                    else if (line[j] == 'R')
                        x++;
                    else if (line[j] == 'L')
                        x--;

                    if (x == 0 && y == 0)
                    {
                        flag = true;
                        break;
                    }
                }

                if (flag)
                {
                    Console.Write("YES");
                    break;
                }
                
                if (i == K - 1)
                    Console.Write("NO");
            }
        }
    }
}
