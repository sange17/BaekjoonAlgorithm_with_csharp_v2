namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_01485
    {
        class Point
        {
            public int x;
            public int y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        static double calculateDistance(Point p1, Point p2)
        {
            int dx = p1.x - p2.x;
            int dy = p1.y - p2.y;
            return Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2));
        }

        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int T = Int32.Parse(sr.ReadLine());

            for(int i = 0; i < T; i++)
            {
                List<Point> points = new List<Point>();
                for(int j = 0; j < 4; j++)
                {
                    string line = sr.ReadLine();
                    int x = Int32.Parse(line.Split(" ")[0]);
                    int y = Int32.Parse(line.Split(" ")[1]);
                    points.Add(new Point(x, y));
                }

                double[] len = new double[6];
                int count = 0;
                for(int j = 0; j < 3; j++)
                {
                    for(int k = j + 1; k < 4; k++)
                    {
                        if (j == 0 && k == 1)
                            len[count++] = calculateDistance(points[j], points[k]);
                        else
                            len[count++] = calculateDistance(points[j], points[k]);
                    }
                }
                bool isSquare = true;

                // 정사각형이면 변의 길이를 sort했을 때 앞에 4개의 값은 4개의 변이 되고
                // 뒤의 2개의 값은 대각선이 될 것이다.
                Array.Sort(len);
                // 4개의 변중 하나라도 다르면 정사각형 아님
                for(int j = 1; j < 4; j++)
                {
                    if (len[0] != len[j]) isSquare = false;
                }
                // 대각선의 길이가 같지 않으면 정사각형 아님
                if (len[4] != len[5]) isSquare = false;

                if (isSquare)
                    sw.WriteLine(1);
                else
                    sw.WriteLine(0);
            }
            sr.Close();
            sw.Close();
        }
    }
}
