namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_24408
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = Convert.ToInt32(sr.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int num = Convert.ToInt32(sr.ReadLine());
                i++;

                while (i <= n - 1)
                {
                    int multi = Convert.ToInt32(sr.ReadLine());
                    if (multi % num == 0)
                    {
                        sw.WriteLine(multi);
                        break;
                    }

                    i++;
                }
            }

            sr.Close();
            sw.Close();
        }
    }
}
