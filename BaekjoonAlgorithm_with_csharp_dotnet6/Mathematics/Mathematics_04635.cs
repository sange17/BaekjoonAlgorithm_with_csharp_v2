namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_04635
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            while (true)
            {
                int n = Int32.Parse(sr.ReadLine()!);

                if (n == -1)
                {
                    sr.Close();
                    sw.Close();
                    break;
                }

                int hour = 0;
                int miles = 0;
                int[] logs;
                for (int i = 0; i < n; i++)
                {
                    logs = sr.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
                    hour = logs[1] - hour;
                    miles += (logs[0] * hour);
                    hour = logs[1];
                }

                sw.WriteLine(miles + " miles");
            }
        }
    }
}
