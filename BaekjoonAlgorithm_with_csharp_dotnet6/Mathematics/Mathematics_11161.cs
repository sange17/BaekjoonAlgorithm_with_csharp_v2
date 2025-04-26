namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_11161
    {
        public void solve()
        {
            int t = Int32.Parse(Console.ReadLine()!);
            for (int i = 0; i < t; i++)
            {
                int m = Int32.Parse(Console.ReadLine()!);
                int sum = 0;
                int min = 0;

                for (int j = 0; j < m; j++)
                {
                    string line = Console.ReadLine()!;
                    int p1 = Int32.Parse(line.Split(" ")[0]) + sum;
                    int p2 = Int32.Parse(line.Split(" ")[1]);
                    sum = 0;

                    if (p1 <= p2)
                    {
                        min += (p2 - p1);
                        sum = 0;
                    }
                    else sum += (p1 - p2);
                }

                Console.WriteLine(min);
            }
        }
    }
}
