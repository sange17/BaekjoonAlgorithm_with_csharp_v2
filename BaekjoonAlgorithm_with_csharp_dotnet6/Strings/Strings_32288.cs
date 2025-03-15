namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    internal class Strings_32288
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int N = Int32.Parse(sr.ReadLine()!);
            string line = sr.ReadLine()!;

            for (int i = 0; i < N; i++)
            {
                if (line[i] == 'I') sw.Write("i");
                else if (line[i] == 'l') sw.Write("L");
            }

            //test
            sr.Close();
            sw.Close();
        }
    }
}
