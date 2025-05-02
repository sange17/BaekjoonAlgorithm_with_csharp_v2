namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_11368
    {
        public void solve()
        {
            int C = 0, W = 0, L = 0, P = 0;
            while (true)
            {
                string line = Console.ReadLine()!;
                C = Int32.Parse(line.Split(" ")[0]);
                W = Int32.Parse(line.Split(" ")[1]);
                L = Int32.Parse(line.Split(" ")[2]);
                P = Int32.Parse(line.Split(" ")[3]);

                if (C == 0) break;
                if (C == 1) Console.WriteLine(1);
                else
                {
                    int answer = 1;
                    int square = W * L * P;
                    while (square != 0)
                    {
                        answer *= C;
                        square--;
                    }
                    Console.WriteLine(answer);
                }
            }
        }
    }
}
