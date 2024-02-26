namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_30032
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string line = sr.ReadLine();
            int N = Int32.Parse(line.Split(" ")[0]);
            int D = Int32.Parse(line.Split(" ")[1]);

            // 상하
            if (D == 1)
            {
                for (int i = 0; i < N; i++)
                {
                    line = sr.ReadLine();
                    for(int j = 0; j < line.Length; j++)
                    {
                        if (line[j] == 'd')
                            sw.Write('q');
                        else if (line[j] == 'b')
                            sw.Write('p');
                        else if (line[j] == 'q')
                            sw.Write('d');
                        else if (line[j] == 'p')
                            sw.Write('b');
                    }
                    sw.WriteLine();
                }
            }
            //좌우
            else if (D == 2)
            {
                for (int i = 0; i < N; i++)
                {
                    line = sr.ReadLine();
                    for (int j = 0; j < line.Length; j++)
                    {
                        if (line[j] == 'd')
                            sw.Write('b');
                        else if (line[j] == 'b')
                            sw.Write('d');
                        else if (line[j] == 'q')
                            sw.Write('p');
                        else if (line[j] == 'p')
                            sw.Write('q');
                    }
                    sw.WriteLine();
                }
            }
            sr.Close();
            sw.Close();
        }
    }
}
