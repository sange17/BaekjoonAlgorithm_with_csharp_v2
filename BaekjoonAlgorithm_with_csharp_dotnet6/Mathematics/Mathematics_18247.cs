namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    internal class Mathematics_18247
    {
        public void solve()
        {
            int T = Int32.Parse(Console.ReadLine()!);
            for (int i = 0; i < T; i++)
            {
                string line = Console.ReadLine()!;
                int N = Int32.Parse(line.Split(" ")[0]);
                int M = Int32.Parse(line.Split(" ")[1]);

                if (N < 12 || M < 4)
                {
                    Console.WriteLine(-1);
                    continue;
                }

                int count = 0;
                bool flag = false;
                for (int j = 1; j <= N; j++)
                {
                    for (int k = 1; k <= M; k++)
                    {
                        count++;
                        if (j == 12 && k == 4)
                        {
                            flag = true;
                            Console.WriteLine(count);
                            break;
                        }
                    }

                    if (flag) break;
                }
            }
        }
    }
}
