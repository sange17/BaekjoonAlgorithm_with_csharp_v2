namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_11109
    {
        public void solve()
        {
            int t = Int32.Parse(Console.ReadLine()!);
            for (int i = 0; i < t; i++)
            {
                string line = Console.ReadLine()!;
                int d = Int32.Parse(line.Split(" ")[0]);
                int n = Int32.Parse(line.Split(" ")[1]);
                int s = Int32.Parse(line.Split(" ")[2]);
                int p = Int32.Parse(line.Split(" ")[3]);

                if(d + p * n == s * n)
                    Console.WriteLine("does not matter");
                else if(d + p * n > s * n)
                    Console.WriteLine("do not parallelize");
                else
                    Console.WriteLine("parallelize");
            }
        }
    }
}
