namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_24267
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            long n = long.Parse(sr.ReadLine());

            sw.WriteLine((n * (n - 1) * (n - 2)) / 6);
            sw.Write(3);

            sr.Close();
            sw.Close();
        }
    }
}
