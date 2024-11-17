namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_04606
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            while (true)
            {
                string line = Console.ReadLine()!;

                if(line == "#")
                {
                    sr.Close();
                    sw.Close();
                    break;
                }

                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == ' ')
                    {
                        sw.Write("%20");
                    }
                    else if (line[i] == '!')
                    {
                        sw.Write("%21");
                    }
                    else if (line[i] == '$')
                    {
                        sw.Write("%24");
                    }
                    else if (line[i] == '%')
                    {
                        sw.Write("%25");
                    }
                    else if (line[i] == '(')
                    {
                        sw.Write("%28");
                    }
                    else if (line[i] == ')')
                    {
                        sw.Write("%29");
                    }
                    else if (line[i] == '*')
                    {
                        sw.Write("%2a");
                    }
                    else
                    {
                        sw.Write(line[i]);
                    }
                }

                sw.WriteLine();
            }
        }
    }
}
