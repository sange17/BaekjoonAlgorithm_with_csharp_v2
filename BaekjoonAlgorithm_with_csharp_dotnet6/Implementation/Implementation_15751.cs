namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_15751
    {
        public void solve()
        {
            string line = Console.ReadLine()!;
            int a = Int32.Parse(line.Split(" ")[0]);
            int b = Int32.Parse(line.Split(" ")[1]);
            int x = Int32.Parse(line.Split(" ")[2]);
            int y = Int32.Parse(line.Split(" ")[3]);
            int abMax = Math.Max(a, b);
            int abMin = Math.Min(a, b);
            int xyMax = Math.Max(x, y);
            int xyMin = Math.Min(x, y);

            Console.Write(Math.Min(Math.Abs(abMax - xyMax) + Math.Abs(abMin - xyMin), abMax - abMin));
        }
    }
}
