namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_11176
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int T = Int32.Parse(sr.ReadLine()!);
            for (int i = 0; i < T; i++)
            {
                string line = sr.ReadLine()!;
                int E = Int32.Parse(line.Split(" ")[0]);
                int N = Int32.Parse(line.Split(" ")[1]);
                int count = 0;

                for (int j = 0; j < N; j++)
                {
                    int num = Int32.Parse(sr.ReadLine()!);
                    if (E < num)
                    {
                        count++;
                    }
                }

                sw.WriteLine(count);
            }

            sr.Close();
            sw.Close();
        }
    }
}
