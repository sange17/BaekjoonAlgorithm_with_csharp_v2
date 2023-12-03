using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_26560
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int N = Int32.Parse(sr.ReadLine());

            string line = string.Empty;
            int lineLength = 0;
            for(int i = 0; i < N;  i++)
            {
                line = sr.ReadLine();
                lineLength = line.Length;

                if(line[lineLength - 1] != '.')
                    sw.WriteLine(line + ".");
                else
                    sw.WriteLine(line);
            }

            sr.Close();
            sw.Close();
        }
    }
}
