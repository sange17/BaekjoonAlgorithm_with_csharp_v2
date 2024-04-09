namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_17548
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string line = sr.ReadLine();
            int cnt = 0;
            for(int i = 0; i < line.Length; i++)
                if (line[i] == 'e') cnt++;

            sw.Write('h');
            for (int i = 0; i < cnt * 2; i++)
                sw.Write('e');
            sw.Write('y');

            sr.Close();
            sw.Close();
        }
    }
}
