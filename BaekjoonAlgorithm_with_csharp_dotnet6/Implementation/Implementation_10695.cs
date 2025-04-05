namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_10695
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int t = Int32.Parse(sr.ReadLine()!);
            for (int i = 1; i <= t; i++)
            {
                int[] array = sr.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
                int n = array[0];
                int r1 = array[1];
                int c1 = array[2];
                int r2 = array[3];
                int c2 = array[4];

                if (r1 + 1 == r2 && c1 + 2 == c2)
                    sw.WriteLine("Case " + i + ": YES");
                else if (r1 + 2 == r2 && c1 + 1 == c2)
                    sw.WriteLine("Case " + i + ": YES");
                else if (r1 + 1 == r2 && c1 - 2 == c2)
                    sw.WriteLine("Case " + i + ": YES");
                else if (r1 + 2 == r2 && c1 - 1 == c2)
                    sw.WriteLine("Case " + i + ": YES");

                else if (r1 - 2 == r2 && c1 + 1 == c2)
                    sw.WriteLine("Case " + i + ": YES");
                else if (r1 - 1 == r2 && c1 + 2 == c2)
                    sw.WriteLine("Case " + i + ": YES");
                else if (r1 - 2 == r2 && c1 - 1 == c2)
                    sw.WriteLine("Case " + i + ": YES");
                else if (r1 - 1 == r2 && c1 - 2 == c2)
                    sw.WriteLine("Case " + i + ": YES");
                else
                    sw.WriteLine("Case " + i + ": NO");
            }

            sr.Close();
            sw.Close();
        }
    }
}
