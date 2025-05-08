namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_02765
    {
        public void solve()
        {
            int N = 1;
            while (true)
            {
                string line = Console.ReadLine()!;
                double r = double.Parse(line.Split(" ")[0]);
                int c = Int32.Parse(line.Split(" ")[1]);
                double t = double.Parse(line.Split(" ")[2]);

                if (c == 0) break;

                double distance = r * 3.1415927 * c / 12 / 5280;
                double MPH = distance / (t / 3600);

                Console.WriteLine("Trip #" + N + ": " + Math.Round(distance, 2, MidpointRounding.AwayFromZero).ToString("0.00") + " " + Math.Round(MPH, 2, MidpointRounding.AwayFromZero).ToString("0.00"));
                N++;
            }
        }
    }
}
