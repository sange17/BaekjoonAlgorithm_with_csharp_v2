namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_31656
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            string line = sr.ReadLine()! + '*';
            for (int i = 1; i < line.Length; i++)
            {
                if (line[i - 1] == line[i]) continue;
                else sw.Write(line[i - 1]);
            }

            sr.Close();
            sw.Close();
        }
    }
}
