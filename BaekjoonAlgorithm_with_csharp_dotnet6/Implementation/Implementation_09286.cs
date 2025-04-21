namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_09286
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int x = Int32.Parse(sr.ReadLine()!);

            for (int i = 1; i <= x; i++)
            {
                int n = Int32.Parse(sr.ReadLine()!);
                sw.WriteLine("Case " + i + ":");
                for (int j = 0; j < n; j++)
                {
                    int grade = Int32.Parse(sr.ReadLine()!);
                    if (grade < 6)
                    {
                        grade++;
                        sw.WriteLine(grade);
                    }
                }
            }

            sr.Close();
            sw.Close();
        }
    }
}
