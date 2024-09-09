namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_26040
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string line = sr.ReadLine()!;
            string[] chars = sr.ReadLine()!.Split();

            for(int i = 0; i < line.Length; i++)
            {
                if (chars.Contains(line[i].ToString()))
                    sw.Write(line[i].ToString().ToLower());
                else
                    sw.Write(line[i]);
            }

            sr.Close();
            sw.Close();
        }
    }
}
