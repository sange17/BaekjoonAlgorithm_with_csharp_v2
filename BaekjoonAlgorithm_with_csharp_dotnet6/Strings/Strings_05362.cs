namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_05362
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            while (true)
            {
                string line = sr.ReadLine()!;
                if (string.IsNullOrEmpty(line)) break;
                sw.WriteLine(line.Replace("iiing", "th"));
            }

            sr.Close();
            sw.Close();
        }
    }
}
