namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_09698
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);
            for (int i = 1; i <= n; i++)
            {
                string line = Console.ReadLine()!;
                int h = Int32.Parse(line.Split(" ")[0]);
                int m = Int32.Parse(line.Split(" ")[1]);

                int resultM = m - 45;
                int resultH = h;
                if (resultM < 0)
                {
                    resultH = h - 1;
                    if (resultH < 0)
                    {
                        resultH = 24 + resultH;
                    }
                    resultM = 59 + resultM + 1;
                }

                Console.WriteLine("Case #" + i + ": " + resultH + " " + resultM);
            }
        }
    }
}
