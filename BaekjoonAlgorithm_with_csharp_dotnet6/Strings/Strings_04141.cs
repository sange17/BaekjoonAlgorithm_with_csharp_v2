namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_04141
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = Int32.Parse(sr.ReadLine()!);
            for (int i = 0; i < n; i++)
            {
                string line = sr.ReadLine()!;
                string makeLine = string.Empty;
                for (int j = 0; j < line.Length; j++)
                {
                    char alpha = line[j].ToString().ToLower()[0];
                    if (alpha >= 'a' && alpha <= 'c')
                        makeLine += '2';
                    else if (alpha >= 'd' && alpha <= 'f')
                        makeLine += '3';
                    else if (alpha >= 'g' && alpha <= 'i')
                        makeLine += '4';
                    else if (alpha >= 'j' && alpha <= 'l')
                        makeLine += '5';
                    else if (alpha >= 'm' && alpha <= 'o')
                        makeLine += '6';
                    else if (alpha >= 'p' && alpha <= 's')
                        makeLine += '7';
                    else if (alpha >= 't' && alpha <= 'v')
                        makeLine += '8';
                    else if (alpha >= 'w' && alpha <= 'z')
                        makeLine += '9';
                }

                bool flag = false;
                for (int j = 0; j < makeLine.Length / 2; j++)
                {
                    if (makeLine[j] != makeLine[makeLine.Length - 1 - j])
                    {
                        flag = true;
                        break;
                    }
                    else
                    {
                        flag = false;
                    }
                }

                if (flag)
                {
                    sw.WriteLine("NO");
                }
                else
                {
                    sw.WriteLine("YES");
                }
            }

            sr.Close();
            sw.Close();
        }
    }
}
