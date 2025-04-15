namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_09297
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int t = Int32.Parse(sr.ReadLine()!);
            for(int i = 1; i <= t; i++)
            {
                string line = sr.ReadLine()!;
                int n = Int32.Parse(line.Split(" ")[0]);
                int d = Int32.Parse(line.Split(" ")[1]);

                int quotient = (n / d);
                int remainder = (n % d);

                if(remainder == 0)
                    sw.WriteLine("Case " + i + ": " + quotient);
                else if(quotient == 0)
                    sw.WriteLine("Case " + i + ": " + remainder + "/" + d);
                else
                    sw.WriteLine("Case " + i + ": " + quotient + " " + remainder + "/" + d);
            }

            sr.Close();
            sw.Close();
        }
    }
}
