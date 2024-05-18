namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_26340
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = Int32.Parse(sr.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string line = sr.ReadLine();
                int a = Int32.Parse(line.Split(" ")[0]);
                int b = Int32.Parse(line.Split(" ")[1]);
                int f = Int32.Parse(line.Split(" ")[2]);

                for (int j = 0; j < f; j++)
                {
                    int line1 = Math.Max(a, b);
                    int iine2 = Math.Min(a, b);

                    a = line1 / 2;
                    b = iine2;
                }

                if(i != n - 1)
                {
                    sw.WriteLine("Data set: " + line);
                    sw.WriteLine(Math.Max(a, b) + " " + Math.Min(a, b));
                    sw.WriteLine();
                }
                else
                {
                    sw.WriteLine("Data set: " + line);
                    sw.WriteLine(Math.Max(a, b) + " " + Math.Min(a, b));
                }
            }

            sr.Close();
            sw.Close();
        }
    }
}
