namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_33163
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int N = Int32.Parse(sr.ReadLine()!);
            string line = sr.ReadLine()!;

            for (int i = 0; i < N; i++)
            {
                if (line[i] == 'J') sw.Write("O");
                else if (line[i] == 'O') sw.Write("I");
                else if (line[i] == 'I') sw.Write("J");
            }

            sr.Close();
            sw.Close();
        }
    }
}
