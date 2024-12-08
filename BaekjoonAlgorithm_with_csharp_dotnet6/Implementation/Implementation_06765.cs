namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_06765
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = Int32.Parse(sr.ReadLine()!);
            int width = 3 * n;
            int height = 3 * n;
            for (int i = 0; i < width; i++)
            {
                if (i / n == 0)
                {
                    for (int j = 0; j < width; j++)
                    {
                        if (j / n == 0)
                            sw.Write('*');
                        else if (j / n == 1)
                            sw.Write('x');
                        else if (j / n == 2)
                            sw.Write('*');
                    }
                }
                else if (i / n == 1)
                {
                    for (int j = 0; j < width; j++)
                    {
                        if (j / n == 0)
                            sw.Write(' ');
                        else if (j / n == 1)
                            sw.Write('x');
                        else if (j / n == 2)
                            sw.Write('x');
                    }
                }
                else if (i / n == 2)
                {
                    for (int j = 0; j < width; j++)
                    {
                        if (j / n == 0)
                            sw.Write('*');
                        else if (j / n == 1)
                            sw.Write(' ');
                        else if (j / n == 2)
                            sw.Write('*');
                    }
                }
                sw.WriteLine();
            }

            sr.Close();
            sw.Close();
        }
    }
}
