namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_29738
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int T = Int32.Parse(sr.ReadLine()!);
            for (int i = 1; i <= T; i++)
            {
                int N = Int32.Parse(sr.ReadLine()!);
                if (N > 4500)
                    sw.WriteLine("Case #" + i + ": Round 1");
                else if (N > 1000 && N <= 4500)
                    sw.WriteLine("Case #" + i + ": Round 2");
                else if (N > 25 && N <= 1000)
                    sw.WriteLine("Case #" + i + ": Round 3");
                else
                    sw.WriteLine("Case #" + i + ": World Finals");
            }

            sr.Close();
            sw.Close();
        }
    }
}
