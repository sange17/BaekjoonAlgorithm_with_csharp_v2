namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_13225
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int c = Int32.Parse(sr.ReadLine()!);

            for (int i = 0; i < c; i++)
            {
                int n = Int32.Parse(sr.ReadLine()!);
                
                int count = 0;
                for (int j = 1; j <= n; j++)
                {
                    if (n % j == 0) count++;
                }

                sw.WriteLine(n + " " + count);
            }

            sr.Close();
            sw.Close();
        }
    }
}
