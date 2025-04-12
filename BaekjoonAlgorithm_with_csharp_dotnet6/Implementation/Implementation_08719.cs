namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_08719
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int t = Int32.Parse(sr.ReadLine()!);
            for (int i = 0; i < t; i++)
            {
                string line = sr.ReadLine()!;
                int x = Int32.Parse(line.Split(" ")[0]);
                int w = Int32.Parse(line.Split(" ")[1]);
                int count = 0;

                while (true)
                {
                    if (x >= w)
                    {
                        sw.WriteLine(count);
                        break;
                    }

                    x *= 2;
                    count++;
                }
            }

            sr.Close();
            sw.Close();
        }
    }
}
