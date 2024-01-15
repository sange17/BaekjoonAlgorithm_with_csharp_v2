using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Geometry
{
    class Geometry_01358
    {
        static double getDistance(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }
        public void solve()
        {
            string line = Console.ReadLine();
            int w = Int32.Parse(line.Split(' ')[0]);
            int h = Int32.Parse(line.Split(' ')[1]);
            int x_start = Int32.Parse(line.Split(' ')[2]);
            int y_start = Int32.Parse(line.Split(' ')[3]);
            int p = Int32.Parse(line.Split(' ')[4]);

            int x_end = x_start + w;
            int y_end = y_start + h;
            int r = h / 2;
            int y_half = y_start + r;
            int cnt = 0;
            int x = 0;
            int y = 0;
            for(int i = 0; i < p; i++)
            {
                line = Console.ReadLine();
                x = Int32.Parse(line.Split(' ')[0]);
                y = Int32.Parse(line.Split(' ')[1]);
                if ((x_start <= x && x <= x_end && y_start <= y && y <= y_end)
                    || getDistance(x, y, x_start, y_half) <= r
                    || getDistance(x, y, x_end, y_half) <= r) cnt++;
            }

            Console.Write(cnt);
        }
    }
}
