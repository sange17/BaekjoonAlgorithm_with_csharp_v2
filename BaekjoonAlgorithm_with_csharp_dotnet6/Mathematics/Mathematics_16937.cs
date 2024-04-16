namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_16937
    {
        public void solve()
        {
            string line = Console.ReadLine();
            int H = Int32.Parse(line.Split(" ")[0]);
            int W = Int32.Parse(line.Split(" ")[1]);
            int N = Int32.Parse(Console.ReadLine());
            int[,] stickers = new int[N, 2];
            for(int i = 0; i < N; i++)
            {
                line = Console.ReadLine();
                stickers[i, 0] = Int32.Parse(line.Split(" ")[0]);
                stickers[i, 1] = Int32.Parse(line.Split(" ")[1]);
            }

            int sum = 0;
            int max = 0;
            for(int i = 0; i < N - 1; i++)
            {
                for(int j = i + 1; j < N; j++)
                {
                    if (stickers[i, 0] + stickers[j, 0] <= H && Math.Max(stickers[i, 1], stickers[j, 1]) <= W ||
                        stickers[i, 0] + stickers[j, 0] <= W && Math.Max(stickers[i, 1], stickers[j, 1]) <= H)
                    {
                        sum = stickers[i, 0] * stickers[i, 1] + stickers[j, 0] * stickers[j, 1];
                    }
                    else if (stickers[i, 0] + stickers[j, 1] <= H && Math.Max(stickers[i, 1], stickers[j, 0]) <= W ||
                             stickers[i, 0] + stickers[j, 1] <= W && Math.Max(stickers[i, 1], stickers[j, 0]) <= H)
                    {
                        sum = stickers[i, 0] * stickers[i, 1] + stickers[j, 0] * stickers[j, 1];
                    }
                    else if (stickers[i, 1] + stickers[j, 0] <= H && Math.Max(stickers[i, 0], stickers[j, 1]) <= W ||
                            stickers[i, 1] + stickers[j, 0] <= W && Math.Max(stickers[i, 0], stickers[j, 1]) <= H)
                    {
                        sum = stickers[i, 0] * stickers[i, 1] + stickers[j, 0] * stickers[j, 1];
                    }
                    else if (stickers[i, 1] + stickers[j, 1] <= H && Math.Max(stickers[i, 0], stickers[j, 0]) <= W ||
                            stickers[i, 1] + stickers[j, 1] <= W && Math.Max(stickers[i, 0], stickers[j, 0]) <= H)
                    {
                        sum = stickers[i, 0] * stickers[i, 1] + stickers[j, 0] * stickers[j, 1];
                    }
                    if (max < sum) max = sum;
                }
            }

            Console.Write(max);
        }
    }
}
