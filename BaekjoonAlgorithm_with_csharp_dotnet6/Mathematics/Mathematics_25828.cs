namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_25828
    {
        public void solve()
        {
            string line = Console.ReadLine()!;
            int g = Int32.Parse(line.Split(" ")[0]);
            int p = Int32.Parse(line.Split(" ")[1]);
            int t = Int32.Parse(line.Split(" ")[2]);

            if (g * p == g + (p * t))
            {
                Console.Write(0);
            }
            else if (g * p > g + (p * t))
            {
                Console.Write(2);
            }
            else if (g * p < g + (p * t))
            {
                Console.Write(1);
            }
        }
    }
}
