namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_24783
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = Int32.Parse(sr.ReadLine()!);
            for (int i = 0; i < n; i++)
            {
                string? line = sr.ReadLine()!;
                int a = Int32.Parse(line.Split(" ")[0]);
                int b = Int32.Parse(line.Split(" ")[1]);
                int c = Int32.Parse(line.Split(" ")[2]);

                if (a + b == c
                 || a - b == c || b - a == c
                 || a * b == c
                 || (b != 0 && a / b == c && a % b == 0)
                 || (a != 0 && b / a == c && b % a == 0))
                {
                    sw.WriteLine("Possible");
                }
                else
                {
                    sw.WriteLine("Impossible");
                }
            }
            sr.Close();
            sw.Close();
        }
    }
}
