using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_23971
    {
        public void solve()
        {
            string line = Console.ReadLine();

            int H = Int32.Parse(line.Split(" ")[0]);
            int W = Int32.Parse(line.Split(" ")[1]);
            int N = Int32.Parse(line.Split(" ")[2]);
            int M = Int32.Parse(line.Split(" ")[3]);

            int height = (H - 1) / (N + 1) + 1;
            int width = (W - 1) / (M + 1) + 1;

            Console.Write(height * width);
        }
    }
}
