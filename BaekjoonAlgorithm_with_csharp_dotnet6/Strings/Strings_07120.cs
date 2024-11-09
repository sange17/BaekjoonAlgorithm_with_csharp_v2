namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_07120
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string line = sr.ReadLine()!;
            sw.Write(line[0]);
            for (int i = 1; i < line.Length; i++)
            {
                if (line[i] == line[i - 1]) continue;
                else sw.Write(line[i]);
            }

            sr.Close();
            sw.Close();
        }
    }
}
