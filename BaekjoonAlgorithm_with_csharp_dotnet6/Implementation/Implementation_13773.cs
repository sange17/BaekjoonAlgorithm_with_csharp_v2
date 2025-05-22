namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    internal class Implementation_13773
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            while (true)
            {
                int year = Int32.Parse(sr.ReadLine()!);
                if (year == 0) break;

                if (year == 1916 || year == 1940 || year == 1944)
                {
                    sw.WriteLine(year + " Games cancelled");
                }
                else if (year % 4 == 0 && year >= 1896)
                {
                    if (year <= 2020)
                        sw.WriteLine(year + " Summer Olympics");
                    else
                        sw.WriteLine(year + " No city yet chosen");
                }
                else
                {
                    sw.WriteLine(year + " No summer games");
                }
            }

            sr.Close();
            sw.Close();
        }
    }
}
