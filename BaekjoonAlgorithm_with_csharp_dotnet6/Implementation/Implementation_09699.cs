namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_09699
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int N = Int32.Parse(sr.ReadLine());

            string line = string.Empty;

            for(int i = 1; i <= N; i++)
            {
                line = sr.ReadLine();

                int max = 0;
                for(int j = 0; j < 5; j++)
                {
                    if(Int32.Parse(line.Split(" ")[j]) > max)
                    {
                        max = Int32.Parse(line.Split(" ")[j]);
                    }
                }
                sw.WriteLine("Case #" + i + ": " + max);
            }

            sr.Close();
            sw.Close();
        }
    }
}
