namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_24084
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int N = Int32.Parse(sr.ReadLine()!);
            string S = sr.ReadLine()!;

            for (int i = 1; i < N; i++)
                if (S[i] == 'J') sw.WriteLine(S[i - 1]);

            sr.Close();
            sw.Close();
        }
    }
}
