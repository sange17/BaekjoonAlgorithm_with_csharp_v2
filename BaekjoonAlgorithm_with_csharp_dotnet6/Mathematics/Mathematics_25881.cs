namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_25881
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string line = sr.ReadLine();
            int first = Int32.Parse(line.Split(" ")[0]);
            int second = Int32.Parse(line.Split(" ")[1]);
            int n = Int32.Parse(sr.ReadLine());

            int value = 0;
            for (int i = 0; i < n; i++)
            {
                value = Int32.Parse(sr.ReadLine());

                if(value <= 1000)
                {
                    sw.WriteLine(value + " " + value * first);
                }
                else
                {
                    sw.WriteLine(value + " " + (1000 * first + (value - 1000) * second));
                }
            }

            sr.Close();
            sw.Close();
        }
    }
}
