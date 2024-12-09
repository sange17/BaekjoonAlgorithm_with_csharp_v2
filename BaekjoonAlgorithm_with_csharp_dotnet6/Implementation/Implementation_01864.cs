namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_01864
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            while (true)
            {
                string line = sr.ReadLine()!;
                if (line == "#")
                {
                    sr.Close();
                    sw.Close();
                    break;
                }

                long sum = 0;
                for (int i = 1; i <= line.Length; i++)
                {
                    if (line[i - 1] == '-')
                        sum += (0 * Convert.ToInt32(Math.Pow(8, line.Length - i)));
                    else if (line[i - 1] == '\\')
                        sum += (1 * Convert.ToInt32(Math.Pow(8, line.Length - i)));
                    else if (line[i - 1] == '(')
                        sum += (2 * Convert.ToInt32(Math.Pow(8, line.Length - i)));
                    else if (line[i - 1] == '@')
                        sum += (3 * Convert.ToInt32(Math.Pow(8, line.Length - i)));
                    else if (line[i - 1] == '?')
                        sum += (4 * Convert.ToInt32(Math.Pow(8, line.Length - i)));
                    else if (line[i - 1] == '>')
                        sum += (5 * Convert.ToInt32(Math.Pow(8, line.Length - i)));
                    else if (line[i - 1] == '&')
                        sum += (6 * Convert.ToInt32(Math.Pow(8, line.Length - i)));
                    else if (line[i - 1] == '%')
                        sum += (7 * Convert.ToInt32(Math.Pow(8, line.Length - i)));
                    else if (line[i - 1] == '/')
                        sum += (-1 * Convert.ToInt32(Math.Pow(8, line.Length - i)));
                }

                sw.WriteLine(sum);
            }
        }
    }
}
