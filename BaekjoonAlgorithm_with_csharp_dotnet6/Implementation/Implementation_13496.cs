namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_13496
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int K = Int32.Parse(sr.ReadLine());
            int n = 0;
            int s = 0;
            int d = 0;
            int di = 0;
            int vi = 0;
            int result = 0;
            string line = string.Empty;
            for(int i = 1; i <= K; i++)
            {
                sw.WriteLine("Data Set " + i + ":");

                line = sr.ReadLine();
                n = Int32.Parse(line.Split(" ")[0]);
                s = Int32.Parse(line.Split(" ")[1]);
                d = Int32.Parse(line.Split(" ")[2]);
                for(int j = 0; j < n; j++)
                {
                    line = sr.ReadLine();
                    di = Int32.Parse(line.Split(" ")[0]);
                    vi = Int32.Parse(line.Split(" ")[1]);

                    if(s * d >= di)
                    {
                        result += vi;
                    }
                }

                sw.WriteLine(result);
                sw.WriteLine();

                result = 0;
            }

            sr.Close();
            sw.Close();
        }
    }
}
