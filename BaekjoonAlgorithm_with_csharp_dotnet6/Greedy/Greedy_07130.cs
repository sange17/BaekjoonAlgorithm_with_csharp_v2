namespace BaekjoonAlgorithm_with_csharp_dotnet6.Greedy
{
    class Greedy_07130
    {
        public void solve()
        {
            string line = Console.ReadLine()!;
            int m = Int32.Parse(line.Split(" ")[0]);
            int h = Int32.Parse(line.Split(" ")[1]);

            int n = Int32.Parse(Console.ReadLine()!);

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                line = Console.ReadLine()!;
                int c = Int32.Parse(line.Split(" ")[0]);
                int b = Int32.Parse(line.Split(" ")[1]);
                sum += Math.Max(m * c, h * b);
            }
            Console.Write(sum);
        }
    }
}
