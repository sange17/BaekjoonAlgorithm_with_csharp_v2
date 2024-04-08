namespace BaekjoonAlgorithm_with_csharp_dotnet6.Geometry
{
    class Geometry_10655
    {
        public class Point
        {
            public int x;
            public int y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        static Point[] points;
        static int pointCnt;

        public void solve()
        {
            pointCnt = Int32.Parse(Console.ReadLine());
            points = new Point[pointCnt];
            string line = string.Empty;
            for (int i = 0; i < pointCnt; i++)
            {
                line = Console.ReadLine();
                int xPoint = Int32.Parse(line.Split(" ")[0]);
                int yPoint = Int32.Parse(line.Split(" ")[1]);
                points[i] = new Point(xPoint, yPoint);
            }

            int sum = 0;
            for(int i = 0; i < pointCnt - 1; i++)
            {
                sum += DistanceSum(i, i + 1);
            }

            int result = sum;
            for(int i = 1; i < pointCnt - 1; i++)
            {
                int loopSum = sum - (DistanceSum(i, i + 1) + DistanceSum(i, i - 1)) + DistanceSum(i - 1, i + 1);

                result = Math.Min(loopSum, result);
            }
            Console.WriteLine(result);
        }

        static int DistanceSum(int first, int second)
        {
            return Math.Abs(points[first].x - points[second].x) + Math.Abs(points[first].y - points[second].y);
        }
    }
}
