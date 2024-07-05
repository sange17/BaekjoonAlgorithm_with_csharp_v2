namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_19774
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = Int32.Parse(sr.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string line = sr.ReadLine();
                int a = Int32.Parse(line.Substring(0, 2));
                int b = Int32.Parse(line.Substring(2, 2));

                if ((a * a + b * b) % 7 == 1)
                {
                    sw.WriteLine("YES");
                }
                else
                {
                    sw.WriteLine("NO");
                }
            }

            sr.Close();
            sw.Close();
        }
    }
}
