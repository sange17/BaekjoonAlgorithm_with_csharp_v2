using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_24196
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string line = sr.ReadLine();
            string first = line[0].ToString();
            sw.Write(first);

            int idx = 0;
            int preIdx = 0;
            while(true)
            {
                idx = line[preIdx] - 64;
                preIdx += idx;
                sw.Write(line[preIdx]);

                if (preIdx == line.Length - 1) break;
            }

            sr.Close();
            sw.Close();
        }
    }
}
