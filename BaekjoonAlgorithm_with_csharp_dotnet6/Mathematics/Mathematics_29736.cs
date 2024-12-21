namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_29736
    {
        public void solve()
        {
            string line = Console.ReadLine()!;
            int A = Int32.Parse(line.Split(" ")[0]); 
            int B = Int32.Parse(line.Split(" ")[1]); 
            line = Console.ReadLine()!;
            int K = Int32.Parse(line.Split(" ")[0]); 
            int X = Int32.Parse(line.Split(" ")[1]);

            int sum = 0;
            for (int i = A; i <= B; i++)
            {
                if (i >= K - X && i <= K + X)
                {
                    sum++;
                }
            }

            if (sum == 0)
                Console.Write("IMPOSSIBLE");
            else
                Console.Write(sum);
        }
    }
}
