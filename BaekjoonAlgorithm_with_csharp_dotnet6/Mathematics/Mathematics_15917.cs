namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_15917
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int Q = Int32.Parse(sr.ReadLine()!);
            int answer = 0;
            
            for (int i = 0; i < Q; i++)
            {
                long num = long.Parse(sr.ReadLine()!);

                if ((num & (num - 1)) == 0)
                    answer = 1;
                else
                    answer = 0;

                sw.WriteLine(answer);
            }

            sr.Close();
            sw.Close();
        }
    }
}
