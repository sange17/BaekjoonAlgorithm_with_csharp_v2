namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_01362
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            bool check = false;
            bool die = false;
            int t = 0;
            int o = 0;
            int w = 0;
            string x = string.Empty;
            int n = 0;
            while (true)
            {
                string line = sr.ReadLine()!;

                if (line == "0 0")
                {
                    sr.Close();
                    sw.Close();
                    break;
                }

                if (line == "# 0")
                {
                    if (die)
                        sw.WriteLine(t + " RIP");
                    else if (o * 0.5 < w && o * 2 > w)
                        sw.WriteLine(t + " :-)");
                    else
                        sw.WriteLine(t + " :-(");

                    check = false;
                    die = false;
                    continue;
                }

                if (!check)
                {
                    o = Int32.Parse(line.Split(" ")[0]);
                    w = Int32.Parse(line.Split(" ")[1]);

                    t++;
                    check = true;
                    continue;
                }

                if (check)
                {
                    x = line.Split(" ")[0];
                    n = Int32.Parse(line.Split(" ")[1]);

                    if (!die)
                    {
                        if (x == "F") w += n;
                        else if (x == "E") w -= n;

                        if (w <= 0) die = true;
                    }
                }
            }
        }
    }
}
