namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_09783
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string line = sr.ReadLine()!;

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] >= 97 && line[i] <= 122)
                    sw.Write((line[i] - 96).ToString().PadLeft(2, '0'));
                else if (line[i] >= 65 && line[i] <= 90)
                    sw.Write((line[i] - 64 + 26).ToString());
                else if (line[i] >= 48 && line[i] <= 57)
                    sw.Write(line[i].ToString().PadLeft(2, '#'));
                else 
                    sw.Write(line[i]);
            }

            sr.Close();
            sw.Close();
        }
    }
}
