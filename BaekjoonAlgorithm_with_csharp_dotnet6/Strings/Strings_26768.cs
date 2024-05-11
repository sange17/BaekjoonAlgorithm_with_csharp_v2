namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_26768
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string line = sr.ReadLine();
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == 'a')
                    sw.Write('4');
                else if (line[i] == 'e')
                    sw.Write('3');
                else if (line[i] == 'i')
                    sw.Write('1');
                else if (line[i] == 'o')
                    sw.Write('0');
                else if (line[i] == 's')
                    sw.Write('5');
                else
                    sw.Write(line[i]);
            }

            sr.Close();
            sw.Close();
        }
    }
}
