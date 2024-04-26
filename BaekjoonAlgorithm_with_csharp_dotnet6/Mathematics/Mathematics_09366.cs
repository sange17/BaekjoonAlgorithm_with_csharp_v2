namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_09366
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = Int32.Parse(sr.ReadLine());
            string[] lines = new string[3];

            for(int i = 1; i <= n; i++)
            {
                lines = sr.ReadLine().Split(" ");

                Array.Sort(lines);

                int a = Int32.Parse(lines[0]);
                int b = Int32.Parse(lines[1]);
                int c = Int32.Parse(lines[2]);

                // 1 2 3
                // 1 2 2 
                // 2 2 2 
                // 1 1 2
                if (a + b <= c)
                {
                    sw.Write("Case #" + i + ": invalid!");
                }
                else if ((a == b) && (b == c))
                {
                    sw.Write("Case #" + i + ": equilateral");
                }
                else if ((a == b) || (b == c))
                {
                    sw.Write("Case #" + i + ": isosceles");
                }
                else
                {
                    sw.Write("Case #" + i + ": scalene");
                }

                if (i != n) sw.WriteLine();
            }

            sr.Close();
            sw.Close();
        }
    }
}
