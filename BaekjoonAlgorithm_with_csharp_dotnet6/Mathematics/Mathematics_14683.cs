namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_14683
    {
        public void solve()
        {
            string line = Console.ReadLine()!;
            int a = Int32.Parse(line.Split(" ")[0]);
            int b = Int32.Parse(line.Split(" ")[1]);
            line = Console.ReadLine()!;
            int c = Int32.Parse(line.Split(" ")[0]);
            int d = Int32.Parse(line.Split(" ")[1]);
            int t = Int32.Parse(Console.ReadLine()!);
            int distance = Math.Abs(a - c) + Math.Abs(b - d);

            if (distance > t)
                Console.Write("N");
            else if (distance == t || (t - distance) % 2 == 0)
                Console.Write("Y");
            else
                Console.Write("N");
        }
    }
}
