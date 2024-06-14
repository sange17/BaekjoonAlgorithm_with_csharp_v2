namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_07581
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string line = string.Empty;

            while(true)
            {
                line = sr.ReadLine();

                if (line == "0 0 0 0") break;

                int L = Int32.Parse(line.Split(" ")[0]);
                int W = Int32.Parse(line.Split(" ")[1]);
                int H = Int32.Parse(line.Split(" ")[2]);
                int V = Int32.Parse(line.Split(" ")[3]);

                if (L == 0)
                {
                    L = V / (W * H);
                    sw.WriteLine(L + " " + W + " " + H + " " + V);
                }
                else if (W == 0)
                {
                    W = V / (L * H);
                    sw.WriteLine(L + " " + W + " " + H + " " + V);
                }
                else if (H == 0)
                {
                    H = V / (L * W);
                    sw.WriteLine(L + " " + W + " " + H + " " + V);
                }
                else if (V == 0)
                {
                    V =  L * W * H;
                    sw.WriteLine(L + " " + W + " " + H + " " + V);
                }
            }

            sr.Close();
            sw.Close();
        }
    }
}
