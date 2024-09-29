namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_04909
    {
        public void solve()
        {
            while (true)
            {
                double[] points = Console.ReadLine()!.Split(" ").Select(double.Parse).ToArray();

                if (points.Sum() == 0) break;

                Array.Sort(points);
                double result = (points[1]+ points[2] + points[3] + points[4]) / 4;
                Console.WriteLine(result);
            }
        }
    }
}
