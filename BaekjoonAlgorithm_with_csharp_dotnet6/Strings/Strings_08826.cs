namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_08826
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int T = Int32.Parse(sr.ReadLine()!);
            
            for (int i = 0; i < T; i++)
            {
                int n = Int32.Parse(sr.ReadLine()!);
                string line = sr.ReadLine()!;
                int row = 0;
                int col = 0;

                for (int j = 0; j < n; j++)
                {
                    if (line[j] == 'E')
                        col++;
                    else if (line[j] == 'W')
                        col--;
                    else if (line[j] == 'N')
                        row++;
                    else if (line[j] == 'S')
                        row--;
                }
                sw.WriteLine(Math.Abs(col) + Math.Abs(row));
            }

            sr.Close();
            sw.Close();
        }
    }
}
