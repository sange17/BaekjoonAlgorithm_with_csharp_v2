namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_26546
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = Int32.Parse(sr.ReadLine()!);

            for (int i = 0; i < n; i++)
            {
                string line = sr.ReadLine()!;
                string word = line.Split(" ")[0];
                int start = Int32.Parse(line.Split(" ")[1]);
                int end = Int32.Parse(line.Split(" ")[2]);

                sw.WriteLine(word.Remove(start, end - start));
            }

            sr.Close();
            sw.Close();
        }
    }
}
