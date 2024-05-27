namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_06438
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = Int32.Parse(sr.ReadLine());
            string line = string.Empty;

            for(int i = 0; i < n; i++)
            {
                line = sr.ReadLine();

                for (int j = line.Length - 1; j >= 0; j--)
                {
                    sw.Write(line[j]);
                }
                sw.WriteLine();
            }

            sr.Close();
            sw.Close();
        }
    }
}
