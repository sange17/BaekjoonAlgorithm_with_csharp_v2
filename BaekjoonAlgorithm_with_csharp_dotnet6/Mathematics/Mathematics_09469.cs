namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_09469
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int P = Int32.Parse(sr.ReadLine()!);
            for (int i = 0; i < P; i++)
            {
                string line = sr.ReadLine()!;
                double N = double.Parse(line.Split(" ")[0]);
                double D = double.Parse(line.Split(" ")[1]);
                double A = double.Parse(line.Split(" ")[2]);
                double B = double.Parse(line.Split(" ")[3]);
                double F = double.Parse(line.Split(" ")[4]);

                sw.WriteLine(N + " " + Math.Round(((D / (A + B)) * F), 6, MidpointRounding.AwayFromZero));
            }

            sr.Close();
            sw.Close();
        }
    }
}
