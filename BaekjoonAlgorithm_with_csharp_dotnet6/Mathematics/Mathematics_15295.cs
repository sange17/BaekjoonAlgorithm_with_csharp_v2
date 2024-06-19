namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_15295
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = Int32.Parse(sr.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string line = sr.ReadLine();
                int K = Int32.Parse(line.Split(" ")[0]);
                int N = Int32.Parse(line.Split(" ")[1]);

                sw.WriteLine(K + " " + N * (N + 3) / 2);
            }

            sr.Close();
            sw.Close();
        }
    }
}
