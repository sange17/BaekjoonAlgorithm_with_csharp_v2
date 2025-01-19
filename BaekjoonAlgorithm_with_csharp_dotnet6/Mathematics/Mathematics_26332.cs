namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_26332
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int N = Int32.Parse(sr.ReadLine()!);
            for (int i = 0; i < N; i++)
            {
                string line = sr.ReadLine()!;
                int c = Int32.Parse(line.Split(" ")[0]);
                int p = Int32.Parse(line.Split(" ")[1]);

                sw.WriteLine(line);
                sw.WriteLine(c * p - ((c - 1) * 2));
            }

            sr.Close();
            sw.Close();
        }
    }
}
