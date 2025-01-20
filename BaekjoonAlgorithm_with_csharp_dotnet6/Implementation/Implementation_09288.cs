namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_09288
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = Int32.Parse(sr.ReadLine()!);

            for (int i = 1; i <= n; i++)
            {
                int num = Int32.Parse(sr.ReadLine()!);

                sw.WriteLine("Case " + i + ":");

                bool flag = false;
                for (int j = 1; j <= 6; j++)
                {
                    for (int k = 1; k <= 6; k++)
                    {
                        if (j > k) continue;

                        if(j + k == num)
                            sw.WriteLine("(" + j + "," + k + ")");
                    }
                }
            }

            sr.Close();
            sw.Close();
        }
    }
}
