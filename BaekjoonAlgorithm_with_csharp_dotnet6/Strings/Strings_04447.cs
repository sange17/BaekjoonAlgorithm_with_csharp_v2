namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_04447
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = Int32.Parse(sr.ReadLine()!);
            for (int i = 0; i < n; i++)
            {
                string line = sr.ReadLine()!;
                int gCnt = 0;
                int bCnt = 0;
                for (int j = 0; j < line.Length; j++)
                {
                    if (line[j] == 'g' || line[j] == 'G')
                        gCnt++;
                    else if (line[j] == 'b' || line[j] == 'B')
                        bCnt++;
                }

                if (gCnt > bCnt)
                    sw.WriteLine(line + " is GOOD");
                else if (gCnt == bCnt)
                    sw.WriteLine(line + " is NEUTRAL");
                else if (gCnt < bCnt)
                    sw.WriteLine(line + " is A BADDY");
            }

            sr.Close();
            sw.Close();
        }
    }
}
