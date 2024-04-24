namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_11466
    {
        public void solve()
        {
            string line = Console.ReadLine();
            double h = Int32.Parse(line.Split(" ")[0]);
            double w = Int32.Parse(line.Split(" ")[1]);
            double a = Math.Max(h, w);
            double b = Math.Min(h, w);
            double ans = 0;
            if (b * 3 < a) ans = b;
            else if (b * 1.5 < a) ans = a / 3;
            else ans = b / 2;
            Console.Write(ans);
        }
    }
}
