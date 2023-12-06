using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_17387
    {
        public class Point
        {
            public long x , y;

            public Point(long x, long y)
            {
                this.x = x;
                this.y = y;
            }
        }

        public void solve()
        {
            Point[] point = new Point[4];

            string line = Console.ReadLine();

            long x1 = long.Parse(line.Split(' ')[0]);
            long y1 = long.Parse(line.Split(' ')[1]);
            long x2 = long.Parse(line.Split(' ')[2]);
            long y2 = long.Parse(line.Split(' ')[3]);

            line = Console.ReadLine();
            long x3 = long.Parse(line.Split(' ')[0]);
            long y3 = long.Parse(line.Split(' ')[1]);
            long x4 = long.Parse(line.Split(' ')[2]);
            long y4 = long.Parse(line.Split(' ')[3]);

            point[0] = new Point(x1, y1);
            point[1] = new Point(x2, y2);
            point[2] = new Point(x3, y3);
            point[3] = new Point(x4, y4);

            Console.Write(CheckCCW(point));
        }

        static int CheckCCW(Point[] p)
        {
            Boolean isResult = false;
            int result = 0;
            int p123 = CCW(p[0], p[1], p[2]);
            int p124 = CCW(p[0], p[1], p[3]);
            int p341 = CCW(p[2], p[3], p[0]);
            int p342 = CCW(p[2], p[3], p[1]);

            Boolean compare1 = Math.Min(p[0].x, p[1].x) <= Math.Max(p[2].x, p[3].x);
            Boolean compare2 = Math.Min(p[2].x, p[3].x) <= Math.Max(p[0].x, p[1].x);
            Boolean compare3 = Math.Min(p[0].y, p[1].y) <= Math.Max(p[2].y, p[3].y);
            Boolean compare4 = Math.Min(p[2].y, p[3].y) <= Math.Max(p[0].y, p[1].y);

            if(p123 * p124 == 0 && p341 * p342 == 0)
            {
                isResult = true;
                if (compare1 && compare2 && compare3 && compare4)
                    result = 1;
            }

            if (p123 * p124 <= 0 && p341 * p342 <= 0)
            {
                if (!isResult)
                    result = 1;
            }

            return result;
        }

        static int CCW(Point p1, Point p2, Point p3)
        {
            // CCW 공식 (x1y2+x2y3+x3y1) - (y1x2+y2x3+y3x1)
            long result = ((p1.x * p2.y)+(p2.x * p3.y)+(p3.x * p1.y)) - ((p1.y * p2.x) + (p2.y * p3.x) + (p3.y * p1.x));
            if (result > 0)
                return 1;
            else if (result == 0)
                return 0;
            else
                return -1;
        }
    }
}
