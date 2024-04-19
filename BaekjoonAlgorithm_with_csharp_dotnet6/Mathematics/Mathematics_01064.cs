namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_01064
    {
        static double getLength(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }

        public void solve()
        {
            string line = Console.ReadLine();
            int aX = Int32.Parse(line.Split(" ")[0]);
            int aY = Int32.Parse(line.Split(" ")[1]);
            int bX = Int32.Parse(line.Split(" ")[2]);
            int bY = Int32.Parse(line.Split(" ")[3]);
            int cX = Int32.Parse(line.Split(" ")[4]);
            int cY = Int32.Parse(line.Split(" ")[5]);

            if((bX - aX) * (cY - aY) == (cX - aX) * (bY - aY))
            {
                Console.WriteLine(-1);
                return;
            }

            double ab = getLength(aX, aY, bX, bY);
            double bc = getLength(bX, bY, cX, cY);
            double ca = getLength(cX, cY, aX, aY);

            double max = Math.Max(ab, Math.Max(bc, ca));
            double min = Math.Min(ab, Math.Min(bc, ca));

            Console.Write(2 * (max - min));
        }
    }
}
