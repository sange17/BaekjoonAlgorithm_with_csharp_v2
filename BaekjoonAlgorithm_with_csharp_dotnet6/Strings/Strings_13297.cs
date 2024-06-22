namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_13297
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = Int32.Parse(sr.ReadLine());
            for (int i = 0; i < n; i++)
            {
                sw.WriteLine(sr.ReadLine().Length);
            }

            sr.Close();
            sw.Close();
        }
    }
}
