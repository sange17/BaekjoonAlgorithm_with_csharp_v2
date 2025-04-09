namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_06162
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int K = Int32.Parse(sr.ReadLine()!);
            for(int i = 1; i <= K; i++)
            {
                string line = sr.ReadLine()!;
                int E = Int32.Parse(line.Split(" ")[0]);
                int A = Int32.Parse(line.Split(" ")[1]);

                sw.WriteLine("Data Set " + i + ":");
                int times = 0;
                while (E > A)
                {
                    A *= 5;
                    times++;
                }

                if (times == 0)
                {
                    sw.Write("no ");
                }
                else
                {
                    for (int j = 0; j < times - 1; j++)
                    {
                        sw.Write("mega ");
                    }
                }

                sw.WriteLine("drought\n");
            }

            sr.Close();
            sw.Close();
        }
    }
}
